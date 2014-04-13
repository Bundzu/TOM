namespace Git7
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
            this.buttonCone = new System.Windows.Forms.Button();
            this.buttonTrackball = new System.Windows.Forms.Button();
            this.buttonJoystick = new System.Windows.Forms.Button();
            this.buttonAnime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // renderWindowControl1
            // 
            this.renderWindowControl1.AddTestActors = false;
            this.renderWindowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.renderWindowControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.renderWindowControl1.Location = new System.Drawing.Point(12, 12);
            this.renderWindowControl1.Name = "renderWindowControl1";
            this.renderWindowControl1.Size = new System.Drawing.Size(554, 468);
            this.renderWindowControl1.TabIndex = 0;
            this.renderWindowControl1.TestText = null;
            // 
            // buttonCone
            // 
            this.buttonCone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCone.Location = new System.Drawing.Point(12, 486);
            this.buttonCone.Name = "buttonCone";
            this.buttonCone.Size = new System.Drawing.Size(75, 23);
            this.buttonCone.TabIndex = 1;
            this.buttonCone.Text = "Create cone";
            this.buttonCone.UseVisualStyleBackColor = true;
            this.buttonCone.Click += new System.EventHandler(this.buttonCone_Click);
            // 
            // buttonTrackball
            // 
            this.buttonTrackball.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTrackball.Location = new System.Drawing.Point(94, 486);
            this.buttonTrackball.Name = "buttonTrackball";
            this.buttonTrackball.Size = new System.Drawing.Size(75, 23);
            this.buttonTrackball.TabIndex = 2;
            this.buttonTrackball.Text = "Trackball";
            this.buttonTrackball.UseVisualStyleBackColor = true;
            this.buttonTrackball.Click += new System.EventHandler(this.buttonTrackball_Click);
            // 
            // buttonJoystick
            // 
            this.buttonJoystick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonJoystick.Location = new System.Drawing.Point(176, 486);
            this.buttonJoystick.Name = "buttonJoystick";
            this.buttonJoystick.Size = new System.Drawing.Size(75, 23);
            this.buttonJoystick.TabIndex = 3;
            this.buttonJoystick.Text = "Joystick";
            this.buttonJoystick.UseVisualStyleBackColor = true;
            this.buttonJoystick.Click += new System.EventHandler(this.buttonJoystick_Click);
            // 
            // buttonAnime
            // 
            this.buttonAnime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAnime.Location = new System.Drawing.Point(258, 486);
            this.buttonAnime.Name = "buttonAnime";
            this.buttonAnime.Size = new System.Drawing.Size(75, 23);
            this.buttonAnime.TabIndex = 4;
            this.buttonAnime.Text = "Anime";
            this.buttonAnime.UseVisualStyleBackColor = true;
            this.buttonAnime.Click += new System.EventHandler(this.buttonAnime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 521);
            this.Controls.Add(this.buttonAnime);
            this.Controls.Add(this.buttonJoystick);
            this.Controls.Add(this.buttonTrackball);
            this.Controls.Add(this.buttonCone);
            this.Controls.Add(this.renderWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Kitware.VTK.RenderWindowControl renderWindowControl1;
        private System.Windows.Forms.Button buttonCone;
        private System.Windows.Forms.Button buttonTrackball;
        private System.Windows.Forms.Button buttonJoystick;
        private System.Windows.Forms.Button buttonAnime;
    }
}

