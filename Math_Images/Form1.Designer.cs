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
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_size = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 346);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btn_smooth
            // 
            this.btn_smooth.Location = new System.Drawing.Point(431, 12);
            this.btn_smooth.Name = "btn_smooth";
            this.btn_smooth.Size = new System.Drawing.Size(191, 37);
            this.btn_smooth.TabIndex = 1;
            this.btn_smooth.Text = "smooth circle";
            this.btn_smooth.UseVisualStyleBackColor = true;
            this.btn_smooth.Click += new System.EventHandler(this.btn_smooth_Click);
            // 
            // btn_cross
            // 
            this.btn_cross.Location = new System.Drawing.Point(431, 55);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(191, 37);
            this.btn_cross.TabIndex = 2;
            this.btn_cross.Text = "cross";
            this.btn_cross.UseVisualStyleBackColor = true;
            this.btn_cross.Click += new System.EventHandler(this.btn_cross_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(430, 98);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(191, 37);
            this.btn_circle.TabIndex = 3;
            this.btn_circle.Text = "circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.Location = new System.Drawing.Point(430, 186);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(191, 37);
            this.btn_rectangle.TabIndex = 4;
            this.btn_rectangle.Text = "rectangle";
            this.btn_rectangle.UseVisualStyleBackColor = true;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Iteractive with no math";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 365);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(411, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(167, 424);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(74, 16);
            this.lbl_size.TabIndex = 7;
            this.lbl_size.Text = "size of pen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rectangle);
            this.Controls.Add(this.btn_circle);
            this.Controls.Add(this.btn_cross);
            this.Controls.Add(this.btn_smooth);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_smooth;
        private System.Windows.Forms.Button btn_cross;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

