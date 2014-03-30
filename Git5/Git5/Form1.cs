using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kitware.VTK;

// Labo 5: wczytanie i zapis plików (butelka i stopa)

namespace Git5
{
    public partial class Form1 : Form
    {
        private vtkActor stlActor;
        private vtkActor coneActor;
        public Form1()
        {

            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)                   // wczytywanie pliku
        {
            vtkSTLReader stlReader = vtkSTLReader.New();                            // źródłem będzie plik .stl więc zostaje nam tylko mapper, renderer i aktor
            stlReader.SetFileName("C:/bottle.stl");                                 // ścieżkę można zapisać na 2 sposoby, to pierwszy sposób z użyciem normalnych ukośników "/"

            vtkPolyDataMapper stlMapper = vtkPolyDataMapper.New();                  
            stlMapper.SetInputConnection(stlReader.GetOutputPort());

            vtkActor stlActor = vtkActor.New();
            stlActor.SetMapper(stlMapper);

            vtkRenderWindow renderWindow = renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();
            renderer.AddActor(stlActor);                                            //aktor powinien się pojawić, naciśnij "r" aby wycentrować i "w" aby wyświetlić siatkę

            this.renderWindowControl1.Refresh();

        }

        private void buttonSave_Click(object sender, EventArgs e)               // wyświetlenie stożka i jego zapis
        {
            vtkConeSource coneSource = vtkConeSource.New();
            coneSource.SetResolution(30);

            vtkPolyDataNormals phongFilter = vtkPolyDataNormals.New();          // jeżeli chcemy olać wyświetlanie stożka i od razu go zapisać można zakomentować od tej linii
            phongFilter.SetInputConnection(coneSource.GetOutputPort());             // tutaj jest filtr do stożka

            vtkPolyDataMapper coneMapper = vtkPolyDataMapper.New();                 
            coneMapper.SetInputConnection(phongFilter.GetOutputPort());             //mapper musi wskazywać na filtr

            this.coneActor = vtkActor.New();
            this.coneActor.SetMapper(coneMapper);

            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renWin.GetRenderers().GetFirstRenderer();
            renderer.AddActor(coneActor);

            this.renderWindowControl1.Refresh();                                // do tej. Stożek zostanie zapisany bez wyświetlania 

            vtkSTLWriter stlWriter = vtkSTLWriter.New();
            stlWriter.SetInputConnection(coneSource.GetOutputPort());
            stlWriter.SetFileName("C:\\Users\\Killy\\stozek.stl");              // 2 sposób zapisywania (lewe ukośniki \), nie jest możliwe proste skopiowanie i wklejenie ścieżki dostępu
            stlWriter.SetFileTypeToASCII();                                     // zapisujemy to jako zwykły plik.
            stlWriter.Write();
        }
    }
}
