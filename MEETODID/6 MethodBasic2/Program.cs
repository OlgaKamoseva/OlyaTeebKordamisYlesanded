namespace _6_MethodBasic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //on meetod mis kuvab kasutajale ühe sõnumi
            KuvaSõnum();
            //on meetod mis tahab teada, kui palav õues on: temperatuur
            Console.WriteLine("Mis temperatuur õues on?");
            double misOnTemp = double.Parse(Console.ReadLine());
            KuiPalavOn(100);
            //on meetod, mis arvutab järjendi kõikide elementide keskmise, hoiab muutujas meeles
            // ja kuvab eraldi real välja peaprogrammis, mitte meetodis, meetod ainult tagastab väärtuse
            double scores = ArvutaKeskmine(new List<double> { 3.5, 7.7, 1.1, 5, 8, 9.2 });
            Console.WriteLine("Keskmine on: "+scores);

        }
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
