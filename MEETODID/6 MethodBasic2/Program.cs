namespace _6_MethodBasic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////on meetod mis kuvab kasutajale ühe sõnumi
            //KuvaSõnum();
            ////on meetod mis tahab teada, kui palav õues on: temperatuur
            //Console.WriteLine("Mis temperatuur õues on?");
            //double misOnTemp = double.Parse(Console.ReadLine());
            //KuiPalavOn(100);
            ////on meetod, mis arvutab järjendi kõikide elementide keskmise, hoiab muutujas meeles
            //// ja kuvab eraldi real välja peaprogrammis, mitte meetodis, meetod ainult tagastab väärtuse
            //double scores = ArvutaKeskmine(new List<double> { 3.5, 7.7, 1.1, 5, 8, 9.2 });
            //Console.WriteLine("Keskmine on: "+scores);

            //õnneennustaja
            //vaja on:
            // - kasutajanime
            // - tema sünniaastat
            // - lemmikvääriskivi
            // - lemmiklooma liik
            Console.WriteLine("Tere õhtust, eksind rändaja, kas sa soovid oma tulevikku vaadata? \n Kui jah, siis kirjuta oma nimi");
            string eksinudNimi = Console.ReadLine();
            Console.WriteLine("Mis aastal oled siia ilma eksinud?");
            string eksinudAasta = Console.ReadLine();
            Console.WriteLine("Mis on sinu lemmik vääriskivi?");
            string eksinudKivi = Console.ReadLine();
            Console.WriteLine("Mis on sinu lemmik loom?");
            string eksinudLoom = Console.ReadLine();
            int nimeTähed = eksinudNimi.Length;
            int viimaneAastaArv = int.Parse(eksinudAasta.Substring(eksinudAasta.Length,1));
            RahaÕnn(nimeTähed, viimaneAastaArv);
            string iseloom = LapseOnn(eksinudLoom);
            if (iseloom == "ei-tea")
            {
                Console.WriteLine("OI OUDUST, SELLIST ELAJAT EI TOHI VALJA LASTA!!! \n congrats oled incel");
            }
            else
            {
                Console.WriteLine("Kallis "+eksinudNimi+", sinu laps, ma naen, peab olema "+iseloom+".");
            }
            KaitseOnn(eksinudKivi);
        }
        public static void KaitseOnn(string kivi)
        {
            List<string> vargus = new List<string>() { "ahhaat", "graniit", "topaas"};
            List<string> vigastus = new List<string>() { "smaragd", "rubiin", "jaspis" };
            List<string> hullumus = new List<string>() { "tiigrisilm", "kvarts", "amazoniit" };
            if (vargus.Contains(kivi))
            {
                Console.WriteLine("Sinu kivi - " + kivi + " - kaitseb sind hasti varguste eest");
            }
            else if (vigastus.Contains(kivi))
            {
                Console.WriteLine("Sinu kivi - " + kivi + " - kaitseb sind igasuguste vigastuste eest");
            }
            else if (hullumus.Contains(kivi))
            { 
                Console.WriteLine("Sinu kivi - "+kivi+" - hoiab sind mentaalses tasakaalus");
            }
            else
            {
                Console.WriteLine("Puhas praht, viska minema");
            }

        }

        public static string LapseOnn(string loom)
        {
            if (loom == "janes")
            {
                return "krapsakas";
            }
            else if (loom == "karu")
            {
                return "dummy";
            }
            else if (loom == "koer")
            {
                return "jube";
            }
            else if (loom == "kass")
            {
                return "laisk";
            }
            else if (loom == "kyylik")
            {
                return "paikeseline";
            }
            else if (loom == "hamster")
            {
                return "forever smol";
            }
            else if (loom == "kalad")
            {
                return "pissija";
            }
            else if (loom == "siga")
            {
                return "siga";
            }
            else
            {
                return "ei-tea";
            }
        }
        public static void RahaÕnn(int nimetähearv, int aastaarv)
        {
            //väiksem kui 0 suurem kui 10
            if (nimetähearv < 0 || nimetähearv > 10)
            {
                Console.WriteLine("OIoiOIoiOIoi, su onn on pohimotteliselt olematu, tunnen su rahakottipouale kaasa");
            }
            else
            {
                switch(nimetähearv)
                {
                    case 1:
                        Console.WriteLine("Aiaaa, su lauaarvuti RAM suri ara, nyyd pead oma kolm neeru maha myyma");
                        break;
                    case 2:
                        Console.WriteLine("Kurat vottis su onne endale, piinled tootukassas");
                        break;
                    case 3:
                        Console.WriteLine("Taitsa pekkis, jatsid oma telefoni rongi");
                        break;
                    case 4:
                        Console.WriteLine("Loid varbad ara ja astusid lego peale ka");
                        break;
                    case 5:
                        Console.WriteLine("Rahakott on normaalselt ka edaspidi natukese koormaga");
                        break;
                    case 6:
                        Console.WriteLine("Voitsid niisama summi, +15 eur :D");
                        break;
                    case 7:
                        Console.WriteLine("Sulle naeratab elu, leiad maast 260 eur");
                        break;
                    case 8:
                        Console.WriteLine("Voidad loteriis autot, neeru ja 18 arbuusi");
                        break;
                    case 9:
                        Console.WriteLine("Sul on gay sugar daddy, nyyd oled nii rikas et leidsid endale sugar baby ka");
                        break;
                    default:
                        Console.WriteLine("Error 404, tulevikku ei leitud");
                        break;
                }
            }
        }
        /// <summary>
        /// Arvutav meetodisse parameetrina kaasa antud nimekirjas olevate arvude keskmine
        /// </summary>
        /// <param name="andmed"> meetodi too jaoks vajaminev sisend</param>
        /// <returns>komakohaga arvu andmete keskmise arvutusega</returns>
        public static double ArvutaKeskmine(List<double> andmed)
        {
            double keskmine = 0;
            for (int i = 0;i<andmed.Count; i++)
            {
                keskmine += andmed[i];
            }
            keskmine /= andmed.Count;
            KuiPalavOn(keskmine);
            return keskmine;
        }

        public static void KuiPalavOn(double temp)
        {
            if (temp <= 0 && temp >= -50)
            {
                Console.WriteLine("KYLM BLYAT");
            }
            else if (temp > 0 && temp <= 15)
            {
                Console.WriteLine("Jahe");
            }
            else if (temp > 15 && temp <= 25)
            {
                Console.WriteLine("Päris soe");
            }
            else if (temp > 25 && temp <= 40)
            {
                Console.WriteLine("PALAV BLYAT");
            }
            else
            {
                Console.WriteLine("UR DED");
            }
        }

        public static void KuvaSõnum()
        {
            Console.WriteLine("TeRe");
        }


    }
}
