
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Star_Algoritmasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			BitisDurumuUret();
		}
        
        private void BitisDurumuUret()
        {
            label_Bitis_Durumu.Text = "123\n\r456\n\r780";

        }


        private void button_Uret_Click_1(object sender, EventArgs e)
		{
            try
            {
                Baslangic b = new Baslangic();
                Solution s = new Solution();
                label_Baslangic_Durumu.Text = "";
                textBox_Adimlar.Text = "";
                b.BaslangicDurumuUret(label_Baslangic_Durumu);
                s.BulmacayiCoz(label_Baslangic_Durumu, label_Kontrol, textBox_Adimlar);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
	}
}