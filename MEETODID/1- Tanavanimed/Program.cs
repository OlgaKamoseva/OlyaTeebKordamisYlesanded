
namespace _1_Tanavanimed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kasutades meetodeid ja sõnetöötlemisvahendeid sisendi kontrolli jaoks, kirjuta programm mis:
            /*
             * küsib kasutajalt tema kodukandi tänavanimesid
             * küsib kasutajalt millina tähestiku täht talle ei meeldi
             * programm otsib järjendist üles kõik tänavamined milles ebameeldiv täht esineb
             * eemaldab need järjendist
             * ja kuvab järjendi välja
             * programm loendab ka kokku eemaldatud nimede arvu, ning tagastab sõnumi koos loendiga mitu sõna eemaldati
             */
            //debugimise kood
            //Console.WriteLine("Sisesta tanavanimi");
            //string tanavanimi = SisendiVottJaKontroll();
            //Console.WriteLine(tanavanimi);
            List<string> tanavaNimed = new List<string>();
            Console.WriteLine("Kirjuta siia oma kodukandi tänavanimed, kui rohkem ei ole, kirjuta ei-ole");
            string sisestus = "";
            do
            {
                Console.WriteLine("Sisesta tänavanimi");
                sisestus = SisendiVottJaKontroll();
                if (sisestus != "Ei-ole")
                {
                    tanavaNimed.Add(sisestus);
                }
            } while (sisestus != "Ei-ole");

            //debugimise kood
            //foreach (var nimi in tanavaNimed)
            //{
            //    Console.WriteLine(nimi);
            //}
            Console.WriteLine("Kirjuta taht mis sulle ei meeldi");
            string ebameeldivTäht = SisendiVottJaKontroll(" ");
            List<string> uusJarjend = JarjendiFiltreerimine(tanavaNimed, ebameeldivTäht);
            KuvaAndmed(uusJarjend);
        }

        private static void KuvaAndmed(List<string> kuvatavadAndmed)
        {
            if (kuvatavadAndmed.Count > 0)
            {
                for (int i = 0; i < kuvatavadAndmed.Count; i++)
                {
                    Console.WriteLine((i+ 1)+". "+ kuvatavadAndmed[i]);
                }
                return;
            }
            Console.WriteLine("Jarjend in tuhi");
            return;
        }

        private static List<string> JarjendiFiltreerimine(List<string> filtreeritavadAndmed, string filter)
        {
            int loendur = 0;
            List<string> toodeldudAndmed = new List<string>();
            foreach (var anne in filtreeritavadAndmed)
            {
                if (!anne.ToLower().Contains(filter.Substring(0,1).ToLower()))
                {
                    toodeldudAndmed.Add(anne);
                }
                else
                {
                    loendur++; 
                }
            }
            Console.WriteLine($"Eemaldati {loendur} elementi");
            return toodeldudAndmed;
        }
        public static string SisendiVottJaKontroll()
        {
            string sisestus = "";
            string toodeldudSisestus = "";
            do
            {
                Console.WriteLine("Kirjuta siia: ");
                sisestus = Console.ReadLine();
                if (sisestus.Length > 1)
                {
                    toodeldudSisestus = (sisestus.Substring(0, 1).ToUpper() + sisestus.Substring(1).ToLower());
                }
                else
                {
                    Console.WriteLine("Tänavanimi ei saa olla lühem kui 2 tähte!");
                    sisestus = "";
                }
            }
            while (string.IsNullOrEmpty(sisestus));
            return toodeldudSisestus;
        }
        public static string SisendiVottJaKontroll(string addition)
        {
            string sisestus = "";
            string toodeldudSisestus = "";
            do
            {
                Console.WriteLine("Kirjuta siia: ");
                sisestus = Console.ReadLine()+addition;
                if (sisestus.Length > 1)
                {
                    toodeldudSisestus = (sisestus.Substring(0, 1).ToUpper() + sisestus.Substring(1).ToLower());
                }
                else
                {
                    Console.WriteLine("Tänavanimi ei saa olla lühem kui 2 tähte!");
                    sisestus = "";
                }
            }
            while (string.IsNullOrEmpty(sisestus));
            return toodeldudSisestus;
        }
    }
}