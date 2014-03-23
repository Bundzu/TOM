using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kitware.VTK;                  // NIE ZAPOMINAĆ O TYM I O REFERENCJACH (preferences w solution explorer)

// 1 labo: tworzenie stożka i obracanie go

namespace Git1
{
    public partial class Form1 : Form
    {
        private vtkActor coneActor;     // warto to wpisać aby aktor był widoczny w innych funkcjach
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateCone_Click(object sender, EventArgs e)     // tworzymy stożek
        {
            vtkConeSource coneSource = vtkConeSource.New();
            coneSource.SetResolution(100);                                  // rozdzielczość
            vtkPolyDataMapper coneMapper = vtkPolyDataMapper.New();
            coneMapper.SetInputConnection(coneSource.GetOutputPort());

            this.coneActor = vtkActor.New();
            this.coneActor.SetMapper(coneMapper);

            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renWin.GetRenderers().GetFirstRenderer();
            renderer.AddActor(coneActor); 

            this.renderWindowControl1.Refresh();                            // odświeżamy
        }

        private void buttonRotate_Click(object sender, EventArgs e)         // obracamy stożek
        {
            this.coneActor.RotateY(45.0);
            this.renderWindowControl1.Refresh();
        }
    }
}
