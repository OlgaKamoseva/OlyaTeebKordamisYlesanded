namespace General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // #n1. "Tervitus"
            // kirjuta programm mis,
            // - küsib tsükliga kasutajalt tema eesnime
            string eesNimi = string.Empty;
            while (eesNimi == string.Empty)
            {
                Console.WriteLine("Palun sisesta oma nimi siia: ");
                eesNimi = Console.ReadLine();
            }
            // - - küsitakse uuesti tühja sisendi korral
            // - küsib kasutajalt tema keskmist nime
            string keskmineNimi = string.Empty;
            while (keskmineNimi == string.Empty)
            {
                Console.WriteLine("_Palun sisesta oma keskmine nimi siia: ");
                keskmineNimi = Console.ReadLine();
            }
            // - - küsitakse uuesti tühja sisendi korral
            // - küsib kasutajalt tema perekonnanime
            string perekonnaNimi = string.Empty;
            while (perekonnaNimi == string.Empty)
            {
                Console.WriteLine("Palun sisesta oma perekonnanimi siia: ");
                perekonnaNimi = Console.ReadLine();
            }
            // - - küsitakse uuesti tühja sisendi korral
            // - tema vanust
            int minuVanus = 0;
            while (minuVanus < 1)
            {
                Console.WriteLine("Palun sisesta ka oma vanuse siia: ");
                minuVanus = int.Parse(Console.ReadLine());
            }
            // - - küsitakse uuesti tühja sisendi korral
            // - ning väljastab talle tervituslause, kasutades kõiki muutujaid
            Console.WriteLine($"Tere paevast, {eesNimi} {perekonnaNimi}! Voi kutsun sind {keskmineNimi}? Oled tublisti kasvanud, oled juba {minuVanus}-aastane");
            */

            // #n2. "Minu lemmiksnäkk"
            // kirjuta programm mis
            // küsib kasutajalt mis on ta lemmiksnäkk
            // programm kontrollib tsükliga kas järjendis on snäkk olemas
            // kui tsüklis leitakse snäkk, kuva tekst koos kasutajasisendiga, "jaa :D tean seda, {snäkk} on hea"
            // kui tsükkel lõppeb ilma snäkki leidmata, kuva tekst "ei tunne kahjuks {snäkk}i :C"
            /*
            // nimekiri snakkidest
            List<string> snakid = new List<string>() {"pocky","korsikud","snickers","kropsud","popcorn","limonaad" };
            // kasutaja sisestuse jaoks muutuja
            string kasutajaleMeeldib = string.Empty;
            // kas snakk on olemas voi mitte, vaikevaartusena ei ole
            bool isPresent = false;
            // tsukkel mis k'ib niikaua kuni leitakse meeldiv snakk mida programm teab
            while (isPresent != true)
            {
                // kusime kasutajalt infot
                Console.WriteLine("Sisesta oma lemmiksnakk: ");
                kasutajaleMeeldib = Console.ReadLine();

                //kontrollime seda infot
                foreach (var snakk in snakid)
                {
                    //kui leitakse vaste
                    if snakk == kasutajaleMeeldib
                    {
                        //seatakse muutujale vaartus true
                        isPresent = true;
                    }
                }
                //kuvame kasutajale sonumi olenevalt infokontrolli tulemuse tagajarjel
                if (isPresent == true) //kui leitakse, kuvatakse sonum a
                {
                    Console.WriteLine($"jaa :D Tean seda, {kasutajaleMeeldib} on hea");
                }
                else //muidu sonum b
                {
                    Console.WriteLine($"ei tunne kahjuks {kasutajaleMeeldib}i :C");
                }
            }
            */

            // #n3. "Metsataimede välimääraja"
            // kirjuta programm mis
            // küsib kasutajalt kas ta otsib mingit seent või marja (tsüklis)
            // kui seent, siis programm esitab seeneloendis olevad seened
            // ja küsib millise seene kohta infot infojärjendist kuvada
            // tsükkel siis käib ja otsib teisest järjendis seene infot ja kuvab selle
            // kui marja, siis programm esitab marjaloendis olevad marja
            // ja küsib millise marja kohta infot infojärjendist kuvada
            // tsükkel siis käib ja otsib teisest järjendis marja infot ja kuvab selle
            // siis küsitakse kas kasutaja tahab mõne marja kohta veel infot, ning tsükkel jätkub
            // ⭐iseseisvalt lisa juurde puude tuvastamine ⭐
            bool anuddaJuan = true;
            string mida = string.Empty;
            List<string> valikud = new List<string>() { "seent", "marja", "puud"};
            List<string> seeneNimed = new List<string>() { "kukeseen", "puravik", "sitaseen" };
            List<string> seeneInfod = new List<string>() 
            { "Kukeseen on kollane ja naeb valja nagu keegi oleks pasuna maha \nmatnud ning siis mootorrattaga ule soitnud", 
              "Puravik on pealt pruun ja jalg on hele. Siuke ilus punsu", 
              "Sitaseen on pruun, keerlev ja toenaoliselt lahima koera poolt trhtud kingitus" };
            List<string> marjaNimed = new List<string>() { "astelpaju", "muulukas", "maasikas" };
            List<string> marjaInfod = new List<string>()
            { "Astelpaju on kollane, maitseb nagu apelsin ja selle seeme on alfa-suurusega",
              "Kes seda teab milline muulukas valja naeb...",
              "Maasikas on maailma parim mari, kui sa leiad selle metsast, mitte poest" };
            List<string> puuNimed = new List<string>() { "kuusk", "tamm", "vend" };
            List<string> puuInfod = new List<string>()
            { "Kuusk on karvane puu, mis voib sulle haiget teha, aga lohnab imeliselt",
              "Tamm on koige populaarsem perekonnanimi Eestis, sest eestlased on sama tugevad ja kovad kui tammed",
              "Venna poole sa vaatad alt ules, ta on freaking pikk, aga lohnab kohutavalt" };
            while (anuddaJuan == true) //tsükkel käib niikaua kuni kasutaja tahab infot veel saada
            {
                do
                {
                    Console.WriteLine("Kas sa otsid seent, puud voi marja?");
                    mida = Console.ReadLine();
                }
                // while (mida != "seent" || mida != "marja");
                //while (!new List<string>() {"seent","marja").Contains(mida))
                while (!valikud.Contains(mida));
                if (mida == "seent")
                {
                    List<int> seeneValikud = new List<int>() { 1, 2, 3 };
                    int seeneArv = 0;
                    do
                    {
                        Console.WriteLine("Palun vali seen, mille kohta tahad infot, valikus on " + seeneNimed.Count + " tukki");
                        for (int i = 0; i < seeneNimed.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + seeneNimed.ElementAt(i));
                        }
                        seeneArv = int.Parse(Console.ReadLine());
                    }
                    while (!seeneValikud.Contains(seeneArv));

                    Console.WriteLine(seeneInfod.ElementAt(seeneArv - 1));

                }

                else if (mida == "puud")
                {
                    List<int> puuValikud = new List<int>() { 1, 2, 3 };
                    int puuArv = 0;
                    do
                    {
                        Console.WriteLine("Palun vali puu, mille kohta tahad infot, valikus on " + puuNimed.Count + " tukki");
                        for (int i = 0; i < puuNimed.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + puuNimed.ElementAt(i));
                        }
                        puuArv = int.Parse(Console.ReadLine());
                    }
                    while (!puuValikud.Contains(puuArv));

                    Console.WriteLine(puuInfod.ElementAt(puuArv - 1));
                }

                else
                {
                    List<int> marjaValikud = new List<int>() { 1, 2, 3 };
                    int marjaArv = 0;
                    do
                    {
                        Console.WriteLine("Palun vali mari, mille kohta tahad infot, valikus on " + marjaNimed.Count + " tukki");
                        for (int i = 0; i < marjaNimed.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + marjaNimed.ElementAt(i));
                        }
                        marjaArv = int.Parse(Console.ReadLine());
                    }
                    while (!marjaValikud.Contains(marjaArv));

                    Console.WriteLine(marjaInfod.ElementAt(marjaArv - 1));
                }
                string kasutajaOtsus = "";
                do
                {
                    Console.WriteLine("Kas sa tahad veel infot? jah/ei");
                    kasutajaOtsus = Console.ReadLine();
                }
                while (kasutajaOtsus != "jah" && kasutajaOtsus != "ei");
                if (kasutajaOtsus == "jah")
                {
                    anuddaJuan = true;
                }
                else
                {
                    anuddaJuan = false;
                }
            }
            Console.WriteLine("Head aega!"); //kui pohitsükkel katkeb, ütleme "head aega!"


            // #n4. "Stonksid"
            // kirjuta programm mis töötab tsüklis ja omab tehtavat koodi mis:
            // küsib kasutajalt temapoolse investeeritava summa
            // küsib kolme firma kohta millesse ta investeerida soovib (Tesla, TransferWise või Macro$lop)
            // valitud firma kohta otsustab programm kordaja.
            // kui selleks on Tesla, siis on kordaja fikseeritud -1.15
            // kui selleks on TransferWise, siis on kordajaks valemi tuleumus kus juhuarvu abil otsustatakse arv vahemikus 1 ja 100, juhuarv jagatakse 1000ga ja sinna liidetakse 1 juurde
            // kui selleks on Macro$lop, siis kasutatakse sama valemit TransferWise puhul, aga arv ise on alati negatiivne.
            // programm küsib ka kasutajalt kui pikaks ajaks (mitu päeva) investeering turul olla lasta
            // tsükkel kirjutab välja iga päeva kohta firmanime, hetkekordaja, kasutajaportfelliväärtuse
            // kui kasutaja portfell pole jõudnud alla nulli, siis kasutaja saab valida kas investeerida uuesti või mitte
            // kui aga portfell on nullis, öeldakse kasutajale et on pankrotis
            // kuvatakse kasutajale tema portfelli lõppväärtus.
        }
    }
}
