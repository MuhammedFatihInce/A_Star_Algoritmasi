using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Star_Algoritmasi
{
	public class Baslangic
	{
        public void BaslangicDurumuUret(Label label_Baslangic_Durumu)
        {
            List<int> list_baslama_durumu = RandomSayiUret();

            label_Baslangic_Durumu.Text = "";
            int listCount = list_baslama_durumu.Count;
            foreach (var item in list_baslama_durumu)
            {
                listCount--;
                label_Baslangic_Durumu.Text += item;
                if (listCount % 3 == 0)
                {
                    label_Baslangic_Durumu.Text += "\r\n";
                }
            }
        }


        public List<int> RandomSayiUret()
        {
            int[] randomSayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> randomListe = new List<int>(randomSayilar);

            int n = randomListe.Count;
            Random rnd = new Random();

            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);

                int value = randomListe[k];
                randomListe[k] = randomListe[n];
                randomListe[n] = value;
            }

            return randomListe;
        }
    }
}
