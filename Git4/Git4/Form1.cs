using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kitware.VTK;

// Labo 4: robimy lody z prostych obiektów (Arrow, Cone, Cube, Cylinder, Disk, Sphere) poprzez ich przesunięcie (this.coneActor.SetPosition())

namespace Git4
{
    public partial class Form1 : Form
    {
        private vtkActor coneActor;
        private vtkActor sphereActor;
        private vtkActor sphereActor1;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateCone_Click(object sender, EventArgs e)
        {
            if (this.coneActor != null)
                return;

            vtkConeSource coneSource = vtkConeSource.New();                 
            coneSource.SetResolution(30);                                   


            vtkPolyDataMapper coneMapper = vtkPolyDataMapper.New();         
            coneMapper.SetInputConnection(coneSource.GetOutputPort());

            this.coneActor = vtkActor.New();                                
            this.coneActor.SetMapper(coneMapper);                           

            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renWin.GetRenderers().GetFirstRenderer();
            renderer.AddActor(coneActor);

            this.renderWindowControl1.Refresh();
        }

        private void buttonIce_Click(object sender, EventArgs e)
        {
            vtkConeSource coneSource = vtkConeSource.New();                 
            coneSource.SetResolution(60);                                   

            vtkSphereSource sphereSource = vtkSphereSource.New();           
            sphereSource.SetThetaResolution(30);                              // rozdzielczość kulki
            sphereSource.SetPhiResolution(30);

            vtkPolyDataMapper coneMapper = vtkPolyDataMapper.New();         
            coneMapper.SetInputConnection(coneSource.GetOutputPort());

            this.coneActor = vtkActor.New();                                
            this.coneActor.SetMapper(coneMapper);                           

            vtkPolyDataMapper sphereMapper = vtkPolyDataMapper.New();         
            sphereMapper.SetInputConnection(sphereSource.GetOutputPort());

            this.sphereActor = vtkActor.New();                                  // nowa kulka
            this.sphereActor.SetMapper(sphereMapper);                         

            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renWin.GetRenderers().GetFirstRenderer();

            renderer.AddActor(coneActor);
            renderer.AddActor(sphereActor);
            this.sphereActor.SetPosition(-0.7, 0, 0);                           // przesuwamy kulkę aby powstały lody

            this.renderWindowControl1.Refresh();
        }

        private void buttonColor_Click(object sender, EventArgs e)              // kolor rożka
        {
            if (this.coneActor == null)
                return;

            ColorDialog dialog = new ColorDialog();
            DialogResult result = dialog.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
                return;
            int r = dialog.Color.R;
            int g = dialog.Color.G;
            int b = dialog.Color.B;

            this.coneActor.GetProperty().SetColor(r / 255.0, g / 255.0, b / 255.0);
            this.renderWindowControl1.Refresh();
        }

        private void buttonTaste_Click(object sender, EventArgs e)
        {
            if (this.sphereActor == null)
                return;

            ColorDialog dialog = new ColorDialog();
            DialogResult result = dialog.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
                return;
            int r = dialog.Color.R;
            int g = dialog.Color.G;
            int b = dialog.Color.B;

            this.sphereActor.GetProperty().SetColor(r / 255.0, g / 255.0, b / 255.0);           // kolor pierwszej gałki

            if (this.sphereActor1 != null)                                                      // ustawiamy kolor drugiej gałki, jeżeli nie ma to nic nie robimy
                this.sphereActor1.GetProperty().SetColor(r / 255.0, g / 255.0, b / 255.0);
            else
                return;

            this.renderWindowControl1.Refresh();
        }

        private void buttonMore_Click(object sender, EventArgs e)                               // druga gałka
        {
            if (this.sphereActor1 != null)
                return;

            vtkSphereSource sphereSource1 = vtkSphereSource.New();             
            sphereSource1.SetThetaResolution(30);
            sphereSource1.SetPhiResolution(30);

            vtkPolyDataMapper sphereMapper1 = vtkPolyDataMapper.New();         
            sphereMapper1.SetInputConnection(sphereSource1.GetOutputPort());

            this.sphereActor1 = vtkActor.New();                                
            this.sphereActor1.SetMapper(sphereMapper1);                        

            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renWin.GetRenderers().GetFirstRenderer();

            renderer.AddActor(sphereActor1);
            this.sphereActor1.SetPosition(-1.2, 0, 0);                          // przesuwamy drugą kulkę

            this.renderWindowControl1.Refresh();
        }
    }
}
