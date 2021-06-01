namespace ArabaOtomasyonu
{
    partial class arabaekle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arabaekle));
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.yakitcombo = new System.Windows.Forms.ComboBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.musteriDataSet1 = new ArabaOtomasyonu.musteriDataSet();
            this.durumcombo = new System.Windows.Forms.ComboBox();
            this.Durumu = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(138, 67);
            this.txtplaka.Multiline = true;
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(250, 26);
            this.txtplaka.TabIndex = 12;
            this.txtplaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtplaka_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(90, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(79, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Renk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(42, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model(Yıl)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(76, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(82, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fiyat";
            // 
            // markacombo
            // 
            this.markacombo.DropDownHeight = 157;
            this.markacombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markacombo.FormattingEnabled = true;
            this.markacombo.IntegralHeight = false;
            this.markacombo.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fort",
            "Fiat"});
            this.markacombo.Location = new System.Drawing.Point(138, 107);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(250, 26);
            this.markacombo.TabIndex = 18;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sericombo
            // 
            this.sericombo.DropDownHeight = 157;
            this.sericombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sericombo.FormattingEnabled = true;
            this.sericombo.IntegralHeight = false;
            this.sericombo.Location = new System.Drawing.Point(138, 149);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(250, 26);
            this.sericombo.TabIndex = 19;
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(138, 273);
            this.txtkm.Multiline = true;
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(250, 26);
            this.txtkm.TabIndex = 20;
            this.txtkm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkm_KeyPress);
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(138, 230);
            this.txtrenk.Multiline = true;
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(250, 26);
            this.txtrenk.TabIndex = 21;
            this.txtrenk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrenk_KeyPress);
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(138, 190);
            this.txtmodel.Multiline = true;
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(250, 26);
            this.txtmodel.TabIndex = 22;
            this.txtmodel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmodel_KeyPress);
            // 
            // yakitcombo
            // 
            this.yakitcombo.DropDownHeight = 157;
            this.yakitcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yakitcombo.FormattingEnabled = true;
            this.yakitcombo.IntegralHeight = false;
            this.yakitcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.yakitcombo.Location = new System.Drawing.Point(138, 314);
            this.yakitcombo.Name = "yakitcombo";
            this.yakitcombo.Size = new System.Drawing.Size(250, 26);
            this.yakitcombo.TabIndex = 23;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(138, 355);
            this.txtfiyat.Multiline = true;
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(250, 26);
            this.txtfiyat.TabIndex = 24;
            this.txtfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiyat_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(71, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(85, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(78, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Yakıt";
            // 
            // Ekle
            // 
            this.Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ekle.ImageIndex = 1;
            this.Ekle.ImageList = this.ımageList1;
            this.Ekle.Location = new System.Drawing.Point(85, 452);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(144, 43);
            this.Ekle.TabIndex = 28;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "iconfinder_file_delete_48762 (1).png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(247, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 43);
            this.button2.TabIndex = 29;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "photo.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(476, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 43);
            this.button3.TabIndex = 30;
            this.button3.Text = "Resim Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox1.Location = new System.Drawing.Point(476, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // musteriDataSet1
            // 
            this.musteriDataSet1.DataSetName = "musteriDataSet";
            this.musteriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // durumcombo
            // 
            this.durumcombo.DropDownHeight = 157;
            this.durumcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumcombo.FormattingEnabled = true;
            this.durumcombo.IntegralHeight = false;
            this.durumcombo.Items.AddRange(new object[] {
            "Dolu",
            "Boş"});
            this.durumcombo.Location = new System.Drawing.Point(138, 399);
            this.durumcombo.Name = "durumcombo";
            this.durumcombo.Size = new System.Drawing.Size(250, 26);
            this.durumcombo.TabIndex = 33;
            // 
            // Durumu
            // 
            this.Durumu.AutoSize = true;
            this.Durumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Durumu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Durumu.Location = new System.Drawing.Point(59, 399);
            this.Durumu.Name = "Durumu";
            this.Durumu.Size = new System.Drawing.Size(67, 18);
            this.Durumu.TabIndex = 34;
            this.Durumu.Text = "Durumu";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(138, 24);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(250, 26);
            this.txtid.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(59, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Arac_İd";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "photo.png");
            this.ımageList1.Images.SetKeyName(1, "add-to-cart.png");
            this.ımageList1.Images.SetKeyName(2, "iconfinder_file_delete_48762 (1).png");
            // 
            // arabaekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(977, 573);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Durumu);
            this.Controls.Add(this.durumcombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.yakitcombo);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.sericombo);
            this.Controls.Add(this.markacombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "arabaekle";
            this.Text = "Araba Kayıt Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.ComboBox yakitcombo;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private musteriDataSet musteriDataSet1;
        private System.Windows.Forms.ComboBox durumcombo;
        private System.Windows.Forms.Label Durumu;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList ımageList1;
    }
}