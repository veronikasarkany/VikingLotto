
namespace VikingSzimulacio
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
            this.btnSorsol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSorsol
            // 
            this.btnSorsol.Location = new System.Drawing.Point(529, 76);
            this.btnSorsol.Name = "btnSorsol";
            this.btnSorsol.Size = new System.Drawing.Size(94, 29);
            this.btnSorsol.TabIndex = 0;
            this.btnSorsol.Text = "Sorsolás";
            this.btnSorsol.UseVisualStyleBackColor = true;
            this.btnSorsol.Click += new System.EventHandler(this.btnSorsol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(529, 137);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(94, 29);
            this.btnBezar.TabIndex = 1;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnSorsol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSorsol;
        private System.Windows.Forms.Button btnBezar;
    }
}

