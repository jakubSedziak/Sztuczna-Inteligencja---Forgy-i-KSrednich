
using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zad_1_Graf
{
    
    public partial class Form1 : Form
    {
        List<dane> punkty = new List<dane>();
        kMeans ksrednie;
        kMeans kRandom;
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("eng-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("eng-US");
            /////WCZYTYWANIE DANYCH//////
            string path = @"dane.txt";
            ReadFile(path,ref punkty);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //           Form2 fr2 = new Form2();
            //           fr2.Show();
            /////////////////////////////
                        ksrednie = new kMeans(punkty);
                        ksrednie.Forgy(Convert.ToInt32(iloscK.SelectedItem));
            //            Wykres.Series["Dane 1"].Points.Clear();
            //            Wykres.Series["Dane 2"].Points.Clear();
            //            Wykres.Series["Dane 3"].Points.Clear();
            //            fr2.WykresBledu.Series["Dane 1"].Points.Clear();
            //            fr2.WykresBledu.Series["Dane 2"].Points.Clear();

            kRandom = new kMeans(punkty);
            kRandom.RandomPartition(Convert.ToInt32(iloscK.SelectedItem));

            /*
            foreach (dane d in ksrednie.listaCentroidow)
            {
                Wykres.Series["Dane 2"].Points.AddXY(d.X, d.Y);
            }
            foreach (dane d in ksrednie.punkty)
            {
                Wykres.Series["Dane 1"].Points.AddXY(d.X, d.Y);
            }
            foreach (dane d in kRandom.listaCentroidow)
            {
                Wykres.Series["Dane 3"].Points.AddXY(d.X, d.Y);
            }
            foreach (double d in ksrednie.listaBledu)
            {
                fr2.WykresBledu.Series["Dane 1"].Points.Add(d);
            }
            foreach (double d in kRandom.listaBledu)
            {
                fr2.WykresBledu.Series["Dane 2"].Points.Add(d);
            }
            */
        }
        public void ReadFile(string path,ref List<dane> punkty)
        {
            
            string s;
            using (StreamReader sr = new StreamReader(path))//wczytanie
            {
                s = sr.ReadToEnd();

            }
            List<string> numb = new List<string>();
            int it = 0;
            string temp = "";
            while( s.Length!=0)
            {
                dane temPkt = new dane();
                temPkt.idGrupy = -1;
                while(s[it]!='\r' && s[it]!='\n'&& s[it]!='\0' && s.Length>it+1)
                {
                    if (s[it] == ',')                   //Jesli przecinek to dodaj x 
                    {
                        temPkt.X = Convert.ToDouble(temp);
                        s = s.Remove(0, it + 1);
                        it = 0;
                        temp = "";
                        continue;
                    }
                    temp += s[it];
                    it++;
                }           
                if(temp!="")
                {
                    temPkt.Y = Convert.ToDouble(temp);
                    punkty.Add(temPkt);
                   
                }
                if (s.Length != it)
                s = s.Remove(0, it + 1);
                it = 0;
                temp = "";
            }
        }
        public List<dane> czytaj()
        {
            List<dane> wejsciadane = new List<dane>();
            dane temp = new dane();
            using (FileStream fs = File.Open(@"dane.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            {


                using (StreamReader sr = new StreamReader(bs))
                {
                    int j = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        int i = 0;

                        line += "\0\0";
                        while (line[i] != '\0')
                        {
                            string liczba = "";
                            double liczba_wej = 0.0;
                            double liczba_oczek = 0.0;
                            while (line[i] == ' ') i++;
                            while (line[i] != ' ') { liczba += line[i]; i++; }
                            liczba_wej = Convert.ToDouble(liczba);
                            liczba = "";

                            while (line[i] == ' ') i++;
                            while (line[i] != '\r' && line[i] != '\0' && line[i] != '\r') { liczba += line[i]; i++; }
                            liczba_oczek = Convert.ToDouble(liczba);
                            i++;
                            temp.X = liczba_wej;
                            temp.Y = liczba_oczek;
                            temp.idGrupy = -1;
                            wejsciadane.Add(temp);
                        }
                        j++;

                        // MessageBox.Show(Convert.ToString((wejsciadane[0, j]))+" "+ Convert.ToString((oczekiwania[0, j])));

                    }
                }

            }
            return wejsciadane;
        }

        public void saveFile(string path, List<double> teemp)
        {
            using (StreamWriter sr = new StreamWriter(path))//wczytanie
            {
                foreach (double x in teemp)
                    sr.WriteLine(x.ToString() + " ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wykres.Series["Dane 1"].Points.Clear();
            Wykres.Series["Dane 2"].Points.Clear();
            Wykres.Series["Dane 3"].Points.Clear();

            foreach (dane d in ksrednie.listaCentroidow)
            {
                Wykres.Series["Dane 2"].Points.AddXY(d.X, d.Y);
            }
            foreach (dane d in ksrednie.punkty)
            {
                Wykres.Series["Dane 1"].Points.AddXY(d.X, d.Y);
            }
            foreach (dane d in kRandom.listaCentroidow)
            {
                Wykres.Series["Dane 3"].Points.AddXY(d.X, d.Y);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Wykres.Series["Dane 1"].Points.Clear();
            Wykres.Series["Dane 2"].Points.Clear();
            Wykres.Series["Dane 3"].Points.Clear();
            foreach (double d in ksrednie.listaBledu)
            {
                Wykres.Series["Dane 1"].Points.Add(d);
            }
            foreach (double d in kRandom.listaBledu)
            {
                Wykres.Series["Dane 2"].Points.Add(d);
            }
        }
    }
}
