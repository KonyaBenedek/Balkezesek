using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    public class Balkezes
    {
        string nev;
        DateTime elsoLepes;
        DateTime utolsoLepes;
        int sulyFontban;
        int magassagInchben;

        public string Nev { get => nev; set => nev = value; }
        public DateTime ElsoLepes { get => elsoLepes; set => elsoLepes = value; }
        public DateTime UtolsoLepes { get => utolsoLepes; set => utolsoLepes = value; }
        public int SulyFontban { get => sulyFontban; set => sulyFontban = value; }
        public int MagassagInchben { get => magassagInchben; set => magassagInchben = value; }

        public Balkezes(string sor) 
        {
            string[] adat = sor.Split(';');
            Nev = adat[0];
            ElsoLepes = DateTime.Parse(adat[1]);
            UtolsoLepes = DateTime.Parse(adat[2]);
            SulyFontban = int.Parse(adat[3]);
            MagassagInchben = int.Parse(adat[4]);
        }
    }
}
