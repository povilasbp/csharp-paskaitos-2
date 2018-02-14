namespace _04_03_gui_exception
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
            this.comboPeople = new System.Windows.Forms.ComboBox();
            this.bUpadate = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPayroll = new System.Windows.Forms.TextBox();
            this.textWorkYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboPeople
            // 
            this.comboPeople.FormattingEnabled = true;
            this.comboPeople.Location = new System.Drawing.Point(37, 61);
            this.comboPeople.Name = "comboPeople";
            this.comboPeople.Size = new System.Drawing.Size(173, 24);
            this.comboPeople.TabIndex = 0;
            this.comboPeople.SelectedIndexChanged += new System.EventHandler(this.Update);
            // 
            // bUpadate
            // 
            this.bUpadate.Location = new System.Drawing.Point(262, 55);
            this.bUpadate.Name = "bUpadate";
            this.bUpadate.Size = new System.Drawing.Size(89, 35);
            this.bUpadate.TabIndex = 1;
            this.bUpadate.Text = "Update";
            this.bUpadate.UseVisualStyleBackColor = true;
            this.bUpadate.Click += new System.EventHandler(this.bUpadate_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(85, 164);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 2;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(85, 211);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(100, 22);
            this.textSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(85, 258);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 22);
            this.textYear.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Birth year";
            // 
            // textPayroll
            // 
            this.textPayroll.Location = new System.Drawing.Point(85, 301);
            this.textPayroll.Name = "textPayroll";
            this.textPayroll.Size = new System.Drawing.Size(100, 22);
            this.textPayroll.TabIndex = 8;
            // 
            // textWorkYear
            // 
            this.textWorkYear.Location = new System.Drawing.Point(85, 343);
            this.textWorkYear.Name = "textWorkYear";
            this.textWorkYear.Size = new System.Drawing.Size(100, 22);
            this.textWorkYear.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "payroll";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "seniority";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textWorkYear);
            this.Controls.Add(this.textPayroll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.bUpadate);
            this.Controls.Add(this.comboPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPeople;
        private System.Windows.Forms.Button bUpadate;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPayroll;
        private System.Windows.Forms.TextBox textWorkYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

