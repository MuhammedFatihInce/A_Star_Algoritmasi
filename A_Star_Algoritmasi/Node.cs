using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Star_Algoritmasi
{
    public class Node
    {
        public static int[] sonucMatrisi = {1,2,3,4,5,6,7,8,0};
        public int[] BaslangıcMatrisi;
        public int g; // Başlangıca olan uzaklığımız
        public int h; // Sonuca olan sezgisel uzaklığımız 
        public int f; // f = g + h
        public Node parent;

        public Node()
        {
            BaslangıcMatrisi = new int[9];
            parent = null;
        }

        public void FdegeriniHesapla()
        {
            f = g + h;
        }

       
        public void HdegeriniHesapla()
        {

            h = 0;
            for (int i = 0; i < 9; i++)
            {
                int sonucIndex = Array.IndexOf(sonucMatrisi, BaslangıcMatrisi[i]);

                int sutun = i % 3;
                int satir = i / 3;

                int hedefSutun = sonucIndex % 3;
                int hedefSatir = sonucIndex / 3;

                h += Math.Abs(sutun - hedefSutun) + Math.Abs(satir - hedefSatir);
            }

        }

        public void MatrisOlusturma(Label textBox_GUI)
        {
            string[] okunandegerler = textBox_GUI.Text.Replace("\n", " ").Replace("\r", "").Split();
            string[] okunandegerler2 = { okunandegerler[0] , okunandegerler[1], okunandegerler[2]};
            char[] a= okunandegerler2[0].ToArray();
            char[] a2 = okunandegerler2[1].ToArray();
            char[] a3 = okunandegerler2[2].ToArray();

            for (int i = 0; i < 3; i++)
            {
                BaslangıcMatrisi[i] = Int32.Parse(a[i].ToString());
                BaslangıcMatrisi[i+3] = Int32.Parse(a2[i].ToString());
                BaslangıcMatrisi[i+6] = Int32.Parse(a3[i].ToString());
            }
        }

        public void TextboxMatrisSonucYaz(TextBox textBox)
        {
            textBox.Text += " ********** \r\n";
            for (int i = 0; i < 9; i++)
            {
                if (BaslangıcMatrisi[i] == 0)
                {
                    textBox.Text += "   ";
                }
                else
                    textBox.Text += BaslangıcMatrisi[i].ToString() + "";

                if (i%3==2)
                {
                    textBox.Text += "\r\n";
                }
            }
        }
    }

   
}
