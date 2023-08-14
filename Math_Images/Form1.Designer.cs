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
            this.btnFilledRectangle = new System.Windows.Forms.Button();
            this.btn_SinWaves = new System.Windows.Forms.Button();
            this.btn_CosWaves = new System.Windows.Forms.Button();
            this.btn_Cos_Sin_Waves = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_rgbSineCosine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btn_smooth
            // 
            this.btn_smooth.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_smooth.Location = new System.Drawing.Point(455, 12);
            this.btn_smooth.Name = "btn_smooth";
            this.btn_smooth.Size = new System.Drawing.Size(191, 37);
            this.btn_smooth.TabIndex = 1;
            this.btn_smooth.Text = "Smooth circle";
            this.btn_smooth.UseVisualStyleBackColor = true;
            this.btn_smooth.Click += new System.EventHandler(this.btn_smooth_Click);
            // 
            // btn_cross
            // 
            this.btn_cross.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cross.Location = new System.Drawing.Point(455, 55);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(191, 37);
            this.btn_cross.TabIndex = 2;
            this.btn_cross.Text = "Cross";
            this.btn_cross.UseVisualStyleBackColor = true;
            this.btn_cross.Click += new System.EventHandler(this.btn_cross_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_circle.Location = new System.Drawing.Point(454, 98);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(191, 37);
            this.btn_circle.TabIndex = 3;
            this.btn_circle.Text = "Circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rectangle.Location = new System.Drawing.Point(454, 187);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(191, 37);
            this.btn_rectangle.TabIndex = 4;
            this.btn_rectangle.Text = "Rectangle";
            this.btn_rectangle.UseVisualStyleBackColor = true;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 280);
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
            this.lbl_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_size.Location = new System.Drawing.Point(112, 405);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(124, 25);
            this.lbl_size.TabIndex = 7;
            this.lbl_size.Text = "size of pen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(400, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "50";
            // 
            // btnFilledRectangle
            // 
            this.btnFilledRectangle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilledRectangle.Location = new System.Drawing.Point(454, 230);
            this.btnFilledRectangle.Name = "btnFilledRectangle";
            this.btnFilledRectangle.Size = new System.Drawing.Size(191, 37);
            this.btnFilledRectangle.TabIndex = 10;
            this.btnFilledRectangle.Text = "Filled rectangle";
            this.btnFilledRectangle.UseVisualStyleBackColor = true;
            this.btnFilledRectangle.Click += new System.EventHandler(this.btnFilledRectangle_Click);
            // 
            // btn_SinWaves
            // 
            this.btn_SinWaves.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinWaves.Location = new System.Drawing.Point(730, 12);
            this.btn_SinWaves.Name = "btn_SinWaves";
            this.btn_SinWaves.Size = new System.Drawing.Size(115, 37);
            this.btn_SinWaves.TabIndex = 11;
            this.btn_SinWaves.Text = "Sin waves";
            this.btn_SinWaves.UseVisualStyleBackColor = true;
            this.btn_SinWaves.Click += new System.EventHandler(this.btn_SinWaves_Click);
            // 
            // btn_CosWaves
            // 
            this.btn_CosWaves.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CosWaves.Location = new System.Drawing.Point(730, 55);
            this.btn_CosWaves.Name = "btn_CosWaves";
            this.btn_CosWaves.Size = new System.Drawing.Size(115, 37);
            this.btn_CosWaves.TabIndex = 12;
            this.btn_CosWaves.Text = "Cos waves";
            this.btn_CosWaves.UseVisualStyleBackColor = true;
            this.btn_CosWaves.Click += new System.EventHandler(this.btn_CosWaves_Click);
            // 
            // btn_Cos_Sin_Waves
            // 
            this.btn_Cos_Sin_Waves.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cos_Sin_Waves.Location = new System.Drawing.Point(730, 98);
            this.btn_Cos_Sin_Waves.Name = "btn_Cos_Sin_Waves";
            this.btn_Cos_Sin_Waves.Size = new System.Drawing.Size(115, 37);
            this.btn_Cos_Sin_Waves.TabIndex = 13;
            this.btn_Cos_Sin_Waves.Text = "Sin+Cos Waves";
            this.btn_Cos_Sin_Waves.UseVisualStyleBackColor = true;
            this.btn_Cos_Sin_Waves.Click += new System.EventHandler(this.btn_Cos_Sin_Waves_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(679, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 492);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(431, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 20);
            this.panel2.TabIndex = 15;
            // 
            // btn_rgbSineCosine
            // 
            this.btn_rgbSineCosine.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rgbSineCosine.Location = new System.Drawing.Point(703, 167);
            this.btn_rgbSineCosine.Name = "btn_rgbSineCosine";
            this.btn_rgbSineCosine.Size = new System.Drawing.Size(160, 64);
            this.btn_rgbSineCosine.TabIndex = 16;
            this.btn_rgbSineCosine.Text = "R Sine G Cosine";
            this.btn_rgbSineCosine.UseVisualStyleBackColor = true;
            this.btn_rgbSineCosine.Click += new System.EventHandler(this.btn_rgbSineCosine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "*Different frequencies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "in colours";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(875, 481);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rgbSineCosine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cos_Sin_Waves);
            this.Controls.Add(this.btn_CosWaves);
            this.Controls.Add(this.btn_SinWaves);
            this.Controls.Add(this.btnFilledRectangle);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Math-Images";
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
        private System.Windows.Forms.Button btnFilledRectangle;
        private System.Windows.Forms.Button btn_SinWaves;
        private System.Windows.Forms.Button btn_CosWaves;
        private System.Windows.Forms.Button btn_Cos_Sin_Waves;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_rgbSineCosine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

