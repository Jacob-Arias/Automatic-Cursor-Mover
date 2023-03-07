namespace Automatic_Cursor_Mover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setupBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automatic Cursor Mover";
            // 
            // StartBTN
            // 
            this.StartBTN.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBTN.Location = new System.Drawing.Point(261, 205);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(115, 75);
            this.StartBTN.TabIndex = 1;
            this.StartBTN.Text = "Start ";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Press q to force quit program (program must be visible on \r\nscreen for  this to w" +
    "ork so don\'t click of this program)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 8;
            // 
            // setupBTN
            // 
            this.setupBTN.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupBTN.Location = new System.Drawing.Point(149, 90);
            this.setupBTN.Name = "setupBTN";
            this.setupBTN.Size = new System.Drawing.Size(348, 93);
            this.setupBTN.TabIndex = 9;
            this.setupBTN.Text = "Setup ";
            this.setupBTN.UseVisualStyleBackColor = true;
            this.setupBTN.Click += new System.EventHandler(this.setupBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(592, 66);
            this.label3.TabIndex = 10;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setupBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setupBTN;
        private System.Windows.Forms.Label label3;
    }
}

