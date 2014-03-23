using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kitware.VTK;                          // warto pamiętać

// labo 2: przeźroczystość + kolor stożka

namespace Git2
{
    public partial class Form1 : Form
    {
        private vtkActor coneActor;         // o tym też warto pamiętać
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateCone_Click(object sender, EventArgs e)
        {
            vtkConeSource coneSource = vtkConeSource.New();
            vtkPolyDataMapper coneMapper = vtkPolyDataMapper.New();
            coneMapper.SetInputConnection(coneSource.GetOutputPort());

            this.coneActor = vtkActor.New();
            this.coneActor.SetMapper(coneMapper);

            vtkRenderWindow renWin = this.renderWindowControl1.RenderWindow;
            vtkRenderer renderer = renWin.GetRenderers().GetFirstRenderer();
            renderer.AddActor(coneActor);

            this.renderWindowControl1.Refresh(); 
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (this.coneActor == null)                                 // zabezpieczenie: jeżeli jest brak stożka to przycisk nie działa
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

        private void trackBarOpacity_Scroll(object sender, EventArgs e)
        {
            if (this.coneActor == null)
                return;

            double opacity = this.trackBarOpacity.Value / 100.0;
            this.coneActor.GetProperty().SetOpacity(opacity);

            this.renderWindowControl1.Refresh();
        }
    }
}
