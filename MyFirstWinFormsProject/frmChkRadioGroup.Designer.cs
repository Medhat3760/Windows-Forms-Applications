namespace MyFirstWinFormsProject
{
    partial class frmChkRadioGroup
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
            this.chkRecieveEmail = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbCrust.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRecieveEmail
            // 
            this.chkRecieveEmail.AutoSize = true;
            this.chkRecieveEmail.Location = new System.Drawing.Point(67, 79);
            this.chkRecieveEmail.Name = "chkRecieveEmail";
            this.chkRecieveEmail.Size = new System.Drawing.Size(132, 23);
            this.chkRecieveEmail.TabIndex = 0;
            this.chkRecieveEmail.Text = "Recieve Email";
            this.chkRecieveEmail.UseVisualStyleBackColor = true;
            this.chkRecieveEmail.CheckedChanged += new System.EventHandler(this.chkRecieveEmail_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(41, 60);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(73, 23);
            this.rbSmall.TabIndex = 2;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(41, 111);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(90, 23);
            this.rbMedium.TabIndex = 3;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(41, 158);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(65, 23);
            this.rbLarg.TabIndex = 4;
            this.rbLarg.TabStop = true;
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(28, 53);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(66, 23);
            this.rbThin.TabIndex = 6;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(28, 110);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(72, 23);
            this.rbThick.TabIndex = 7;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Location = new System.Drawing.Point(715, 69);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(223, 165);
            this.gbCrust.TabIndex = 8;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.button2);
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Location = new System.Drawing.Point(351, 32);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(269, 289);
            this.gbSize.TabIndex = 9;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Pizza Size";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 77);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmChkRadioGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 542);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkRecieveEmail);
            this.Name = "frmChkRadioGroup";
            this.Text = "frmChkRadioGroup";
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRecieveEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Button button3;
    }
}