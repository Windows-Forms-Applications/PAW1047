namespace sem6_paw
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbEUR = new System.Windows.Forms.TextBox();
            this.tbUSD = new System.Windows.Forms.TextBox();
            this.tbGBP = new System.Windows.Forms.TextBox();
            this.tbXAU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(207, 49);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 20);
            this.tbData.TabIndex = 0;
            // 
            // tbEUR
            // 
            this.tbEUR.Location = new System.Drawing.Point(207, 108);
            this.tbEUR.Name = "tbEUR";
            this.tbEUR.Size = new System.Drawing.Size(100, 20);
            this.tbEUR.TabIndex = 1;
            // 
            // tbUSD
            // 
            this.tbUSD.Location = new System.Drawing.Point(207, 171);
            this.tbUSD.Name = "tbUSD";
            this.tbUSD.Size = new System.Drawing.Size(100, 20);
            this.tbUSD.TabIndex = 2;
            // 
            // tbGBP
            // 
            this.tbGBP.Location = new System.Drawing.Point(207, 242);
            this.tbGBP.Name = "tbGBP";
            this.tbGBP.Size = new System.Drawing.Size(100, 20);
            this.tbGBP.TabIndex = 3;
            // 
            // tbXAU
            // 
            this.tbXAU.Location = new System.Drawing.Point(207, 316);
            this.tbXAU.Name = "tbXAU";
            this.tbXAU.Size = new System.Drawing.Size(100, 20);
            this.tbXAU.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "GBP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "XAU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Parsare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Generare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbXAU);
            this.Controls.Add(this.tbGBP);
            this.Controls.Add(this.tbUSD);
            this.Controls.Add(this.tbEUR);
            this.Controls.Add(this.tbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbEUR;
        private System.Windows.Forms.TextBox tbUSD;
        private System.Windows.Forms.TextBox tbGBP;
        private System.Windows.Forms.TextBox tbXAU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

