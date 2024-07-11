namespace Hesap_Makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hesaplabel = new System.Windows.Forms.Label();
            this.btnrakam1 = new System.Windows.Forms.Button();
            this.btnrakam2 = new System.Windows.Forms.Button();
            this.btnrakam3 = new System.Windows.Forms.Button();
            this.btnrakam4 = new System.Windows.Forms.Button();
            this.btnrakam5 = new System.Windows.Forms.Button();
            this.btnrakam6 = new System.Windows.Forms.Button();
            this.btnrakam7 = new System.Windows.Forms.Button();
            this.btnrakam8 = new System.Windows.Forms.Button();
            this.btnrakam9 = new System.Windows.Forms.Button();
            this.btnrakam0 = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnesittir = new System.Windows.Forms.Button();
            this.btntopla = new System.Windows.Forms.Button();
            this.brncikar = new System.Windows.Forms.Button();
            this.btncarp = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hesaplabel
            // 
            this.hesaplabel.BackColor = System.Drawing.Color.Gainsboro;
            this.hesaplabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hesaplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplabel.Location = new System.Drawing.Point(27, 33);
            this.hesaplabel.Name = "hesaplabel";
            this.hesaplabel.Size = new System.Drawing.Size(380, 86);
            this.hesaplabel.TabIndex = 0;
            this.hesaplabel.Text = "0";
            this.hesaplabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnrakam1
            // 
            this.btnrakam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam1.Location = new System.Drawing.Point(30, 148);
            this.btnrakam1.Name = "btnrakam1";
            this.btnrakam1.Size = new System.Drawing.Size(75, 75);
            this.btnrakam1.TabIndex = 1;
            this.btnrakam1.Text = "1";
            this.btnrakam1.UseVisualStyleBackColor = true;
            this.btnrakam1.Click += new System.EventHandler(this.btnrakam1_Click);
            // 
            // btnrakam2
            // 
            this.btnrakam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam2.Location = new System.Drawing.Point(111, 148);
            this.btnrakam2.Name = "btnrakam2";
            this.btnrakam2.Size = new System.Drawing.Size(75, 75);
            this.btnrakam2.TabIndex = 2;
            this.btnrakam2.Text = "2";
            this.btnrakam2.UseVisualStyleBackColor = true;
            this.btnrakam2.Click += new System.EventHandler(this.btnrakam2_Click);
            // 
            // btnrakam3
            // 
            this.btnrakam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam3.Location = new System.Drawing.Point(192, 148);
            this.btnrakam3.Name = "btnrakam3";
            this.btnrakam3.Size = new System.Drawing.Size(75, 75);
            this.btnrakam3.TabIndex = 3;
            this.btnrakam3.Text = "3";
            this.btnrakam3.UseVisualStyleBackColor = true;
            this.btnrakam3.Click += new System.EventHandler(this.btnrakam3_Click);
            // 
            // btnrakam4
            // 
            this.btnrakam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam4.Location = new System.Drawing.Point(29, 229);
            this.btnrakam4.Name = "btnrakam4";
            this.btnrakam4.Size = new System.Drawing.Size(75, 75);
            this.btnrakam4.TabIndex = 4;
            this.btnrakam4.Text = "4";
            this.btnrakam4.UseVisualStyleBackColor = true;
            this.btnrakam4.Click += new System.EventHandler(this.btnrakam4_Click);
            // 
            // btnrakam5
            // 
            this.btnrakam5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam5.Location = new System.Drawing.Point(111, 229);
            this.btnrakam5.Name = "btnrakam5";
            this.btnrakam5.Size = new System.Drawing.Size(75, 75);
            this.btnrakam5.TabIndex = 5;
            this.btnrakam5.Text = "5";
            this.btnrakam5.UseVisualStyleBackColor = true;
            this.btnrakam5.Click += new System.EventHandler(this.btnrakam5_Click);
            // 
            // btnrakam6
            // 
            this.btnrakam6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam6.Location = new System.Drawing.Point(192, 229);
            this.btnrakam6.Name = "btnrakam6";
            this.btnrakam6.Size = new System.Drawing.Size(75, 75);
            this.btnrakam6.TabIndex = 6;
            this.btnrakam6.Text = "6";
            this.btnrakam6.UseVisualStyleBackColor = true;
            this.btnrakam6.Click += new System.EventHandler(this.btnrakam6_Click);
            // 
            // btnrakam7
            // 
            this.btnrakam7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam7.Location = new System.Drawing.Point(29, 310);
            this.btnrakam7.Name = "btnrakam7";
            this.btnrakam7.Size = new System.Drawing.Size(75, 75);
            this.btnrakam7.TabIndex = 7;
            this.btnrakam7.Text = "7";
            this.btnrakam7.UseVisualStyleBackColor = true;
            this.btnrakam7.Click += new System.EventHandler(this.btnrakam7_Click);
            // 
            // btnrakam8
            // 
            this.btnrakam8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam8.Location = new System.Drawing.Point(111, 310);
            this.btnrakam8.Name = "btnrakam8";
            this.btnrakam8.Size = new System.Drawing.Size(75, 75);
            this.btnrakam8.TabIndex = 8;
            this.btnrakam8.Text = "8";
            this.btnrakam8.UseVisualStyleBackColor = true;
            this.btnrakam8.Click += new System.EventHandler(this.btnrakam8_Click);
            // 
            // btnrakam9
            // 
            this.btnrakam9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam9.Location = new System.Drawing.Point(192, 310);
            this.btnrakam9.Name = "btnrakam9";
            this.btnrakam9.Size = new System.Drawing.Size(75, 75);
            this.btnrakam9.TabIndex = 9;
            this.btnrakam9.Text = "9";
            this.btnrakam9.UseVisualStyleBackColor = true;
            this.btnrakam9.Click += new System.EventHandler(this.btnrakam9_Click);
            // 
            // btnrakam0
            // 
            this.btnrakam0.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrakam0.Location = new System.Drawing.Point(111, 391);
            this.btnrakam0.Name = "btnrakam0";
            this.btnrakam0.Size = new System.Drawing.Size(75, 75);
            this.btnrakam0.TabIndex = 10;
            this.btnrakam0.Text = "0";
            this.btnrakam0.UseVisualStyleBackColor = true;
            this.btnrakam0.Click += new System.EventHandler(this.btnrakam0_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.Red;
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.ForeColor = System.Drawing.Color.White;
            this.btntemizle.Location = new System.Drawing.Point(29, 391);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 75);
            this.btntemizle.TabIndex = 11;
            this.btntemizle.Text = "C";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnesittir
            // 
            this.btnesittir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnesittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnesittir.Location = new System.Drawing.Point(192, 391);
            this.btnesittir.Name = "btnesittir";
            this.btnesittir.Size = new System.Drawing.Size(75, 75);
            this.btnesittir.TabIndex = 12;
            this.btnesittir.Text = "=";
            this.btnesittir.UseVisualStyleBackColor = false;
            this.btnesittir.Click += new System.EventHandler(this.btnesittir_Click);
            // 
            // btntopla
            // 
            this.btntopla.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btntopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntopla.Location = new System.Drawing.Point(319, 148);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(75, 75);
            this.btntopla.TabIndex = 13;
            this.btntopla.Text = "+";
            this.btntopla.UseVisualStyleBackColor = false;
            this.btntopla.Click += new System.EventHandler(this.btntopla_Click);
            // 
            // brncikar
            // 
            this.brncikar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.brncikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brncikar.Location = new System.Drawing.Point(319, 229);
            this.brncikar.Name = "brncikar";
            this.brncikar.Size = new System.Drawing.Size(75, 75);
            this.brncikar.TabIndex = 14;
            this.brncikar.Text = "-";
            this.brncikar.UseVisualStyleBackColor = false;
            this.brncikar.Click += new System.EventHandler(this.brncikar_Click);
            // 
            // btncarp
            // 
            this.btncarp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btncarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncarp.Location = new System.Drawing.Point(319, 310);
            this.btncarp.Name = "btncarp";
            this.btncarp.Size = new System.Drawing.Size(75, 75);
            this.btncarp.TabIndex = 15;
            this.btncarp.Text = "x";
            this.btncarp.UseVisualStyleBackColor = false;
            this.btncarp.Click += new System.EventHandler(this.btncarp_Click);
            // 
            // btnbol
            // 
            this.btnbol.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbol.Location = new System.Drawing.Point(319, 391);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(75, 75);
            this.btnbol.TabIndex = 16;
            this.btnbol.Text = "/";
            this.btnbol.UseVisualStyleBackColor = false;
            this.btnbol.Click += new System.EventHandler(this.btnbol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(419, 504);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btncarp);
            this.Controls.Add(this.brncikar);
            this.Controls.Add(this.btntopla);
            this.Controls.Add(this.btnesittir);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnrakam0);
            this.Controls.Add(this.btnrakam9);
            this.Controls.Add(this.btnrakam8);
            this.Controls.Add(this.btnrakam7);
            this.Controls.Add(this.btnrakam6);
            this.Controls.Add(this.btnrakam5);
            this.Controls.Add(this.btnrakam4);
            this.Controls.Add(this.btnrakam3);
            this.Controls.Add(this.btnrakam2);
            this.Controls.Add(this.btnrakam1);
            this.Controls.Add(this.hesaplabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hesaplabel;
        private System.Windows.Forms.Button btnrakam1;
        private System.Windows.Forms.Button btnrakam2;
        private System.Windows.Forms.Button btnrakam3;
        private System.Windows.Forms.Button btnrakam4;
        private System.Windows.Forms.Button btnrakam5;
        private System.Windows.Forms.Button btnrakam6;
        private System.Windows.Forms.Button btnrakam7;
        private System.Windows.Forms.Button btnrakam8;
        private System.Windows.Forms.Button btnrakam9;
        private System.Windows.Forms.Button btnrakam0;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnesittir;
        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.Button brncikar;
        private System.Windows.Forms.Button btncarp;
        private System.Windows.Forms.Button btnbol;
    }
}

