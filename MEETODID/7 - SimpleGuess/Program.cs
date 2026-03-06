namespace _7___SimpleGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lisa juurde raha muutuja ja kolm eventi mis muudavad raha seisu
             */
            /*
             * Lisa juurde veritsemine
             * Selle jaoks on vaja booleani, mis maletab kas sa veritsed voi mitte
             * Ning peale igat eventi, on teine, taisarvu muutuja, mis maletab palju uhest elust alles on, peale igat eventi voetakse maha 10st punkt, ja kui summa on 0, siis voetakse maha 1 elu
             * Lisa uks event mis tervendab veritsemise, lisa veritsemisomadus juurde nendele olukordadele kus kasutaja ka tavaliselt elusid kaotab
             */
            int raha = 10;
            int elud = 3;
            int veriJaak = 10;
            bool veritsemine = false;
            List<string> seljaKott = new List<string>();
            Random juhuArv = new Random(); 
            string mängijaMängib = "jah"; 
            do 
            {
                do
                {
                    Console.Clear();
                    int järgmineEvent = juhuArv.Next(1, 7);
                    switch (järgmineEvent)
                    {
                        case 1:
                            Console.WriteLine("Kõnnid külatee peal ja vastu tuleb elukas.");
                            Stats(raha, elud, seljaKott, veritsemine);
                            Tuple<Random, int, List<string>, int, bool> data3 = new Tuple<Random, int, List<string>, int, bool>(juhuArv, elud, seljaKott, raha, veritsemine);
                            data3 = KratiM6istatus(data3);
                            raha = data3.Item4;
                            elud = data3.Item2;
                            seljaKott = data3.Item3;
                            veritsemine = data3.Item5;
                            break;
                        case 2:
                            Console.WriteLine("Kõnnid külatee peal ja vastu tuleb nõid.");
                            Stats(raha, elud, seljaKott, veritsemine);
                            elud = Nõid(juhuArv, elud);
                            break;
                        case 3:
                            Console.WriteLine("Kõnnid metsas ja vastu tuleb seen.");
                            Stats(raha, elud, seljaKott, veritsemine);
                            elud = Seen(juhuArv, elud);
                            break;
                        case 4:
                            Console.WriteLine("Kõnnid tänaval ja näed maas midagi helkimas:");
                            Stats(raha, elud, seljaKott, veritsemine);
                            seljaKott = Nuga(seljaKott);
                            break;
                        case 5:
                            Console.WriteLine("Kõnnid mööda teed ja midagi tuleb ette.");
                            Stats(raha, elud, seljaKott, veritsemine);
                            List<int> data = new List<int> { raha, elud };
                            data = Mätas(data);
                            raha = data[0];
                            elud = data[1];
                            break;
                        case 6:
                            Console.WriteLine("Kõnnid poetänaval ja ette tuleb vanakraami pood, astud sisse ja näed:");
                            Stats(raha, elud, seljaKott, veritsemine);
                            Tuple<int, List<string>> data2 = new Tuple<int, List<string>>(raha, seljaKott);
                            data2 = Pood(data2);
                            raha = data2.Item1;
                            seljaKott = data2.Item2;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("\nVajuta ükskõik mis klahvi et jätkata");
                    Console.ReadLine();
                } while (elud > 0);

                if (elud <= 0)
                {
                    Console.WriteLine("--== Kas soovid uuesti mängida, sul on elusi 0 ==--");
                    mängijaMängib = Console.ReadLine();
                    if (mängijaMängib == "jah")
                    {
                        elud = 3;
                    }
                }

            } while (mängijaMängib == "jah");
        }

        private static Tuple<int, List<string>> Pood(Tuple<int, List<string>> data2)
        {
            List<string> seljaKott = data2.Item2;
            int rahakott = data2.Item1;
            List<string> riiul = new List<string>()
            {
                "katkine saabas",
                "mingi lambipirn",
                "DDR5 32GB 2x16 kit",
                "Juustukera",
                "Kotitäis lambasoolikaid"
            };
            List<int> hinnad = new List<int>()
            {
                1000,
                12,
                1600,
                3,
                -6,
            };
            for (int i = 0; i < riiul.Count; i++)
            {

                Console.WriteLine($"Riiulil paistab {riiul[i]} ning see maksab {hinnad[i]}.");
                Console.WriteLine("Kas sa tahad seda osta? (jah/ei)");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    if (hinnad[i] < rahakott)
                    {
                        seljaKott.Add(riiul[i]);
                        rahakott -= hinnad[i];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sul pole piisavalt raha selle jaoks, vaata midagi muud.");
                    }
                }
                else
                {
                    Console.WriteLine("Vaatad järgmist asja");
                }

            }
            Console.WriteLine("Lahkusid poest");
            return new Tuple<int, List<string>>(rahakott, seljaKott);

        }

        private static void Stats(int moni, int elud, List<string> seljaKott, bool verin)
        {
            Console.WriteLine("Sul on alles " + elud + " elu.");
            Console.WriteLine("Sul on rahakotis " + moni + " raha.");
            Console.WriteLine("Sul on seljakotis " + seljaKott.Count + " asja.");
            string sisu = "";
            foreach (string s in seljaKott)
            {
                sisu += s + ", ";
            }
            Console.WriteLine("Seljakotis on:" + sisu);
            if (verin = true)
            {
                Console.WriteLine("Sul voolab verd, otsi plaastri");
            }
            else
            {
                Console.WriteLine("Oled terve ja ilus");
            }

        }

        private static List<int> Mätas(List<int> datas)
        {
            int moni = datas[0];
            int elud = datas[1];
            Console.WriteLine("Kõnnid mööda teed, ja vastu tuleb huvtava kujuga põlvekõrgune mätas");
            Console.WriteLine("Mätas on keset teed ees, ei saa ei üle ega ümber sest oled laisk, mida teed?");
            Console.WriteLine("1 - ronin üle\n2 - kaevan lahti\n3 - pööran ringi ja lähen tagasi");
            Console.WriteLine("kirjuta vastava valiku number");
            string vastus = Console.ReadLine();
            switch (vastus)
            {
                case "1":
                    Console.WriteLine("Ronid mättast üle, ja jätkad oma teed");
                    break;
                case "2":
                    moni += 5;
                    Console.WriteLine("Kaevasid mätta lahti, ja leidsid väikese rahapaja, seal oli viis münti.");
                    break;
                default:
                    Console.WriteLine("Hakkasid kannapealt ringi pöörama, kui sellel hetkel kargas mätta\n" +
                        "tagant tuttav kratt, ja peksis sind natuke, kaotasid ühe elu.");
                    elud -= 1;
                    break;
            }

            return new List<int> { moni, elud };
        }

        private static List<string> Nuga(List<string> seljaKott)
        {
            Console.WriteLine("Leiad maast noa, ta on verine, kas sa võtad selle üles?:");
            string vastus = Console.ReadLine();
            if (vastus == "jah")
            {
                Console.WriteLine("Panid noa seljakotti");
                seljaKott.Add("nuga");
            }
            else
            {
                Console.WriteLine("Kõndisid minema, las politsei uurib");
            }
            return seljaKott;
        }

        private static int Seen(Random juhuArv, int elud)
        {
            int seeneEffekt = juhuArv.Next(-4, 4);
            Console.WriteLine("Leiad seene, kas tahad seda maitsta?:");
            string vastus = Console.ReadLine();
            if (vastus == "jah")
            {
                if (seeneEffekt >= 0)
                {
                    Console.WriteLine("Seen maitses hästi, said juurde " + seeneEffekt + " elu.");
                    return elud + seeneEffekt;
                }
                else
                {
                    Console.WriteLine("Kurat, sitaseen oli, tunned ennast väga pahasti ja kaotasid " + (-seeneEffekt) + " elu.");
                    return elud + seeneEffekt;
                }
            }
            else
            {
                Console.WriteLine("Jätad seene maha nagu oma abusivi eksi.");
                return elud;
            }
        }

        private static int Nõid(Random juhuArv, int elud)
        {
            Console.WriteLine("NYEH! Oled eksinud minu koju! Mis sul - sissetungijal - öelda on!!!");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() == "palun vabandust")
            {
                Console.WriteLine("No olgu, eks sa mine siis...");
                return elud;
            }
            else if (vastus.ToLower() == "tahtsin sulle kooki tuua")
            {
                Console.WriteLine("Oi aitäh, anna sulle ühe elu selle koogi vastu");
                return elud + 1;
            }
            else
            {
                Console.WriteLine("MISASJA!?!?!?? KUIDAS SA JULGED?!?! KÄI ISE " + vastus);
                return elud - 1;
            }
        }

        private static Tuple<Random, int, List<string>, int, bool> KratiM6istatus(Tuple<Random, int, List<string>, int, bool> data)
        {
            Random juhuArv = data.Item1;
            int seeJuhuArv = juhuArv.Next(1, 10);
            int elud = data.Item2;
            List<string> seljaKott = data.Item3;
            int moni = data.Item4;
            bool verin = data.Item5;

            if (!seljaKott.Contains("nuga"))
            {
                Console.WriteLine("Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!"); //flavourtext
                Console.WriteLine("Arva:"); 
                int kasutajaArv = int.Parse(Console.ReadLine());

                if (seeJuhuArv == kasutajaArv) 
                {
                    Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*");
                }
                else
                {
                    Console.WriteLine("HJEHJEHJEH - õige vastus oli" + seeJuhuArv + "!!!! sa kaotasid!");
                    elud -= 1;
                    verin = true;
                }
            }
            else
            {
                Console.WriteLine("Vastu tuleb kuri kratt, aga sul on nuga. Kratt ütleb:");
                Console.WriteLine("\"Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!\"");
                Console.WriteLine("Mida sa teed? Kas vastad (1) või ründad noaga (2)?");
                string vastus = Console.ReadLine();
                if (vastus == "1")
                {
                    Console.WriteLine("Arva:"); 
                    int kasutajaArv = int.Parse(Console.ReadLine());

                    if (seeJuhuArv == kasutajaArv) 
                    {
                        Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); 
                    }
                    else
                    {
                        Console.WriteLine("HJEHJEHJEH - õige vastus oli" + seeJuhuArv + "!!!! sa kaotasid!");
                        elud -= 1;
                        verin = true;
                    }
                }
                else
                {
                    Console.WriteLine("Lõikasid krati lõhki, ta maost voolas välja 25 münti!\nAga nuga murdus...");
                    moni += 25;
                    seljaKott.Remove("nuga");
                }
            }
            return new Tuple<Random, int, List<string>, int, bool>(juhuArv, elud, seljaKott, moni, verin);
        }
    }
}
