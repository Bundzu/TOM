using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kitware.VTK;

// Labo 3: Filtry: shrink, cieniowanie Phonga, transformacje

namespace Git3
{
    public partial class Form1 : Form
    {
        private vtkActor coneActor;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateCone_Click(object sender, EventArgs e)
        {
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

        private void buttonShrink_Click(object sender, EventArgs e)
        {
            if (this.coneActor == null)
                return;

            vtkShrinkPolyData shrinkFilter = vtkShrinkPolyData.New();
            shrinkFilter.SetInputConnection(this.coneActor.GetMapper().GetInputConnection(0, 0));
            this.coneActor.GetMapper().SetInputConnection(shrinkFilter.GetOutputPort());

            this.renderWindowControl1.Refresh();
        }

        private void buttonPhong_Click(object sender, EventArgs e)
        {
            if (this.coneActor == null)
                return;

            vtkPolyDataNormals phongFilter = vtkPolyDataNormals.New();
            phongFilter.SetInputConnection(this.coneActor.GetMapper().GetInputConnection(0, 0));
            this.coneActor.GetMapper().SetInputConnection(phongFilter.GetOutputPort());

            this.renderWindowControl1.Refresh();
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            if (this.coneActor == null)
                return;

            vtkTransform transform = vtkTransform.New();
            transform.Scale(0.5, 1.0, 0.5);

            // this.coneActor.SetUserTransform(transform);                                  // 1 sposób

            vtkTransformPolyDataFilter transformFilter = vtkTransformPolyDataFilter.New();  // 2 sposób z użyciem filtra

            transformFilter.SetTransform(transform);
            vtkShrinkPolyData shrinkFilter = vtkShrinkPolyData.New();
            transformFilter.SetInputConnection(this.coneActor.GetMapper().GetInputConnection(0, 0));
            this.coneActor.GetMapper().SetInputConnection(transformFilter.GetOutputPort());

            this.renderWindowControl1.Refresh();
        }
    }
}
