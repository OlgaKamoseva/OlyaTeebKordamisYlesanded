

namespace _5_Method_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> koodid = new List<int>() { 4321,1166,1182,9001,0067,1620 };
            List<double> kontod = new List<double>() { 0, -23.6d, 144d, 10512.11d, -402d, 6.70d};
            //Pangaautomaat
            Console.WriteLine("Tere tulemast Hansapanka, palun sisesta oma pin-kood: ");
            int pinKood = KoodiSisestus(koodid);
            TervitaKasutajat(pinKood);
            EsitaKontojaak(pinKood, koodid, kontod);
            Console.WriteLine("Mida sa teha soovid? Palun vali arvuga: ");
            string[] valikud = new string[] { "Vota raha valja", "pane raha sisse" };
            int valikuteArv = valikud.Length;
            for (int i = 0; i < valikud.Length; i++)
            { 
                Console.WriteLine((i+1)+". "+valikud[i]);
            }
            int kasutajaValik = Valik(new List<int> { 1,2});
            if (kasutajaValik-1 == 0)
            {
                kontod = KontoJaagiHaldur(koodid, kontod, pinKood);
            }
            if (kasutajaValik == 2)
            {
                kontod = KontoJaagiHaldur(koodid, kontod, pinKood, false);
            }
            EsitaKontojaak(pinKood, koodid, kontod);
        }

        private static List<double> KontoJaagiHaldur(List<int> koodid, List<double> kontod, int pinKood, bool? isPositive = true)
        {
            if (isPositive = true)
            {
                Console.WriteLine("Kui palju raha soovid valja votta?: ");
            }
            else
            {
                Console.WriteLine("Kui palju raha soovid sisse panna? :");
            }
            double valjaSumma = double.Parse(Console.ReadLine());
            while (valjaSumma > 0)
            {
                if (isPositive == true)
                {
                    kontod = Valjavote(pinKood, koodid, kontod, valjaSumma);
                }
                else
                {
                    kontod = Valjavote(pinKood, koodid, kontod, -valjaSumma);
                }
                return kontod;
            }    
            
        }


        private static List<double> Valjavote(int filter, List<int> accounts, List<double> balances, double withdrawAmount)
        {
            int elementlocation = accounts.IndexOf(filter);
            balances[elementlocation] -= withdrawAmount;
            return balances;
        }

        public static void EsitaKontojaak(int filter, List<int> accounts, List<double> balances)
        {
            int elementlocation = accounts.IndexOf(filter);
            Console.WriteLine("Teie kontojaak on: " + balances.ElementAt(elementlocation));
        }
        public static void TervitaKasutajat(int userPin)
        {
            Console.WriteLine("Tere, " + userPin + ", oled sisenenud Hansapanga automaati");
        }
        private static int Valik(List<int> valikud)
        {
            int valik;
            do
            {
                Console.WriteLine("Sisesta oma valik: ");
                valik = int.Parse(Console.ReadLine());
            } while (!valikud.Contains(valik));
            return valik;
        }
        private static int KoodiSisestus(List<int> andmebaasiInfo)
        {
            int pinKood = 0;
            do
            {
                Console.WriteLine("Sisesta kood: ");
                pinKood = int.Parse(Console.ReadLine());
            } while (!andmebaasiInfo.Contains(pinKood));
            return pinKood;
        }
    }
}