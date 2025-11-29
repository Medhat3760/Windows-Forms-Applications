namespace MyFirstWinFormsProject
{
    partial class frmMain
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
            this.btnShowForm1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMessageBoxForm = new System.Windows.Forms.Button();
            this.btnCheckBoxForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowForm1
            // 
            this.btnShowForm1.Location = new System.Drawing.Point(50, 43);
            this.btnShowForm1.Name = "btnShowForm1";
            this.btnShowForm1.Size = new System.Drawing.Size(211, 82);
            this.btnShowForm1.TabIndex = 0;
            this.btnShowForm1.Text = "Show Form 1";
            this.btnShowForm1.UseVisualStyleBackColor = true;
            this.btnShowForm1.Click += new System.EventHandler(this.btnShowForm1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Form1 as Dialog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMessageBoxForm
            // 
            this.btnMessageBoxForm.Location = new System.Drawing.Point(344, 43);
            this.btnMessageBoxForm.Name = "btnMessageBoxForm";
            this.btnMessageBoxForm.Size = new System.Drawing.Size(211, 82);
            this.btnMessageBoxForm.TabIndex = 2;
            this.btnMessageBoxForm.Text = "Show Message Box Form";
            this.btnMessageBoxForm.UseVisualStyleBackColor = true;
            this.btnMessageBoxForm.Click += new System.EventHandler(this.btnMessageBoxForm_Click);
            // 
            // btnCheckBoxForm
            // 
            this.btnCheckBoxForm.Location = new System.Drawing.Point(344, 164);
            this.btnCheckBoxForm.Name = "btnCheckBoxForm";
            this.btnCheckBoxForm.Size = new System.Drawing.Size(211, 82);
            this.btnCheckBoxForm.TabIndex = 3;
            this.btnCheckBoxForm.Text = "Check Box/Radio/Group";
            this.btnCheckBoxForm.UseVisualStyleBackColor = true;
            this.btnCheckBoxForm.Click += new System.EventHandler(this.btnCheckBoxForm_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckBoxForm);
            this.Controls.Add(this.btnMessageBoxForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowForm1);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMessageBoxForm;
        private System.Windows.Forms.Button btnCheckBoxForm;
    }
}