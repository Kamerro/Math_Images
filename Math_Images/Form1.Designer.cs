namespace Math_Images
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_smooth = new System.Windows.Forms.Button();
            this.btn_cross = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 266);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btn_smooth
            // 
            this.btn_smooth.Location = new System.Drawing.Point(329, 13);
            this.btn_smooth.Name = "btn_smooth";
            this.btn_smooth.Size = new System.Drawing.Size(191, 37);
            this.btn_smooth.TabIndex = 1;
            this.btn_smooth.Text = "smooth circle";
            this.btn_smooth.UseVisualStyleBackColor = true;
            this.btn_smooth.Click += new System.EventHandler(this.btn_smooth_Click);
            // 
            // btn_cross
            // 
            this.btn_cross.Location = new System.Drawing.Point(329, 56);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(191, 37);
            this.btn_cross.TabIndex = 2;
            this.btn_cross.Text = "cross";
            this.btn_cross.UseVisualStyleBackColor = true;
            this.btn_cross.Click += new System.EventHandler(this.btn_cross_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(328, 99);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(191, 37);
            this.btn_circle.TabIndex = 3;
            this.btn_circle.Text = "circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 291);
            this.Controls.Add(this.btn_circle);
            this.Controls.Add(this.btn_cross);
            this.Controls.Add(this.btn_smooth);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_smooth;
        private System.Windows.Forms.Button btn_cross;
        private System.Windows.Forms.Button btn_circle;
    }
}

