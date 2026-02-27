namespace _2_Sulgudega_Kalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta, koos sisendikontrolliga ja sisendi normaliseerimisega, programm
            //küsib kasutajalt kolme tehet, esimene ja kolmas peaksid olema sulgude vahel
            //kasutaj asaab määrata igale tehtele märgi
            //programm kuvab vastuse vastavalt tehete järjekorrale
            Console.WriteLine("Palun sisesta arv: ");
            string[] tehterida = new string[7];
            Console.WriteLine("( arv tehe arv ) tehe ( arv tehe arv )");
            for (int i = 0; i < tehterida.Length; i++)
            {
                //string displayLine = "( ";
                //foreach (var input in tehterida)
                //{
                //    if (input.Contains())
                //}
                string sisestus = "";
                do
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Palun sisesta {i + 1} tehe: ");
                    }
                    else
                    {
                        Console.WriteLine($"Palun sisesta {i + 1} arv: ");
                    }
                    sisestus = Console.ReadLine();
                    double checkSisestus = 0;
                    if(i % 2 == 0)
                    {
                        if(!Double.TryParse(sisestus, out checkSisestus))
                        {
                            Console.WriteLine("ei ole arv, proovi uuesti");
                            sisestus = "";
                        }
                        else if (sisestus != "+" && sisestus != "-" &&  sisestus != "*" &&  sisestus != "/")
                        {
                            Console.WriteLine("Ei ole tehtemark, proovi uuesti");
                            sisestus = "";
                        }
                    }
                } while (sisestus != "");
            }
            List<string> sulud = new List<string>();
            for (int i = 0; tehterida.Length > 0; i++)
            {
                if (sulud.Count > 3)
                {
                    sulud.Add(tehterida[i]);
                }
                else
                {

                }
            }
            double tehe = UksTehe(
                [
                UksTehe(
                    [tehterida[0], tehterida[1], tehterida[2]]
                ).ToString(),
                tehterida[3],
                UksTehe(
                    [tehterida[4], tehterida[5], tehterida[6]])]
        }
        private static void UksTehe(string[] tehterida)
        { 
            foreach (var item in tehterida)
            {
                switch (item)
                {
                    case "+":
                        return Liitmine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
                        break;
                    case "-":
                        return Lahutamine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
                        break;
                    case "*":
                        return Korrutamine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
                        break;
                    case "/":
                        return Jagamine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
                        break;


                    default:
                        break;
                }
            }
        }
        
        public static double Liitmine(double arv1, double arv2)
        {
            return arv1 + arv2;
        }
        public static double Lahutamine(double arv1, double arv2)
        {
            return arv1 - arv2;
        }
        public static double Korrutamine(double arv1, double arv2)
        {
            return arv1 * arv2;
        }
        public static double Jagamine(double arv1, double arv2)
        {
            return arv1 / arv2;
        }
    }
}