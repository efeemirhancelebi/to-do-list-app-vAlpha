namespace to_do_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cboxOrnek = new ComboBox();
            pboxUser = new PictureBox();
            labelGiris = new Label();
            btnEkle = new Button();
            dateTimePicker1 = new DateTimePicker();
            radioGunduz = new RadioButton();
            radioGece = new RadioButton();
            gboxRadio = new GroupBox();
            cboxGunler = new ComboBox();
            lboxPlans = new ListBox();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            tboxEkle = new TextBox();
            label2 = new Label();
            btnKaydet = new Button();
            lboxAktiviteler = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pboxUser).BeginInit();
            gboxRadio.SuspendLayout();
            SuspendLayout();
            // 
            // cboxOrnek
            // 
            cboxOrnek.BackColor = Color.FromArgb(176, 166, 149);
            cboxOrnek.ForeColor = Color.FromArgb(243, 238, 234);
            cboxOrnek.FormattingEnabled = true;
            cboxOrnek.Items.AddRange(new object[] { "Kahvaltı yap.", "Duş al.", "Ders çalış.", "Spor yap.", "Kitap oku.", "Meditasyon yap.", "Film veya dizi izle.", "Arkadaşlarınla buluş.", "Alışverişe çık." });
            cboxOrnek.Location = new Point(12, 97);
            cboxOrnek.Name = "cboxOrnek";
            cboxOrnek.Size = new Size(250, 23);
            cboxOrnek.TabIndex = 0;
            cboxOrnek.Text = "Aktivite bulmakta zorlanıyor musun?";
            cboxOrnek.SelectedIndexChanged += cboxOrnek_SelectedIndexChanged;
            // 
            // pboxUser
            // 
            pboxUser.BackColor = Color.Transparent;
            pboxUser.Image = (Image)resources.GetObject("pboxUser.Image");
            pboxUser.Location = new Point(12, 417);
            pboxUser.Name = "pboxUser";
            pboxUser.Size = new Size(32, 32);
            pboxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pboxUser.TabIndex = 1;
            pboxUser.TabStop = false;
            pboxUser.Click += pboxUser_Click;
            // 
            // labelGiris
            // 
            labelGiris.AutoSize = true;
            labelGiris.ForeColor = Color.FromArgb(119, 107, 93);
            labelGiris.Location = new Point(50, 417);
            labelGiris.Name = "labelGiris";
            labelGiris.Size = new Size(123, 15);
            labelGiris.TabIndex = 2;
            labelGiris.Text = "Giriş yap veya kayıt ol!";
            labelGiris.Click += labelGiris_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(243, 238, 234);
            btnEkle.ForeColor = Color.FromArgb(119, 107, 93);
            btnEkle.Location = new Point(12, 352);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 46);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Aktiviteleri ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.WindowText;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(243, 238, 234);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(119, 107, 93);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(119, 107, 93);
            dateTimePicker1.Location = new Point(12, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // radioGunduz
            // 
            radioGunduz.AutoSize = true;
            radioGunduz.Location = new Point(6, 22);
            radioGunduz.Name = "radioGunduz";
            radioGunduz.Size = new Size(66, 19);
            radioGunduz.TabIndex = 8;
            radioGunduz.TabStop = true;
            radioGunduz.Text = "Gündüz";
            radioGunduz.UseVisualStyleBackColor = true;
            // 
            // radioGece
            // 
            radioGece.AutoSize = true;
            radioGece.Location = new Point(6, 47);
            radioGece.Name = "radioGece";
            radioGece.Size = new Size(51, 19);
            radioGece.TabIndex = 9;
            radioGece.TabStop = true;
            radioGece.Text = "Gece";
            radioGece.UseVisualStyleBackColor = true;
            // 
            // gboxRadio
            // 
            gboxRadio.Controls.Add(radioGunduz);
            gboxRadio.Controls.Add(radioGece);
            gboxRadio.ForeColor = Color.FromArgb(119, 107, 93);
            gboxRadio.Location = new Point(12, 272);
            gboxRadio.Name = "gboxRadio";
            gboxRadio.Size = new Size(196, 74);
            gboxRadio.TabIndex = 10;
            gboxRadio.TabStop = false;
            gboxRadio.Text = "Gece veya gündüz rutinini seçin.";
            gboxRadio.Enter += gboxRadio_Enter;
            // 
            // cboxGunler
            // 
            cboxGunler.BackColor = Color.FromArgb(176, 166, 149);
            cboxGunler.ForeColor = Color.FromArgb(243, 238, 234);
            cboxGunler.FormattingEnabled = true;
            cboxGunler.Location = new Point(268, 12);
            cboxGunler.Name = "cboxGunler";
            cboxGunler.Size = new Size(250, 23);
            cboxGunler.TabIndex = 11;
            cboxGunler.Text = "Görüntülemek istediğiniz günü seçin.";
            cboxGunler.SelectedIndexChanged += cboxGunler_SelectedIndexChanged;
            // 
            // lboxPlans
            // 
            lboxPlans.BackColor = Color.FromArgb(243, 238, 234);
            lboxPlans.ForeColor = Color.FromArgb(119, 107, 93);
            lboxPlans.FormattingEnabled = true;
            lboxPlans.ItemHeight = 15;
            lboxPlans.Location = new Point(268, 68);
            lboxPlans.Name = "lboxPlans";
            lboxPlans.Size = new Size(250, 154);
            lboxPlans.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(243, 238, 234);
            checkedListBox1.ForeColor = Color.FromArgb(119, 107, 93);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Tamamladığınız aktiviteleri tikleyebilirsiniz." });
            checkedListBox1.Location = new Point(268, 232);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(250, 148);
            checkedListBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(119, 107, 93);
            label1.Location = new Point(8, 50);
            label1.Name = "label1";
            label1.Size = new Size(254, 15);
            label1.TabIndex = 16;
            label1.Text = "Listeye eklemek istediğiniz aktiviteleri belirtiniz.";
            // 
            // tboxEkle
            // 
            tboxEkle.BackColor = Color.FromArgb(243, 238, 234);
            tboxEkle.ForeColor = Color.FromArgb(119, 107, 93);
            tboxEkle.Location = new Point(12, 68);
            tboxEkle.Name = "tboxEkle";
            tboxEkle.Size = new Size(250, 23);
            tboxEkle.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(119, 107, 93);
            label2.Location = new Point(268, 50);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 18;
            label2.Text = "Günün planı:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(243, 238, 234);
            btnKaydet.ForeColor = Color.FromArgb(119, 107, 93);
            btnKaydet.Location = new Point(152, 352);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(110, 46);
            btnKaydet.TabIndex = 19;
            btnKaydet.Text = "Günü planla!";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lboxAktiviteler
            // 
            lboxAktiviteler.BackColor = Color.FromArgb(243, 238, 234);
            lboxAktiviteler.ForeColor = Color.FromArgb(119, 107, 93);
            lboxAktiviteler.FormattingEnabled = true;
            lboxAktiviteler.ItemHeight = 15;
            lboxAktiviteler.Location = new Point(12, 127);
            lboxAktiviteler.Name = "lboxAktiviteler";
            lboxAktiviteler.Size = new Size(250, 109);
            lboxAktiviteler.TabIndex = 20;
            lboxAktiviteler.SelectedIndexChanged += lboxAktiviteler_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 227, 213);
            ClientSize = new Size(534, 461);
            Controls.Add(lboxAktiviteler);
            Controls.Add(btnKaydet);
            Controls.Add(label2);
            Controls.Add(tboxEkle);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Controls.Add(lboxPlans);
            Controls.Add(cboxGunler);
            Controls.Add(gboxRadio);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnEkle);
            Controls.Add(labelGiris);
            Controls.Add(pboxUser);
            Controls.Add(cboxOrnek);
            Name = "Form1";
            Text = "To Do List App v0.1";
            ((System.ComponentModel.ISupportInitialize)pboxUser).EndInit();
            gboxRadio.ResumeLayout(false);
            gboxRadio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxOrnek;
        private PictureBox pboxUser;
        private Label labelGiris;
        private Button btnEkle;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioGunduz;
        private RadioButton radioGece;
        private GroupBox gboxRadio;
        private ComboBox cboxGunler;
        private ListBox lboxPlans;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private TextBox tboxEkle;
        private Label label2;
        private Button btnKaydet;
        private ListBox lboxAktiviteler;
    }
}
