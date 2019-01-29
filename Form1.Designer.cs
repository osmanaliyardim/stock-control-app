namespace PetrolOfisi_Stok
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKur95 = new System.Windows.Forms.Label();
            this.lblKur97 = new System.Windows.Forms.Label();
            this.lblEuroDiz = new System.Windows.Forms.Label();
            this.lblYeniPro = new System.Windows.Forms.Label();
            this.lblGaz = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKursunsuz95Fiyat = new System.Windows.Forms.TextBox();
            this.txtKursunsuz97Fiyat = new System.Windows.Forms.TextBox();
            this.txtEuroDizelFiyat = new System.Windows.Forms.TextBox();
            this.txtYeniProFiyat = new System.Windows.Forms.TextBox();
            this.txtGazFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.lblKursunsuz95Lit = new System.Windows.Forms.Label();
            this.lblKursunsuz97Lit = new System.Windows.Forms.Label();
            this.lblEuroDizelLit = new System.Windows.Forms.Label();
            this.lblYeniProLit = new System.Windows.Forms.Label();
            this.lblGazLit = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblYeniProLit2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGaz);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblYeniPro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblKur95);
            this.groupBox1.Controls.Add(this.lblEuroDiz);
            this.groupBox1.Controls.Add(this.lblKur97);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyat Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurşunsuz 95:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kurşunsuz 97:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "YeniProDizel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "EuroDizel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gaz:";
            // 
            // lblKur95
            // 
            this.lblKur95.AutoSize = true;
            this.lblKur95.Location = new System.Drawing.Point(129, 73);
            this.lblKur95.Name = "lblKur95";
            this.lblKur95.Size = new System.Drawing.Size(58, 27);
            this.lblKur95.TabIndex = 5;
            this.lblKur95.Text = "0,00";
            // 
            // lblKur97
            // 
            this.lblKur97.AutoSize = true;
            this.lblKur97.Location = new System.Drawing.Point(129, 112);
            this.lblKur97.Name = "lblKur97";
            this.lblKur97.Size = new System.Drawing.Size(58, 27);
            this.lblKur97.TabIndex = 6;
            this.lblKur97.Text = "0,00";
            // 
            // lblEuroDiz
            // 
            this.lblEuroDiz.AutoSize = true;
            this.lblEuroDiz.Location = new System.Drawing.Point(129, 152);
            this.lblEuroDiz.Name = "lblEuroDiz";
            this.lblEuroDiz.Size = new System.Drawing.Size(58, 27);
            this.lblEuroDiz.TabIndex = 7;
            this.lblEuroDiz.Text = "0,00";
            // 
            // lblYeniPro
            // 
            this.lblYeniPro.AutoSize = true;
            this.lblYeniPro.Location = new System.Drawing.Point(129, 196);
            this.lblYeniPro.Name = "lblYeniPro";
            this.lblYeniPro.Size = new System.Drawing.Size(58, 27);
            this.lblYeniPro.TabIndex = 8;
            this.lblYeniPro.Text = "0,00";
            // 
            // lblGaz
            // 
            this.lblGaz.AutoSize = true;
            this.lblGaz.Location = new System.Drawing.Point(129, 240);
            this.lblGaz.Name = "lblGaz";
            this.lblGaz.Size = new System.Drawing.Size(58, 27);
            this.lblGaz.TabIndex = 9;
            this.lblGaz.Text = "0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblYeniProLit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtGazFiyat);
            this.groupBox2.Controls.Add(this.txtYeniProFiyat);
            this.groupBox2.Controls.Add(this.txtEuroDizelFiyat);
            this.groupBox2.Controls.Add(this.txtKursunsuz97Fiyat);
            this.groupBox2.Controls.Add(this.txtKursunsuz95Fiyat);
            this.groupBox2.Location = new System.Drawing.Point(289, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyatlandırma";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblYeniProLit2);
            this.groupBox3.Controls.Add(this.lblGazLit);
            this.groupBox3.Controls.Add(this.lblEuroDizelLit);
            this.groupBox3.Controls.Add(this.lblKursunsuz97Lit);
            this.groupBox3.Controls.Add(this.lblKursunsuz95Lit);
            this.groupBox3.Controls.Add(this.progressBar5);
            this.groupBox3.Controls.Add(this.progressBar4);
            this.groupBox3.Controls.Add(this.progressBar3);
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(625, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 318);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depo Bilgisi";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 65);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(222, 35);
            this.progressBar1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Satın Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKursunsuz95Fiyat
            // 
            this.txtKursunsuz95Fiyat.Location = new System.Drawing.Point(168, 70);
            this.txtKursunsuz95Fiyat.Name = "txtKursunsuz95Fiyat";
            this.txtKursunsuz95Fiyat.Size = new System.Drawing.Size(139, 35);
            this.txtKursunsuz95Fiyat.TabIndex = 5;
            // 
            // txtKursunsuz97Fiyat
            // 
            this.txtKursunsuz97Fiyat.Location = new System.Drawing.Point(168, 111);
            this.txtKursunsuz97Fiyat.Name = "txtKursunsuz97Fiyat";
            this.txtKursunsuz97Fiyat.Size = new System.Drawing.Size(139, 35);
            this.txtKursunsuz97Fiyat.TabIndex = 7;
            // 
            // txtEuroDizelFiyat
            // 
            this.txtEuroDizelFiyat.Location = new System.Drawing.Point(168, 152);
            this.txtEuroDizelFiyat.Name = "txtEuroDizelFiyat";
            this.txtEuroDizelFiyat.Size = new System.Drawing.Size(139, 35);
            this.txtEuroDizelFiyat.TabIndex = 9;
            // 
            // txtYeniProFiyat
            // 
            this.txtYeniProFiyat.Location = new System.Drawing.Point(168, 193);
            this.txtYeniProFiyat.Name = "txtYeniProFiyat";
            this.txtYeniProFiyat.Size = new System.Drawing.Size(139, 35);
            this.txtYeniProFiyat.TabIndex = 11;
            // 
            // txtGazFiyat
            // 
            this.txtGazFiyat.Location = new System.Drawing.Point(168, 232);
            this.txtGazFiyat.Name = "txtGazFiyat";
            this.txtGazFiyat.Size = new System.Drawing.Size(139, 35);
            this.txtGazFiyat.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Litre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tutar";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(19, 107);
            this.progressBar2.Maximum = 10000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(222, 35);
            this.progressBar2.TabIndex = 4;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(19, 150);
            this.progressBar3.Maximum = 10000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(222, 35);
            this.progressBar3.TabIndex = 5;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(19, 191);
            this.progressBar4.Maximum = 10000;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(222, 35);
            this.progressBar4.TabIndex = 6;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(19, 230);
            this.progressBar5.Maximum = 10000;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(222, 35);
            this.progressBar5.TabIndex = 7;
            // 
            // lblKursunsuz95Lit
            // 
            this.lblKursunsuz95Lit.AutoSize = true;
            this.lblKursunsuz95Lit.Location = new System.Drawing.Point(247, 73);
            this.lblKursunsuz95Lit.Name = "lblKursunsuz95Lit";
            this.lblKursunsuz95Lit.Size = new System.Drawing.Size(58, 27);
            this.lblKursunsuz95Lit.TabIndex = 10;
            this.lblKursunsuz95Lit.Text = "0,00";
            // 
            // lblKursunsuz97Lit
            // 
            this.lblKursunsuz97Lit.AutoSize = true;
            this.lblKursunsuz97Lit.Location = new System.Drawing.Point(247, 118);
            this.lblKursunsuz97Lit.Name = "lblKursunsuz97Lit";
            this.lblKursunsuz97Lit.Size = new System.Drawing.Size(58, 27);
            this.lblKursunsuz97Lit.TabIndex = 11;
            this.lblKursunsuz97Lit.Text = "0,00";
            // 
            // lblEuroDizelLit
            // 
            this.lblEuroDizelLit.AutoSize = true;
            this.lblEuroDizelLit.Location = new System.Drawing.Point(247, 158);
            this.lblEuroDizelLit.Name = "lblEuroDizelLit";
            this.lblEuroDizelLit.Size = new System.Drawing.Size(58, 27);
            this.lblEuroDizelLit.TabIndex = 12;
            this.lblEuroDizelLit.Text = "0,00";
            // 
            // lblYeniProLit
            // 
            this.lblYeniProLit.AutoSize = true;
            this.lblYeniProLit.Location = new System.Drawing.Point(583, 201);
            this.lblYeniProLit.Name = "lblYeniProLit";
            this.lblYeniProLit.Size = new System.Drawing.Size(58, 27);
            this.lblYeniProLit.TabIndex = 13;
            this.lblYeniProLit.Text = "0,00";
            // 
            // lblGazLit
            // 
            this.lblGazLit.AutoSize = true;
            this.lblGazLit.Location = new System.Drawing.Point(247, 238);
            this.lblGazLit.Name = "lblGazLit";
            this.lblGazLit.Size = new System.Drawing.Size(58, 27);
            this.lblGazLit.TabIndex = 14;
            this.lblGazLit.Text = "0,00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPlaka);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lblKasa);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(13, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(936, 66);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kasa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(562, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 27);
            this.label14.TabIndex = 0;
            this.label14.Text = "Miktar:";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Location = new System.Drawing.Point(651, 31);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(58, 27);
            this.lblKasa.TabIndex = 15;
            this.lblKasa.Text = "0,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(715, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 27);
            this.label13.TabIndex = 16;
            this.label13.Text = "TL";
            // 
            // lblYeniProLit2
            // 
            this.lblYeniProLit2.AutoSize = true;
            this.lblYeniProLit2.Location = new System.Drawing.Point(247, 199);
            this.lblYeniProLit2.Name = "lblYeniProLit2";
            this.lblYeniProLit2.Size = new System.Drawing.Size(58, 27);
            this.lblYeniProLit2.TabIndex = 15;
            this.lblYeniProLit2.Text = "0,00";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(143, 35);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(19, 112);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(143, 35);
            this.numericUpDown2.TabIndex = 17;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(19, 193);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(143, 35);
            this.numericUpDown3.TabIndex = 19;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(19, 153);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(143, 35);
            this.numericUpDown4.TabIndex = 18;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(19, 232);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(143, 35);
            this.numericUpDown5.TabIndex = 20;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Plaka:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(214, 23);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(224, 35);
            this.txtPlaka.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(977, 424);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "PetrolOfisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGaz;
        private System.Windows.Forms.Label lblYeniPro;
        private System.Windows.Forms.Label lblEuroDiz;
        private System.Windows.Forms.Label lblKur97;
        private System.Windows.Forms.Label lblKur95;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGazFiyat;
        private System.Windows.Forms.TextBox txtYeniProFiyat;
        private System.Windows.Forms.TextBox txtEuroDizelFiyat;
        private System.Windows.Forms.TextBox txtKursunsuz97Fiyat;
        private System.Windows.Forms.TextBox txtKursunsuz95Fiyat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGazLit;
        private System.Windows.Forms.Label lblYeniProLit;
        private System.Windows.Forms.Label lblEuroDizelLit;
        private System.Windows.Forms.Label lblKursunsuz97Lit;
        private System.Windows.Forms.Label lblKursunsuz95Lit;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblYeniProLit2;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label8;
    }
}

