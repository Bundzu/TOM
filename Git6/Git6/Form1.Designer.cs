namespace Git6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.renderWindowControl1 = new Kitware.VTK.RenderWindowControl();
            this.buttonLoadStl = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSavevtk = new System.Windows.Forms.Button();
            this.buttonLoadvtk = new System.Windows.Forms.Button();
            this.buttonStlToVtk = new System.Windows.Forms.Button();
            this.buttonVtkToStl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // renderWindowControl1
            // 
            this.renderWindowControl1.AddTestActors = false;
            this.renderWindowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.renderWindowControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.renderWindowControl1.Location = new System.Drawing.Point(12, 12);
            this.renderWindowControl1.Name = "renderWindowControl1";
            this.renderWindowControl1.Size = new System.Drawing.Size(479, 486);
            this.renderWindowControl1.TabIndex = 0;
            this.renderWindowControl1.TestText = null;
            // 
            // buttonLoadStl
            // 
            this.buttonLoadStl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadStl.Location = new System.Drawing.Point(12, 503);
            this.buttonLoadStl.Name = "buttonLoadStl";
            this.buttonLoadStl.Size = new System.Drawing.Size(75, 39);
            this.buttonLoadStl.TabIndex = 1;
            this.buttonLoadStl.Text = "Load stl";
            this.buttonLoadStl.UseVisualStyleBackColor = true;
            this.buttonLoadStl.Click += new System.EventHandler(this.buttonLoadStl_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(93, 503);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 39);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save cone stl";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSavevtk
            // 
            this.buttonSavevtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSavevtk.Location = new System.Drawing.Point(174, 503);
            this.buttonSavevtk.Name = "buttonSavevtk";
            this.buttonSavevtk.Size = new System.Drawing.Size(75, 39);
            this.buttonSavevtk.TabIndex = 3;
            this.buttonSavevtk.Text = "Save cylinder vtk";
            this.buttonSavevtk.UseVisualStyleBackColor = true;
            this.buttonSavevtk.Click += new System.EventHandler(this.buttonSavevtk_Click);
            // 
            // buttonLoadvtk
            // 
            this.buttonLoadvtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadvtk.Location = new System.Drawing.Point(255, 503);
            this.buttonLoadvtk.Name = "buttonLoadvtk";
            this.buttonLoadvtk.Size = new System.Drawing.Size(75, 39);
            this.buttonLoadvtk.TabIndex = 4;
            this.buttonLoadvtk.Text = "Load vtk";
            this.buttonLoadvtk.UseVisualStyleBackColor = true;
            this.buttonLoadvtk.Click += new System.EventHandler(this.buttonLoadvtk_Click);
            // 
            // buttonStlToVtk
            // 
            this.buttonStlToVtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStlToVtk.Location = new System.Drawing.Point(336, 503);
            this.buttonStlToVtk.Name = "buttonStlToVtk";
            this.buttonStlToVtk.Size = new System.Drawing.Size(75, 39);
            this.buttonStlToVtk.TabIndex = 5;
            this.buttonStlToVtk.Text = "Convert Stl to Vtk";
            this.buttonStlToVtk.UseVisualStyleBackColor = true;
            this.buttonStlToVtk.Click += new System.EventHandler(this.buttonStlToVtk_Click);
            // 
            // buttonVtkToStl
            // 
            this.buttonVtkToStl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVtkToStl.Location = new System.Drawing.Point(417, 503);
            this.buttonVtkToStl.Name = "buttonVtkToStl";
            this.buttonVtkToStl.Size = new System.Drawing.Size(75, 39);
            this.buttonVtkToStl.TabIndex = 6;
            this.buttonVtkToStl.Text = "Convert Vtk to stl";
            this.buttonVtkToStl.UseVisualStyleBackColor = true;
            this.buttonVtkToStl.Click += new System.EventHandler(this.buttonVtkToStl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 551);
            this.Controls.Add(this.buttonVtkToStl);
            this.Controls.Add(this.buttonStlToVtk);
            this.Controls.Add(this.buttonLoadvtk);
            this.Controls.Add(this.buttonSavevtk);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoadStl);
            this.Controls.Add(this.renderWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Kitware.VTK.RenderWindowControl renderWindowControl1;
        private System.Windows.Forms.Button buttonLoadStl;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSavevtk;
        private System.Windows.Forms.Button buttonLoadvtk;
        private System.Windows.Forms.Button buttonStlToVtk;
        private System.Windows.Forms.Button buttonVtkToStl;
    }
}

