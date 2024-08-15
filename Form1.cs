using System.Windows.Forms;

namespace to_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.SetItemChecked(0, true); //checkedListBox içindeki 0. indeksin her zaman tikli kalmasını sağlar.
            pboxUser.Visible = false; // kullanıcı giriş sistemi'de ileride gelecek.
            labelGiris.Visible = false;
        }

        private void pboxUser_Click(object sender, EventArgs e)
        {

        }

        private void labelGiris_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cboxOrnek.Items.Add(tboxEkle.Text); //comboBox'a text'box içinde girilen verileri ekler.
            tboxEkle.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboxOrnek_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxAktiviteler.Items.Add(cboxOrnek.Text + "\n"); //listBox'a comboBox'ta seçilen verileri eklemeye yarar.
            
            if (lboxAktiviteler.Items.Count > 0 && lboxAktiviteler.Items[0].ToString() == "Aktiviteleri unuttunuz!")
            {
                lboxAktiviteler.Items.RemoveAt(0); //aktiviteleri unuttunuz indeksini listBox içinden silmeye yarar.
            }
        }

        private void gboxRadio_Enter(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lboxAktiviteler.Items.Count == 0) 
            {
                lboxAktiviteler.Items.Add("Aktiviteleri unuttunuz!"); //eğer listBox boş iken btnKaydet_Click aksiyonu alınırsa listBox içine aktiviteleri unuttunuz şeklinde bir uyarı verir.
            }
            else
            {
                if (radioGunduz.Checked == true)
                {
                    cboxGunler.Items.Add((DateTime)dateTimePicker1.Value + " " + "GÜNDÜZ PLANI"); //günün rutininin gündüz ilerleyeceği anlamına gelir.
                }
                else
                {
                    cboxGunler.Items.Add((DateTime)dateTimePicker1.Value + " " + "GECE PLANI"); //günün rutininin gece ilerleyeceği anlamına gelir.
                }
            }
        }

        private void cboxGunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxGunler.SelectedItem.ToString() == dateTimePicker1.Value + " " + "GÜNDÜZ PLANI")
            {
                foreach (var item in lboxAktiviteler.Items)
                {
                    lboxPlans.Items.Add(item); //eğer uygulamanın sol tarafındaki veriler ile lboxPlans listesindeki gün uyuşuyorsa o verileri uygulamanın sağ tarafına aktarmaya yarar.
                }
            }
            else if (cboxGunler.SelectedItem.ToString() == dateTimePicker1.Value + " " + "GECE PLANI")
            {
                foreach (var item in lboxAktiviteler.Items)
                {
                    lboxPlans.Items.Add(item);
                }
            }
            else
            {
                lboxPlans.Text = "Belirtilen güne ait veri bulunamadı."; //eğer veri yok ise bu şekilde hata verir.
            }

            if (cboxGunler.SelectedItem.ToString() == dateTimePicker1.Value.ToString("MM/dd/yyyy") + " " + "GÜNDÜZ PLANI")
            {
                foreach (var item in lboxAktiviteler.Items)
                {
                    checkedListBox1.Items.Add(item); //checkedListBox içine verileri aktarmaya yarar.
                }
            }
            else if (cboxGunler.SelectedItem.ToString() == dateTimePicker1.Value + " " + "GECE PLANI")
            {
                foreach (var item in lboxAktiviteler.Items)
                {
                    checkedListBox1.Items.Add(item);
                }
            }
            else
            {
                checkedListBox1.Items.Add("Belirtilen güne ait veri bulunamadı."); //eğer veri yok ise bu şekilde hata verir.
            }
        }

        private void lboxAktiviteler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}