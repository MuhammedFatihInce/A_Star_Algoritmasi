using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Star_Algoritmasi
{
	public class Solution
	{
        Node node;
        public void BulmacayiCoz(Label label_Baslangic_Durumu, Label label_Kontrol, TextBox textBox_Adimlar)
        {
            node = new Node();
            node.MatrisOlusturma(label_Baslangic_Durumu);
            List<Node> acikListKuyruk = new List<Node>();
            List<int[]> kapaliListe = new List<int[]>();


            if (!Kontrol(node.BaslangıcMatrisi, Node.sonucMatrisi))
            {
                label_Kontrol.Text = "Problem Çözülemez, Lütfen Tekrar Deneyin";
                return;
            }
            else
                label_Kontrol.Text = "Başarılı.";

            node.HdegeriniHesapla();
            node.FdegeriniHesapla();

            acikListKuyruk.Add(node);
            Node minYol;

            do
            {
                minYol = MinimumYolBul(acikListKuyruk);
                kapaliListe.Add(minYol.BaslangıcMatrisi);
                KuyrugaCocuklariEkle(minYol, acikListKuyruk, kapaliListe);
            } while (minYol.h != 0 && acikListKuyruk.Count > 0);

            Sonucyaz(minYol, textBox_Adimlar, 0);
        }

        public bool Sonucyaz(Node minYol, TextBox label_Kontrol, int v)
        {
            if (minYol == null)
            {
                return true;
            }

            Sonucyaz(minYol.parent, label_Kontrol, v);
            minYol.TextboxMatrisSonucYaz(label_Kontrol);
            return false;
        }

        public void KuyrugaCocuklariEkle(Node minYol, List<Node> acikListKuyruk, List<int[]> kapaliListe)
        {
            
            int boslukIndex = Array.IndexOf(minYol.BaslangıcMatrisi, 0);
            if ((boslukIndex % 3) != 2)
            {
                // boşluğun sağda komşusu var mı? varsa;
                Node child = CreateChild(minYol, boslukIndex, boslukIndex + 1);
                if (!Eklimi(child.BaslangıcMatrisi, kapaliListe))
                {
                    acikListKuyruk.Add(child);
                }
            }

            if ((boslukIndex % 3) != 0)
            {
                // boşluğun sol komşusu varsa
                Node child = CreateChild(minYol, boslukIndex, boslukIndex - 1);
                if (!Eklimi(child.BaslangıcMatrisi, kapaliListe))
                {
                    acikListKuyruk.Add(child);
                }
            }

            if ((boslukIndex - 3) >= 0)
            {
                //boşluğun üst kısımda komşusu varsa
                Node child = CreateChild(minYol, boslukIndex, boslukIndex - 3);
                if (!Eklimi(child.BaslangıcMatrisi, kapaliListe))
                {
                    acikListKuyruk.Add(child);
                }
            }

            if ((boslukIndex + 3) < 9)
            {
                //boşluğun alt kısmında komşusu varsa
                Node child = CreateChild(minYol, boslukIndex, boslukIndex + 3);
                if (!Eklimi(child.BaslangıcMatrisi, kapaliListe))
                {
                    acikListKuyruk.Add(child);
                }
            }
            acikListKuyruk.Remove(minYol);
        }

        public bool Eklimi(int[] matrisDegerler, List<int[]> kapaliListe)
        {
            foreach (int[] item in kapaliListe)
            {
                bool isEqual = true;
                for (int i = 0; i < 9; i++)
                {
                    if (item[i] != matrisDegerler[i])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual == true)
                    return true;
            }
            return false;
        }

        public Node CreateChild(Node minYol, int boslukIndex, int v_degerIndex)
        {
            
            Node child = new Node();
            Array.Copy(minYol.BaslangıcMatrisi, child.BaslangıcMatrisi, minYol.BaslangıcMatrisi.Length);

            
            child.g = minYol.g + 1;

            SwapDegerler(child.BaslangıcMatrisi, boslukIndex, v_degerIndex);

            child.HdegeriniHesapla();
            child.FdegeriniHesapla();
            child.parent = minYol;
            return child;
        }

        public void SwapDegerler(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public Node MinimumYolBul(List<Node> acikListKuyruk)
        {
            int minIndex = 0;
            for (int i = 0; i < acikListKuyruk.Count; i++)
            {
                if (acikListKuyruk[i].f < acikListKuyruk[minIndex].f)
                {
                    minIndex = i;
                }
            }
            return acikListKuyruk[minIndex];
        }


        public bool Kontrol(int[] matrisDegerler, int[] sonucMatrisimiz)
        {
            int tersSiralamaSayisi = 0;

            for (int i = 0; i < matrisDegerler.Length - 1; i++)
            {
                if (matrisDegerler[i] == 0)
                    continue;

                for (int j = i + 1; j < matrisDegerler.Length; j++)
                {
                    if (matrisDegerler[j] == 0)
                        continue;

                    int indexI = Array.IndexOf(sonucMatrisimiz, matrisDegerler[i]);
                    int indexJ = Array.IndexOf(sonucMatrisimiz, matrisDegerler[j]);

                    if (indexI > indexJ)
                    {
                        tersSiralamaSayisi++;
                    }
                }
            }

            return tersSiralamaSayisi % 2 == 0;

        }
    }
}
