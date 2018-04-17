using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
namespace Zad_1_Graf
{
    class kMeans
    {
        public List<dane> listaCentroidow = new List<dane>();
        public List<dane> punkty = new List<dane>();
        public List<double> listaBledu { get; } = new List<double>();
        double bladKwantyzacji = 0.0;

        public kMeans(List<dane> pkt)
        {
            this.punkty = pkt;
        }
        public void Forgy(int iloscCentroidow)
        {
            Random r = new Random(0);
            for (int i = 0; i < iloscCentroidow; i++)
            {
                listaCentroidow.Add(punkty[r.Next(punkty.Count())]);
                listaCentroidow[i].idGrupy = i;
            }
            Boolean czyZmienilyPolozenie;
            int iterator = 0;
            do
            {
                czyZmienilyPolozenie = false;
                NadanieGrupZbiorowi(ref punkty, listaCentroidow);
                PrzesuniecieCentroidow(punkty, ref listaCentroidow, ref czyZmienilyPolozenie);
                bladKwantyzacji = bladKwantyzacji / punkty.Count();
                iterator++;
                listaBledu.Add(bladKwantyzacji);
            } while (czyZmienilyPolozenie == true && iterator < 200);   //SPRAWDZ WARUNKI
        }
        public void RandomPartition(int iloscCentroidow)
        {
            Random r = new Random(0);
            for (int i = 0; i < iloscCentroidow; i++)
            {
                dane temp = new Zad_1_Graf.dane();
                temp.X = 0;
                temp.Y = 0;
                temp.idGrupy = i;
                listaCentroidow.Add(temp);
            }
            foreach (dane d in punkty)
            {
                d.idGrupy = r.Next(iloscCentroidow);
            }

            Boolean czyZmienilyPolozenie;
            int iterator = 0;
            int maxIter = punkty.Count() * 10;
            do
            {
                czyZmienilyPolozenie = false;
                PrzesuniecieCentroidow(punkty, ref listaCentroidow, ref czyZmienilyPolozenie);
                NadanieGrupZbiorowi(ref punkty, listaCentroidow);
                bladKwantyzacji = bladKwantyzacji / punkty.Count();
                iterator++;
                listaBledu.Add(bladKwantyzacji);
            } while (czyZmienilyPolozenie == true && iterator < 200);

        }
        private double Distance(dane centroid, dane punkt)
        {
            double x1 = Math.Pow(centroid.X - punkt.X, 2);
            double x2 = Math.Pow(centroid.Y - punkt.Y, 2);
            return Math.Sqrt(x1 + x2);
        }
        public void NadanieGrupy(ref dane punktDocelowy, List<dane> listaPunktow)
        {
            Dictionary<double, dane> d = new Dictionary<double, dane>();
            foreach (var punkt in listaPunktow)
            {
                double od = Distance(punkt, punktDocelowy);


                while (d.ContainsKey(od))               //w razie gdyby algorytm nie mogl zdecydowac do ktorego centroidu mamy przypisac punkt
                {
                    od = od + 0.000001;
                }
                d.Add(od, punkt);
            }
            var g = d.First(k => k.Key == d.Keys.Min()).Value.idGrupy;
            punktDocelowy.idGrupy = g;
            bladKwantyzacji += Distance(punktDocelowy, listaPunktow[g]);
        }
        public void NadanieGrupZbiorowi(ref List<dane> zbior, List<dane> centroidy)
        {
            for (int i = 0; i < zbior.Count; i++)
            {
                dane punkt2 = zbior[i];                 //kopiowana jest referencja do zmiennej dlatego to zadziala
                NadanieGrupy(ref punkt2, centroidy);
            }
        }
        public void PrzesuniecieCentroidow(List<dane> zbior, ref List<dane> kpunkty, ref Boolean czyZmienilyPolozenie)
        {
            foreach (var kpunkt in kpunkty)
            {
                List<dane> punkty = new List<dane>();

                foreach (var punkt in zbior)
                {
                    if (punkt.idGrupy == kpunkt.idGrupy)
                    {
                        punkty.Add(punkt);
                    }
                }

                double x = 0;
                double y = 0;
                if (punkty.Count > 0)
                {
                    x = punkty.Average(i => i.X);
                    y = punkty.Average(i => i.Y);
                    if (kpunkt.X != x)
                        czyZmienilyPolozenie = true;
                    if (kpunkt.Y != y)
                        czyZmienilyPolozenie = true;
                    kpunkt.X = x;
                    kpunkt.Y = y;
                }
            }
        }
    }
}
