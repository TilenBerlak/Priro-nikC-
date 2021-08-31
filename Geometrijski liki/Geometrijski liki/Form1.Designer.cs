namespace Geometrijski_liki
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
            this.radioButton_pravokotnik = new System.Windows.Forms.RadioButton();
            this.radioButton_krog = new System.Windows.Forms.RadioButton();
            this.radioButton_enakostranicni = new System.Windows.Forms.RadioButton();
            this.radioButton_enakokraki = new System.Windows.Forms.RadioButton();
            this.groupBox_izbranLik = new System.Windows.Forms.GroupBox();
            this.radioButton_kvadrat = new System.Windows.Forms.RadioButton();
            this.radioButton_trikotnik = new System.Windows.Forms.RadioButton();
            this.groupBox_lastnosti = new System.Windows.Forms.GroupBox();
            this.comboBox_visina = new System.Windows.Forms.ComboBox();
            this.label_polmer = new System.Windows.Forms.Label();
            this.numericUpDown_polmer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_visina = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_stranicaC = new System.Windows.Forms.NumericUpDown();
            this.label_stranicaC = new System.Windows.Forms.Label();
            this.numericUpDown_stranicaB = new System.Windows.Forms.NumericUpDown();
            this.label_stranicaB = new System.Windows.Forms.Label();
            this.label_stranicaA = new System.Windows.Forms.Label();
            this.numericUpDown_stranicaA = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_slika = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_ploscina = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_obseg = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_izbranLik.SuspendLayout();
            this.groupBox_lastnosti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_polmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_visina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stranicaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stranicaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stranicaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_slika)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ploscina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obseg)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_pravokotnik
            // 
            this.radioButton_pravokotnik.AutoSize = true;
            this.radioButton_pravokotnik.Location = new System.Drawing.Point(6, 19);
            this.radioButton_pravokotnik.Name = "radioButton_pravokotnik";
            this.radioButton_pravokotnik.Size = new System.Drawing.Size(82, 17);
            this.radioButton_pravokotnik.TabIndex = 1;
            this.radioButton_pravokotnik.TabStop = true;
            this.radioButton_pravokotnik.Text = "Pravokotnik";
            this.radioButton_pravokotnik.UseVisualStyleBackColor = true;
            this.radioButton_pravokotnik.CheckedChanged += new System.EventHandler(this.radioButton_pravokotnik_CheckedChanged);
            // 
            // radioButton_krog
            // 
            this.radioButton_krog.AutoSize = true;
            this.radioButton_krog.Location = new System.Drawing.Point(279, 51);
            this.radioButton_krog.Name = "radioButton_krog";
            this.radioButton_krog.Size = new System.Drawing.Size(47, 17);
            this.radioButton_krog.TabIndex = 2;
            this.radioButton_krog.TabStop = true;
            this.radioButton_krog.Text = "Krog";
            this.radioButton_krog.UseVisualStyleBackColor = true;
            this.radioButton_krog.CheckedChanged += new System.EventHandler(this.radioButton_krog_CheckedChanged);
            // 
            // radioButton_enakostranicni
            // 
            this.radioButton_enakostranicni.AutoSize = true;
            this.radioButton_enakostranicni.Location = new System.Drawing.Point(116, 51);
            this.radioButton_enakostranicni.Name = "radioButton_enakostranicni";
            this.radioButton_enakostranicni.Size = new System.Drawing.Size(135, 17);
            this.radioButton_enakostranicni.TabIndex = 4;
            this.radioButton_enakostranicni.TabStop = true;
            this.radioButton_enakostranicni.Text = "Enakostranični trikotnik";
            this.radioButton_enakostranicni.UseVisualStyleBackColor = true;
            this.radioButton_enakostranicni.CheckedChanged += new System.EventHandler(this.radioButton_enakostranicni_CheckedChanged);
            // 
            // radioButton_enakokraki
            // 
            this.radioButton_enakokraki.AutoSize = true;
            this.radioButton_enakokraki.Location = new System.Drawing.Point(279, 19);
            this.radioButton_enakokraki.Name = "radioButton_enakokraki";
            this.radioButton_enakokraki.Size = new System.Drawing.Size(119, 17);
            this.radioButton_enakokraki.TabIndex = 5;
            this.radioButton_enakokraki.TabStop = true;
            this.radioButton_enakokraki.Text = "Enakokraki trikotnik";
            this.radioButton_enakokraki.UseVisualStyleBackColor = true;
            this.radioButton_enakokraki.CheckedChanged += new System.EventHandler(this.radioButton_enakokraki_CheckedChanged);
            // 
            // groupBox_izbranLik
            // 
            this.groupBox_izbranLik.Controls.Add(this.radioButton_kvadrat);
            this.groupBox_izbranLik.Controls.Add(this.radioButton_trikotnik);
            this.groupBox_izbranLik.Controls.Add(this.radioButton_pravokotnik);
            this.groupBox_izbranLik.Controls.Add(this.radioButton_krog);
            this.groupBox_izbranLik.Controls.Add(this.radioButton_enakokraki);
            this.groupBox_izbranLik.Controls.Add(this.radioButton_enakostranicni);
            this.groupBox_izbranLik.Location = new System.Drawing.Point(12, 12);
            this.groupBox_izbranLik.Name = "groupBox_izbranLik";
            this.groupBox_izbranLik.Size = new System.Drawing.Size(415, 83);
            this.groupBox_izbranLik.TabIndex = 9;
            this.groupBox_izbranLik.TabStop = false;
            this.groupBox_izbranLik.Text = "Geometrijski liki";
            // 
            // radioButton_kvadrat
            // 
            this.radioButton_kvadrat.AutoSize = true;
            this.radioButton_kvadrat.Location = new System.Drawing.Point(116, 19);
            this.radioButton_kvadrat.Name = "radioButton_kvadrat";
            this.radioButton_kvadrat.Size = new System.Drawing.Size(62, 17);
            this.radioButton_kvadrat.TabIndex = 7;
            this.radioButton_kvadrat.TabStop = true;
            this.radioButton_kvadrat.Text = "Kvadrat";
            this.radioButton_kvadrat.UseVisualStyleBackColor = true;
            this.radioButton_kvadrat.CheckedChanged += new System.EventHandler(this.radioButton_kvadrat_CheckedChanged);
            // 
            // radioButton_trikotnik
            // 
            this.radioButton_trikotnik.AutoSize = true;
            this.radioButton_trikotnik.Location = new System.Drawing.Point(6, 51);
            this.radioButton_trikotnik.Name = "radioButton_trikotnik";
            this.radioButton_trikotnik.Size = new System.Drawing.Size(66, 17);
            this.radioButton_trikotnik.TabIndex = 6;
            this.radioButton_trikotnik.TabStop = true;
            this.radioButton_trikotnik.Text = "Trikotnik";
            this.radioButton_trikotnik.UseVisualStyleBackColor = true;
            this.radioButton_trikotnik.CheckedChanged += new System.EventHandler(this.radioButton_trikotnik_CheckedChanged);
            // 
            // groupBox_lastnosti
            // 
            this.groupBox_lastnosti.Controls.Add(this.comboBox_visina);
            this.groupBox_lastnosti.Controls.Add(this.label_polmer);
            this.groupBox_lastnosti.Controls.Add(this.numericUpDown_polmer);
            this.groupBox_lastnosti.Controls.Add(this.numericUpDown_visina);
            this.groupBox_lastnosti.Controls.Add(this.numericUpDown_stranicaC);
            this.groupBox_lastnosti.Controls.Add(this.label_stranicaC);
            this.groupBox_lastnosti.Controls.Add(this.numericUpDown_stranicaB);
            this.groupBox_lastnosti.Controls.Add(this.label_stranicaB);
            this.groupBox_lastnosti.Controls.Add(this.label_stranicaA);
            this.groupBox_lastnosti.Controls.Add(this.numericUpDown_stranicaA);
            this.groupBox_lastnosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_lastnosti.Location = new System.Drawing.Point(12, 110);
            this.groupBox_lastnosti.Name = "groupBox_lastnosti";
            this.groupBox_lastnosti.Size = new System.Drawing.Size(182, 183);
            this.groupBox_lastnosti.TabIndex = 10;
            this.groupBox_lastnosti.TabStop = false;
            this.groupBox_lastnosti.Text = "Lasnosti lika";
            // 
            // comboBox_visina
            // 
            this.comboBox_visina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_visina.FormattingEnabled = true;
            this.comboBox_visina.Items.AddRange(new object[] {
            "Višina (va):",
            "Višina (vb):",
            "Višina (vc):"});
            this.comboBox_visina.Location = new System.Drawing.Point(10, 115);
            this.comboBox_visina.MaxDropDownItems = 3;
            this.comboBox_visina.Name = "comboBox_visina";
            this.comboBox_visina.Size = new System.Drawing.Size(80, 21);
            this.comboBox_visina.TabIndex = 16;
            // 
            // label_polmer
            // 
            this.label_polmer.AutoSize = true;
            this.label_polmer.Enabled = false;
            this.label_polmer.Location = new System.Drawing.Point(6, 149);
            this.label_polmer.Name = "label_polmer";
            this.label_polmer.Size = new System.Drawing.Size(84, 13);
            this.label_polmer.TabIndex = 15;
            this.label_polmer.Text = "Polmer kroga (r):";
            // 
            // numericUpDown_polmer
            // 
            this.numericUpDown_polmer.DecimalPlaces = 2;
            this.numericUpDown_polmer.Enabled = false;
            this.numericUpDown_polmer.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_polmer.Location = new System.Drawing.Point(112, 147);
            this.numericUpDown_polmer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_polmer.Name = "numericUpDown_polmer";
            this.numericUpDown_polmer.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_polmer.TabIndex = 14;
            // 
            // numericUpDown_visina
            // 
            this.numericUpDown_visina.DecimalPlaces = 2;
            this.numericUpDown_visina.Enabled = false;
            this.numericUpDown_visina.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_visina.Location = new System.Drawing.Point(112, 115);
            this.numericUpDown_visina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_visina.Name = "numericUpDown_visina";
            this.numericUpDown_visina.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_visina.TabIndex = 13;
            // 
            // numericUpDown_stranicaC
            // 
            this.numericUpDown_stranicaC.DecimalPlaces = 2;
            this.numericUpDown_stranicaC.Enabled = false;
            this.numericUpDown_stranicaC.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_stranicaC.Location = new System.Drawing.Point(112, 82);
            this.numericUpDown_stranicaC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_stranicaC.Name = "numericUpDown_stranicaC";
            this.numericUpDown_stranicaC.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_stranicaC.TabIndex = 5;
            // 
            // label_stranicaC
            // 
            this.label_stranicaC.AutoSize = true;
            this.label_stranicaC.Enabled = false;
            this.label_stranicaC.Location = new System.Drawing.Point(6, 84);
            this.label_stranicaC.Name = "label_stranicaC";
            this.label_stranicaC.Size = new System.Drawing.Size(100, 13);
            this.label_stranicaC.TabIndex = 4;
            this.label_stranicaC.Text = "Dolžina stranice (c):";
            // 
            // numericUpDown_stranicaB
            // 
            this.numericUpDown_stranicaB.DecimalPlaces = 2;
            this.numericUpDown_stranicaB.Enabled = false;
            this.numericUpDown_stranicaB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_stranicaB.Location = new System.Drawing.Point(112, 51);
            this.numericUpDown_stranicaB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_stranicaB.Name = "numericUpDown_stranicaB";
            this.numericUpDown_stranicaB.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_stranicaB.TabIndex = 3;
            // 
            // label_stranicaB
            // 
            this.label_stranicaB.AutoSize = true;
            this.label_stranicaB.Enabled = false;
            this.label_stranicaB.Location = new System.Drawing.Point(6, 53);
            this.label_stranicaB.Name = "label_stranicaB";
            this.label_stranicaB.Size = new System.Drawing.Size(100, 13);
            this.label_stranicaB.TabIndex = 2;
            this.label_stranicaB.Text = "Dolžina stranice (b):";
            // 
            // label_stranicaA
            // 
            this.label_stranicaA.AutoSize = true;
            this.label_stranicaA.Enabled = false;
            this.label_stranicaA.Location = new System.Drawing.Point(7, 21);
            this.label_stranicaA.Name = "label_stranicaA";
            this.label_stranicaA.Size = new System.Drawing.Size(100, 13);
            this.label_stranicaA.TabIndex = 1;
            this.label_stranicaA.Text = "Dolžina stranice (a):";
            // 
            // numericUpDown_stranicaA
            // 
            this.numericUpDown_stranicaA.DecimalPlaces = 2;
            this.numericUpDown_stranicaA.Enabled = false;
            this.numericUpDown_stranicaA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_stranicaA.Location = new System.Drawing.Point(113, 19);
            this.numericUpDown_stranicaA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_stranicaA.Name = "numericUpDown_stranicaA";
            this.numericUpDown_stranicaA.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_stranicaA.TabIndex = 0;
            // 
            // pictureBox_slika
            // 
            this.pictureBox_slika.Location = new System.Drawing.Point(445, 12);
            this.pictureBox_slika.Name = "pictureBox_slika";
            this.pictureBox_slika.Size = new System.Drawing.Size(205, 205);
            this.pictureBox_slika.TabIndex = 11;
            this.pictureBox_slika.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_ploscina);
            this.groupBox1.Controls.Add(this.numericUpDown_obseg);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(213, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultati";
            // 
            // numericUpDown_ploscina
            // 
            this.numericUpDown_ploscina.DecimalPlaces = 2;
            this.numericUpDown_ploscina.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ploscina.Location = new System.Drawing.Point(79, 70);
            this.numericUpDown_ploscina.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_ploscina.Name = "numericUpDown_ploscina";
            this.numericUpDown_ploscina.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ploscina.TabIndex = 5;
            // 
            // numericUpDown_obseg
            // 
            this.numericUpDown_obseg.DecimalPlaces = 2;
            this.numericUpDown_obseg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_obseg.Location = new System.Drawing.Point(79, 33);
            this.numericUpDown_obseg.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_obseg.Name = "numericUpDown_obseg";
            this.numericUpDown_obseg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_obseg.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ploščina (p):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Obseg (o):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "IZRAČUNAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 54);
            this.button2.TabIndex = 14;
            this.button2.Text = "IZBRIŠI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_slika);
            this.Controls.Add(this.groupBox_lastnosti);
            this.Controls.Add(this.groupBox_izbranLik);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(678, 345);
            this.MinimumSize = new System.Drawing.Size(678, 345);
            this.Name = "Form1";
            this.Text = "Geometrijski liki";
            this.groupBox_izbranLik.ResumeLayout(false);
            this.groupBox_izbranLik.PerformLayout();
            this.groupBox_lastnosti.ResumeLayout(false);
            this.groupBox_lastnosti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_polmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_visina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stranicaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stranicaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stranicaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_slika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ploscina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton_pravokotnik;
        private System.Windows.Forms.RadioButton radioButton_krog;
        private System.Windows.Forms.RadioButton radioButton_enakostranicni;
        private System.Windows.Forms.RadioButton radioButton_enakokraki;
        private System.Windows.Forms.GroupBox groupBox_izbranLik;
        private System.Windows.Forms.GroupBox groupBox_lastnosti;
        private System.Windows.Forms.NumericUpDown numericUpDown_stranicaC;
        private System.Windows.Forms.Label label_stranicaC;
        private System.Windows.Forms.NumericUpDown numericUpDown_stranicaB;
        private System.Windows.Forms.Label label_stranicaB;
        private System.Windows.Forms.Label label_stranicaA;
        private System.Windows.Forms.NumericUpDown numericUpDown_stranicaA;
        private System.Windows.Forms.Label label_polmer;
        private System.Windows.Forms.NumericUpDown numericUpDown_polmer;
        private System.Windows.Forms.NumericUpDown numericUpDown_visina;
        private System.Windows.Forms.PictureBox pictureBox_slika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown_ploscina;
        private System.Windows.Forms.NumericUpDown numericUpDown_obseg;
        private System.Windows.Forms.ComboBox comboBox_visina;
        private System.Windows.Forms.RadioButton radioButton_kvadrat;
        private System.Windows.Forms.RadioButton radioButton_trikotnik;
    }
}

