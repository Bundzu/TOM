using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kitware.VTK;

// Labo 6 odczyt i zapis plików vtk oraz konwersja z stl na vtk, jeżeli są jakieś błędy to sprawdź czy plik istnieje tam gdzie jest podana ścieżka dostępu

namespace Git6
{
    public partial class Form1 : Form
    {
        private vtkActor cylinderActor;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadStl_Click(object sender, EventArgs e)                // wczytujemy gotowy plik stl
        {
            vtkSTLReader stlReader = vtkSTLReader.New();                            // źródłem będzie plik .stl więc zostaje nam tylko mapper, renderer i aktor
            stlReader.SetFileName(@"C:\bottle.stl");                                // @ oznacza że reszta jest tekstem, można bezboleśnie kopiować ścieżkę na której jest plik

            vtkPolyDataMapper stlMapper = vtkPolyDataMapper.New();
            stlMapper.SetInputConnection(stlReader.GetOutputPort());

            vtkActor stlActor = vtkActor.New();
            stlActor.SetMapper(stlMapper);

            vtkRenderWindow renderWindow = renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();
            renderer.AddActor(stlActor);                                            // aktor powinien się pojawić, naciśnij "r" aby wycentrować i "w" aby wyświetlić siatkę
                                                                                    // "s" to powrót do zwykłego widoku, wypróbujcie klawisz "j" (wiem i tak tego nikt nie czyta)
            this.renderWindowControl1.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)                   // sam zapis stożka bez wyświetlania do pliku stl
        {
            vtkConeSource coneSource = vtkConeSource.New();
            coneSource.SetResolution(30);

            vtkSTLWriter stlWriter = vtkSTLWriter.New();
            stlWriter.SetInputConnection(coneSource.GetOutputPort());
            stlWriter.SetFileName(@"C:\Users\Killy\stozek.stl");                    
            stlWriter.SetFileTypeToASCII();                                         // zapisujemy to jako zwykły plik.
            stlWriter.Write();
        }

        private void buttonSavevtk_Click(object sender, EventArgs e)                // robimy i zapisujemy cylinder do pliku vtk
        {
            vtkCylinderSource cylinderSource = vtkCylinderSource.New();
            cylinderSource.SetResolution(30);

            vtkPolyDataWriter vtkWriter = vtkPolyDataWriter.New();
            vtkWriter.SetInputConnection(cylinderSource.GetOutputPort());
            vtkWriter.SetFileName(@"C:\Users\Killy\cylinder.vtk");                
            vtkWriter.Write();
        }

        private void buttonLoadvtk_Click(object sender, EventArgs e)                // wczytujemy plik vtk i go wyświetlamy
        {
            vtkPolyDataReader cylinderReader = vtkPolyDataReader.New();             
            cylinderReader.SetFileName(@"C:\Users\Killy\cylinder.vtk");

            vtkPolyDataMapper cylinderMapper = vtkPolyDataMapper.New();
            cylinderMapper.SetInputConnection(cylinderReader.GetOutputPort());

            cylinderActor = vtkActor.New();
            cylinderActor.SetMapper(cylinderMapper);

            vtkRenderWindow renderWindow = renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();

            renderer.AddActor(cylinderActor);                                       

            this.renderWindowControl1.Refresh();
        }

        private void buttonStlToVtk_Click(object sender, EventArgs e)           // stl do vtk
        {
            vtkSTLReader stlReader = vtkSTLReader.New();                        
            stlReader.SetFileName(@"C:\Users\Killy\stozek.stl");                // wczytywanie

            vtkPolyDataWriter vtkWriter = vtkPolyDataWriter.New();
            vtkWriter.SetInputConnection(stlReader.GetOutputPort());
            vtkWriter.SetFileName(@"C:\Users\Killy\stozek.vtk");                // zapis
            vtkWriter.Write();
        }

        private void buttonVtkToStl_Click(object sender, EventArgs e)           // przerabiamy plik vtk do stl
        {
            vtkPolyDataReader cylinderReader = vtkPolyDataReader.New();
            cylinderReader.SetFileName(@"C:\Users\Killy\stozek.vtk");           // wczytujemy plik vtk

            vtkTriangleFilter triangleFilter = vtkTriangleFilter.New();         // filtr przerabia wszystko na trójkąty (plik będzie poprawnie zapisany)
            triangleFilter.SetInputConnection(cylinderReader.GetOutputPort());

            vtkSTLWriter stlWriter = vtkSTLWriter.New();
            stlWriter.SetInputConnection(triangleFilter.GetOutputPort());       // pamiętaj o filtrze!
            stlWriter.SetFileName(@"C:\Users\Killy\stozek.stl");              
            stlWriter.SetFileTypeToASCII();
            stlWriter.Write();
        }
    }
}
