namespace _4_Mahukalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta programm mis
            //küsib kasutajalt kas ta tahab arvutada oma kasti mahtu, või õlivaadi mahtu
            //sisendite küsimiseks on oma meetod, mis ei lase programmil edasi liikuda, kuni vastus ei ole tühi, ega üks võimalikest valikutest.
            //selle tegemiseks annate meetodile parameetrina valikud listis kaasa ja .Contains abil saate kontrollida kas ta on olemas või mitte
            //kui programm teab kumba ta arvutab toimuvad järgmised tegevused
            //  kasti puhul, küsitakse kas kast on kuubik või risttahukas.
            //    - kuubiku puhul küsitakse küljepikkus, antakse parameetrina meetodile KuubiRuumala() kaasa,
            //      ning kuubiruumala tagastab double tüüpi andmena muutujasse tehte tulemuse. valem otsi internetist.
            //    - risttahuka puhul lühima ja pikima külje pikkust ning kõrgust. samamoodi arvutab parameetrite abil 
            //      meetod RisttahukaRuumala() tulemuse double andmena ja tagastab selle muutujasse.
            //  Tünni puhul, küsitakse kas ta tünn on kaanega või kaaneta.
            //    - Kui tal on kaas olemas, siis küsi selle paksust, kui ei ole, määra paksuseks ise 0
            //      Küsi kasutajalt ka tünni põhja läbimõõtu ja kõrgust ning arvuta SilindriRuumala()
            //      meetodiga kus parameetrid ka kaasas double tulemus mille tagastad muutujasse
            //      NB! kaane paksuse arvutad kõrgusest maha, sest kaas võtab õlitünni sees mingi ruumala enda poolt ära.
            //Kuva kasutajale tema ruumala tulemus peaprogrammis, mitte arvutatavates meetodites.

            int vorm = 0;
            int tyyp = 0;
            double maht = 0;
            Console.WriteLine("Kas sa soovid arvutada kasti voi olivaati mahtu? \n 1. Kast \n 2. Olivaat");
            vorm = AnumaVorm();
            if (vorm == 1)
            {
                Console.WriteLine("Kas su kast on kuubik voi risttahukas? \n 1. Kuubik \n 2. Risttahukas");
                tyyp = AnumaVorm();
                
                if (tyyp == 1)
                {
                    KuubiRuumala();
                }
                else
                {
                    RisttahukaRuumala();
                }
                
            }
            else if (vorm == 2)
            {
                Console.WriteLine("Kas su tynnil on kaas? Jah/Ei");
                string kaaneVastus = "";
                do
                {
                    kaaneVastus = Console.ReadLine().ToLower();
                } while (kaaneVastus != "jah" && kaaneVastus != "ei");
                double kaanePaksus = 0;
                if (kaaneVastus == "jah")
                {
                    Console.WriteLine("Mis selle kaane paksus on?");
                    kaanePaksus = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Mis su tynni labimoot on?");
                double labimoot = double.Parse(Console.ReadLine());
                Console.WriteLine("Mhm... Ja korgus?");
                double korgus = double.Parse(Console.ReadLine());
                maht = SilindriRuumala(labimoot, korgus, kaanePaksus);
                Console.WriteLine($"Su tynni maht on {maht}");

            }

        }
            
            
        private static int AnumaVorm()
        {
            int kasutajavastus = 0;
            do
            {
                Console.WriteLine("Palun kirjuta numbriga:");
            kasutajavastus = int.Parse(Console.ReadLine());
            } while (kasutajavastus != 1 && kasutajavastus != 2);

            return kasutajavastus;
        }
        private static void KuubiRuumala()
        {
            Console.WriteLine("Mis su kasti kyljepikkus on?");
            double pikkus = double.Parse(Console.ReadLine());
            double maht = Math.Pow(pikkus, 3);
            Console.WriteLine($"Su kasti maht on {pikkus}^3 = {maht}");
        }
        private static void RisttahukaRuumala()
        { 
            Console.WriteLine("Kitjuta palun oma kasti pikkust, korgust ja sygavust, yks number rea kohta");
            double pikkus = double.Parse (Console.ReadLine());
            double korgus = double.Parse(Console.ReadLine());
            double sygavus = double.Parse(Console.ReadLine());
            Console.WriteLine($"Su kasti maht on {pikkus}*{korgus}*{sygavus} = {pikkus*korgus*sygavus}");
        }
        private static double SilindriRuumala(double lai, double pikk, double kaas)
        {
            double volume = 3.14 * lai * (pikk - kaas);
            return volume;
        }
    }
}