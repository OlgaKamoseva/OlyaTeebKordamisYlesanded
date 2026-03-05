namespace _7___SimpleGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lisa juurde raha muutuja ja kolm eventi mis muudavad raha seisu
             */
            int elud = 3;
            Random juhuarv = new Random();
            string mangijaMangib = "jah";
            do
            {
                Console.Clear();
                int jargmineEvent = juhuarv.Next(1, 3);
                switch (jargmineEvent)
                {
                    case 1:
                        elud = KratiM6istatus(juhuarv, elud);
                        Console.WriteLine("Sul on alles " + elud + " elu.");
                        break;
                    case 2:
                        elud = N6id(juhuarv, elud);
                        Console.WriteLine("Sul on alles " + elud + " elu.");
                        break;
                    case 3:
                        elud = MetsaSeen(juhuarv, elud);
                        Console.WriteLine("Sul on alles " + elud + " elu.");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nVajuta ykskoik klahvi et jatkata");
                Console.ReadLine();
            } while (elud > 0);

            Console.WriteLine("Baibai!");
        }

        private static int MetsaSeen(Random juhuarv, int elud)
        {
            Console.WriteLine("Leiad metsast suure triibulise seene. Kas sööd selle ära?");
            string vastus = Console.ReadLine();
            if (vastus == "ei")
            {
                Console.WriteLine("Lähed mööda, aga mingi hetk pöörad tagasi ja näed et samal kohal \nkus oli seen nüüd sinu poole pilgub väga kuri purjus päkapikk.");
                return elud;
            }
            else 
            {
                Console.WriteLine("No kus sa elus veel triibulisi seeni näed! Peaks kindlsati proovima!");
                Random eludeArv = new Random();
                int newElud = eludeArv.Next(-4, 4);
                elud = elud + newElud;
                Console.WriteLine("Ku sõid selle seene ära, kõik oli korras... Esimest paar minutit. Raske öelda mis edasi juhtus, \naga kui lõpuks oksendasid selle välja, panid tähele et sul on nüüd "+elud+" elu." );
                return elud;
                
            }
        }

        private static int N6id(Random juhuarv, int elud)
        {
            Console.WriteLine("NUEH! Oled eksinud minu koju! Mis sul - sissetungijal - oelda on!!!");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() == "palun vabandust")
            {
                Console.WriteLine("No olgu, eks sa mine siis...");
                return elud;
            }
            else if (vastus.ToLower() == "tahtsin sulle kooki tuua")
            {
                Console.WriteLine("Oi aitah, annan sulle yhe elu selle koogi eest");
                return elud + 1;
            }
            else
            {
                Console.WriteLine("MISASJA!?!?!?! KUIDAS SA JULGED?!?! KAI ISE");
                return elud - 1;
            }
        }

        private static int KratiM6istatus(Random juhuarv, int elud)
        {
            int seeJuhuArv = juhuarv.Next(1, 10);
            Console.WriteLine("Hahaaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ara \n mitme vanaeide kaed ma olen otsast ara soonud!");
            Console.WriteLine("Arva:");
            int kasutajaArv = int.Parse(Console.ReadLine());

            if (seeJuhuArv == kasutajaArv)
            {
                Console.WriteLine("AIAIAIAAAA, Y U DIS TO ME *sureb*");
                return elud;
            }
            else
            {
                Console.WriteLine("HEJHEHEHEJ - oige vastus oli " + seeJuhuArv + "!!!! Sa kaotasid!");
                return elud -= 1;
            }
            Console.WriteLine("Sul on alles " + elud + " elu.");

        }
    }
}
