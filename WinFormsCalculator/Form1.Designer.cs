
namespace WinFormsCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Entrytxt = new System.Windows.Forms.TextBox();
            this.Onebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CEbtn = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.Squarebtn = new System.Windows.Forms.Button();
            this.Dividebtn = new System.Windows.Forms.Button();
            this.Multiplybtn = new System.Windows.Forms.Button();
            this.Subtractbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Equalbtn = new System.Windows.Forms.Button();
            this.Decimalbtn = new System.Windows.Forms.Button();
            this.SignChangebtn = new System.Windows.Forms.Button();
            this.Ninebtn = new System.Windows.Forms.Button();
            this.Eightbtn = new System.Windows.Forms.Button();
            this.Sevenbtn = new System.Windows.Forms.Button();
            this.Sixbtn = new System.Windows.Forms.Button();
            this.Fivebtn = new System.Windows.Forms.Button();
            this.Fourbtn = new System.Windows.Forms.Button();
            this.Threebtn = new System.Windows.Forms.Button();
            this.Zerobtn = new System.Windows.Forms.Button();
            this.Twobtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entrytxt
            // 
            this.Entrytxt.Font = new System.Drawing.Font("Segoe UI", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Entrytxt.Location = new System.Drawing.Point(2, 0);
            this.Entrytxt.Name = "Entrytxt";
            this.Entrytxt.Size = new System.Drawing.Size(393, 105);
            this.Entrytxt.TabIndex = 1;
            this.Entrytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Entrytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Entrytxt_KeyPress);
            // 
            // Onebtn
            // 
            this.Onebtn.Location = new System.Drawing.Point(2, 312);
            this.Onebtn.Name = "Onebtn";
            this.Onebtn.Size = new System.Drawing.Size(89, 61);
            this.Onebtn.TabIndex = 2;
            this.Onebtn.Text = "1";
            this.Onebtn.UseVisualStyleBackColor = true;
            this.Onebtn.Click += new System.EventHandler(this.Onebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CEbtn);
            this.panel1.Controls.Add(this.Cbtn);
            this.panel1.Controls.Add(this.Squarebtn);
            this.panel1.Controls.Add(this.Dividebtn);
            this.panel1.Controls.Add(this.Multiplybtn);
            this.panel1.Controls.Add(this.Subtractbtn);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.Equalbtn);
            this.panel1.Controls.Add(this.Decimalbtn);
            this.panel1.Controls.Add(this.SignChangebtn);
            this.panel1.Controls.Add(this.Ninebtn);
            this.panel1.Controls.Add(this.Eightbtn);
            this.panel1.Controls.Add(this.Sevenbtn);
            this.panel1.Controls.Add(this.Sixbtn);
            this.panel1.Controls.Add(this.Fivebtn);
            this.panel1.Controls.Add(this.Fourbtn);
            this.panel1.Controls.Add(this.Threebtn);
            this.panel1.Controls.Add(this.Zerobtn);
            this.panel1.Controls.Add(this.Twobtn);
            this.panel1.Controls.Add(this.Entrytxt);
            this.panel1.Controls.Add(this.Onebtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 443);
            this.panel1.TabIndex = 3;
            // 
            // CEbtn
            // 
            this.CEbtn.Location = new System.Drawing.Point(2, 111);
            this.CEbtn.Name = "CEbtn";
            this.CEbtn.Size = new System.Drawing.Size(89, 61);
            this.CEbtn.TabIndex = 22;
            this.CEbtn.Text = "CE";
            this.CEbtn.UseVisualStyleBackColor = true;
            this.CEbtn.Click += new System.EventHandler(this.CEbtn_Click);
            // 
            // Cbtn
            // 
            this.Cbtn.Location = new System.Drawing.Point(97, 111);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(89, 61);
            this.Cbtn.TabIndex = 21;
            this.Cbtn.Text = "C";
            this.Cbtn.UseVisualStyleBackColor = true;
            this.Cbtn.Click += new System.EventHandler(this.Cbtn_Click);
            // 
            // Squarebtn
            // 
            this.Squarebtn.Location = new System.Drawing.Point(192, 111);
            this.Squarebtn.Name = "Squarebtn";
            this.Squarebtn.Size = new System.Drawing.Size(89, 61);
            this.Squarebtn.TabIndex = 20;
            this.Squarebtn.Text = "x²";
            this.Squarebtn.UseVisualStyleBackColor = true;
            this.Squarebtn.Click += new System.EventHandler(this.Squarebtn_Click);
            // 
            // Dividebtn
            // 
            this.Dividebtn.Location = new System.Drawing.Point(287, 111);
            this.Dividebtn.Name = "Dividebtn";
            this.Dividebtn.Size = new System.Drawing.Size(108, 61);
            this.Dividebtn.TabIndex = 19;
            this.Dividebtn.Text = "/";
            this.Dividebtn.UseVisualStyleBackColor = true;
            this.Dividebtn.Click += new System.EventHandler(this.Dividebtn_Click);
            // 
            // Multiplybtn
            // 
            this.Multiplybtn.Location = new System.Drawing.Point(287, 178);
            this.Multiplybtn.Name = "Multiplybtn";
            this.Multiplybtn.Size = new System.Drawing.Size(108, 61);
            this.Multiplybtn.TabIndex = 18;
            this.Multiplybtn.Text = "x";
            this.Multiplybtn.UseVisualStyleBackColor = true;
            this.Multiplybtn.Click += new System.EventHandler(this.Multiplybtn_Click);
            // 
            // Subtractbtn
            // 
            this.Subtractbtn.Location = new System.Drawing.Point(287, 245);
            this.Subtractbtn.Name = "Subtractbtn";
            this.Subtractbtn.Size = new System.Drawing.Size(108, 61);
            this.Subtractbtn.TabIndex = 17;
            this.Subtractbtn.Text = "-";
            this.Subtractbtn.UseVisualStyleBackColor = true;
            this.Subtractbtn.Click += new System.EventHandler(this.Subtractbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(287, 312);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(108, 61);
            this.Addbtn.TabIndex = 16;
            this.Addbtn.Text = "+";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Equalbtn
            // 
            this.Equalbtn.Location = new System.Drawing.Point(287, 379);
            this.Equalbtn.Name = "Equalbtn";
            this.Equalbtn.Size = new System.Drawing.Size(108, 61);
            this.Equalbtn.TabIndex = 15;
            this.Equalbtn.Text = "=";
            this.Equalbtn.UseVisualStyleBackColor = true;
            this.Equalbtn.Click += new System.EventHandler(this.Equalbtn_Click);
            // 
            // Decimalbtn
            // 
            this.Decimalbtn.Location = new System.Drawing.Point(192, 379);
            this.Decimalbtn.Name = "Decimalbtn";
            this.Decimalbtn.Size = new System.Drawing.Size(89, 61);
            this.Decimalbtn.TabIndex = 14;
            this.Decimalbtn.Text = ".";
            this.Decimalbtn.UseVisualStyleBackColor = true;
            this.Decimalbtn.Click += new System.EventHandler(this.Decimalbtn_Click);
            // 
            // SignChangebtn
            // 
            this.SignChangebtn.Location = new System.Drawing.Point(2, 379);
            this.SignChangebtn.Name = "SignChangebtn";
            this.SignChangebtn.Size = new System.Drawing.Size(89, 61);
            this.SignChangebtn.TabIndex = 13;
            this.SignChangebtn.Text = "+/-";
            this.SignChangebtn.UseVisualStyleBackColor = true;
            this.SignChangebtn.Click += new System.EventHandler(this.SignChangebtn_Click);
            // 
            // Ninebtn
            // 
            this.Ninebtn.Location = new System.Drawing.Point(192, 178);
            this.Ninebtn.Name = "Ninebtn";
            this.Ninebtn.Size = new System.Drawing.Size(89, 61);
            this.Ninebtn.TabIndex = 12;
            this.Ninebtn.Text = "9";
            this.Ninebtn.UseVisualStyleBackColor = true;
            this.Ninebtn.Click += new System.EventHandler(this.Ninebtn_Click);
            // 
            // Eightbtn
            // 
            this.Eightbtn.Location = new System.Drawing.Point(97, 178);
            this.Eightbtn.Name = "Eightbtn";
            this.Eightbtn.Size = new System.Drawing.Size(89, 61);
            this.Eightbtn.TabIndex = 11;
            this.Eightbtn.Text = "8";
            this.Eightbtn.UseVisualStyleBackColor = true;
            this.Eightbtn.Click += new System.EventHandler(this.Eightbtn_Click);
            // 
            // Sevenbtn
            // 
            this.Sevenbtn.Location = new System.Drawing.Point(2, 178);
            this.Sevenbtn.Name = "Sevenbtn";
            this.Sevenbtn.Size = new System.Drawing.Size(89, 61);
            this.Sevenbtn.TabIndex = 10;
            this.Sevenbtn.Text = "7";
            this.Sevenbtn.UseVisualStyleBackColor = true;
            this.Sevenbtn.Click += new System.EventHandler(this.Sevenbtn_Click);
            // 
            // Sixbtn
            // 
            this.Sixbtn.Location = new System.Drawing.Point(192, 245);
            this.Sixbtn.Name = "Sixbtn";
            this.Sixbtn.Size = new System.Drawing.Size(89, 61);
            this.Sixbtn.TabIndex = 9;
            this.Sixbtn.Text = "6";
            this.Sixbtn.UseVisualStyleBackColor = true;
            this.Sixbtn.Click += new System.EventHandler(this.Sixbtn_Click);
            // 
            // Fivebtn
            // 
            this.Fivebtn.Location = new System.Drawing.Point(97, 245);
            this.Fivebtn.Name = "Fivebtn";
            this.Fivebtn.Size = new System.Drawing.Size(89, 61);
            this.Fivebtn.TabIndex = 8;
            this.Fivebtn.Text = "5";
            this.Fivebtn.UseVisualStyleBackColor = true;
            this.Fivebtn.Click += new System.EventHandler(this.Fivebtn_Click);
            // 
            // Fourbtn
            // 
            this.Fourbtn.Location = new System.Drawing.Point(2, 245);
            this.Fourbtn.Name = "Fourbtn";
            this.Fourbtn.Size = new System.Drawing.Size(89, 61);
            this.Fourbtn.TabIndex = 7;
            this.Fourbtn.Text = "4";
            this.Fourbtn.UseVisualStyleBackColor = true;
            this.Fourbtn.Click += new System.EventHandler(this.Fourbtn_Click);
            // 
            // Threebtn
            // 
            this.Threebtn.Location = new System.Drawing.Point(192, 312);
            this.Threebtn.Name = "Threebtn";
            this.Threebtn.Size = new System.Drawing.Size(89, 61);
            this.Threebtn.TabIndex = 6;
            this.Threebtn.Text = "3";
            this.Threebtn.UseVisualStyleBackColor = true;
            this.Threebtn.Click += new System.EventHandler(this.Threebtn_Click);
            // 
            // Zerobtn
            // 
            this.Zerobtn.Location = new System.Drawing.Point(97, 379);
            this.Zerobtn.Name = "Zerobtn";
            this.Zerobtn.Size = new System.Drawing.Size(89, 61);
            this.Zerobtn.TabIndex = 5;
            this.Zerobtn.Text = "0";
            this.Zerobtn.UseVisualStyleBackColor = true;
            this.Zerobtn.Click += new System.EventHandler(this.Zerobtn_Click);
            // 
            // Twobtn
            // 
            this.Twobtn.Location = new System.Drawing.Point(97, 312);
            this.Twobtn.Name = "Twobtn";
            this.Twobtn.Size = new System.Drawing.Size(89, 61);
            this.Twobtn.TabIndex = 4;
            this.Twobtn.Text = "2";
            this.Twobtn.UseVisualStyleBackColor = true;
            this.Twobtn.Click += new System.EventHandler(this.Twobtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 451);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Entrytxt;
        private System.Windows.Forms.Button Onebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Fivebtn;
        private System.Windows.Forms.Button Fourbtn;
        private System.Windows.Forms.Button Threebtn;
        private System.Windows.Forms.Button Zerobtn;
        private System.Windows.Forms.Button Twobtn;
        private System.Windows.Forms.Button Ninebtn;
        private System.Windows.Forms.Button Eightbtn;
        private System.Windows.Forms.Button Sevenbtn;
        private System.Windows.Forms.Button Sixbtn;
        private System.Windows.Forms.Button CEbtn;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button Squarebtn;
        private System.Windows.Forms.Button Dividebtn;
        private System.Windows.Forms.Button Multiplybtn;
        private System.Windows.Forms.Button Subtractbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Equalbtn;
        private System.Windows.Forms.Button Decimalbtn;
        private System.Windows.Forms.Button SignChangebtn;
    }
}

