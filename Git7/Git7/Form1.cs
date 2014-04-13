using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kitware.VTK;

// labo 7 interaktorzy (odpowiadają za interakcje jak np. ruch kamerą) + animacje (obracanie o 360 stopni) i robienie filmów
namespace Git7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCone_Click(object sender, EventArgs e)                       // stożek (trochę inny)
        {
            vtkConeSource coneSource = vtkConeSource.New();
            coneSource.SetResolution(6);                                                // dodatkowe opcje zmieniające wygląd stożka
            coneSource.SetHeight(0.76);
            coneSource.SetDirection(0.2, 0.6, 2.3);         

            vtkPolyDataMapper coneMapper = vtkPolyDataMapper.New();
            coneMapper.SetInputConnection(coneSource.GetOutputPort());

            vtkActor coneActor = vtkActor.New();
            coneActor.SetMapper(coneMapper);

            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renWin.GetRenderers().GetFirstRenderer();
            renderer.AddActor(coneActor); 

            this.renderWindowControl1.Refresh();
        }

        private void buttonTrackball_Click(object sender, EventArgs e)                  // interaktor zmienia ustawienie kamery
        {
            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderWindowInteractor iren = renWin.GetInteractor();
            vtkInteractorStyleTrackballCamera irenstyle = vtkInteractorStyleTrackballCamera.New();
            iren.SetInteractorStyle(irenstyle);
        }

        private void buttonJoystick_Click(object sender, EventArgs e)                   // interaktor zmienia ustawienie kamery
        {
            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderWindowInteractor iren = renWin.GetInteractor();
            vtkInteractorStyleJoystickCamera irenstyle = vtkInteractorStyleJoystickCamera.New();
            iren.SetInteractorStyle(irenstyle);
        }

        private void buttonAnime_Click(object sender, EventArgs e)                      // zapisujemy animację do pliku avi (rozdzielczość będzie taka jaka jest wielkość okna)
        {
            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renWin.GetRenderers().GetFirstRenderer();

            vtkWindowToImageFilter windowFilter = vtkWindowToImageFilter.New();         // filtr przechwytujący obraz z okna
            windowFilter.SetInput(renWin);

            vtkAVIWriter aviWriter = vtkAVIWriter.New();                                // zapisywaczka filmów
            aviWriter.SetFileName(@"C:\Users\Killy\tibia.avi");                         // ścieżka dostępu, zmień ją
            aviWriter.SetRate(25);
            aviWriter.SetInputConnection(windowFilter.GetOutputPort());

            aviWriter.Start();

            vtkCamera camera = renderer.GetActiveCamera();
            double degree = 1.0;                                                        // zmnienna potrzebna do ruchu w dół i górę (elevation)

            for (int i = 0; i < 360; i++)                                               // 360 klatek przechwytujemy
            {
                aviWriter.Write();
                camera.Azimuth(1.0);                                                    // przesuwamy kamerę o 1 stopień
                if (i % 45 == 0)                                                        // jeżeli liczba stopni jest podzielna przez 45
                    degree = degree * (-1.0);                                           // to następuje zmniana kierunku ruchu kamery
                camera.Elevation(degree);
                windowFilter.Modified();
                this.renderWindowControl1.Refresh();
            }      
            aviWriter.End();
        }  
    }
}
