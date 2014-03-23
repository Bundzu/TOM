namespace Git3
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
            this.buttonCreateCone = new System.Windows.Forms.Button();
            this.buttonShrink = new System.Windows.Forms.Button();
            this.buttonPhong = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // renderWindowControl1
            // 
            this.renderWindowControl1.AddTestActors = false;
            this.renderWindowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.renderWindowControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.renderWindowControl1.Location = new System.Drawing.Point(13, 13);
            this.renderWindowControl1.Name = "renderWindowControl1";
            this.renderWindowControl1.Size = new System.Drawing.Size(436, 334);
            this.renderWindowControl1.TabIndex = 0;
            this.renderWindowControl1.TestText = null;
            // 
            // buttonCreateCone
            // 
            this.buttonCreateCone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateCone.Location = new System.Drawing.Point(12, 353);
            this.buttonCreateCone.Name = "buttonCreateCone";
            this.buttonCreateCone.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateCone.TabIndex = 1;
            this.buttonCreateCone.Text = "Cone";
            this.buttonCreateCone.UseVisualStyleBackColor = true;
            this.buttonCreateCone.Click += new System.EventHandler(this.buttonCreateCone_Click);
            // 
            // buttonShrink
            // 
            this.buttonShrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShrink.Location = new System.Drawing.Point(93, 353);
            this.buttonShrink.Name = "buttonShrink";
            this.buttonShrink.Size = new System.Drawing.Size(75, 23);
            this.buttonShrink.TabIndex = 2;
            this.buttonShrink.Text = "Shrink";
            this.buttonShrink.UseVisualStyleBackColor = true;
            this.buttonShrink.Click += new System.EventHandler(this.buttonShrink_Click);
            // 
            // buttonPhong
            // 
            this.buttonPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPhong.Location = new System.Drawing.Point(174, 353);
            this.buttonPhong.Name = "buttonPhong";
            this.buttonPhong.Size = new System.Drawing.Size(75, 23);
            this.buttonPhong.TabIndex = 3;
            this.buttonPhong.Text = "Phong";
            this.buttonPhong.UseVisualStyleBackColor = true;
            this.buttonPhong.Click += new System.EventHandler(this.buttonPhong_Click);
            // 
            // buttonTransform
            // 
            this.buttonTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTransform.Location = new System.Drawing.Point(255, 353);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(75, 23);
            this.buttonTransform.TabIndex = 4;
            this.buttonTransform.Text = "Trans";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 388);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.buttonPhong);
            this.Controls.Add(this.buttonShrink);
            this.Controls.Add(this.buttonCreateCone);
            this.Controls.Add(this.renderWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Kitware.VTK.RenderWindowControl renderWindowControl1;
        private System.Windows.Forms.Button buttonCreateCone;
        private System.Windows.Forms.Button buttonShrink;
        private System.Windows.Forms.Button buttonPhong;
        private System.Windows.Forms.Button buttonTransform;
    }
}

