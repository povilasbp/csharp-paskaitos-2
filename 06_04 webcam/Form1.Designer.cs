namespace _06_04_webcam
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bStart = new System.Windows.Forms.Button();
            this.cameracombo = new System.Windows.Forms.ComboBox();
            this.checkFiltras = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 510);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(601, 66);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(182, 40);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // cameracombo
            // 
            this.cameracombo.FormattingEnabled = true;
            this.cameracombo.Location = new System.Drawing.Point(601, 129);
            this.cameracombo.Name = "cameracombo";
            this.cameracombo.Size = new System.Drawing.Size(182, 24);
            this.cameracombo.TabIndex = 2;
            // 
            // checkFiltras
            // 
            this.checkFiltras.AutoSize = true;
            this.checkFiltras.Location = new System.Drawing.Point(617, 178);
            this.checkFiltras.Name = "checkFiltras";
            this.checkFiltras.Size = new System.Drawing.Size(109, 21);
            this.checkFiltras.TabIndex = 3;
            this.checkFiltras.Text = "Invertavimas";
            this.checkFiltras.UseVisualStyleBackColor = true;
            this.checkFiltras.CheckedChanged += new System.EventHandler(this.checkFiltras_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 534);
            this.Controls.Add(this.checkFiltras);
            this.Controls.Add(this.cameracombo);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.ComboBox cameracombo;
        private System.Windows.Forms.CheckBox checkFiltras;
    }
}

