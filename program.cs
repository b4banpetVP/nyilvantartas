using System.ComponentModel.Design;
using System.Text;

Console.WriteLine("Nyilvántartási Rendszer");

while (true)
{
    Console.WriteLine();
    Console.Write("Érkezőt rögzítessz (1), keresel (2) vagy kilépsz (0)? ");
    string valasztas = Console.ReadLine();
    if (int.TryParse(valasztas, out int value))
    {
        int menu = int.Parse(valasztas);



        if (menu == 0)
        {
            break;
        }

        while (menu != 1 && menu != 2 && menu != 0)
        {
            Console.WriteLine("Helytelen szám");
            break;
        }


        if (menu == 1)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Nyilvántartás");
                string most = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Console.WriteLine($"Érkezés ideje: {most}");
                Console.Write("Ember (1) vagy Autó (2) érkezett vagy kilépsz (0)? ");
                string tipus_ie = Console.ReadLine();

                if (int.TryParse(tipus_ie, out int value2))
                {
                    //ellenorzes
                    int tipus = int.Parse(tipus_ie);
                    if (tipus == 0)
                    {
                        break;
                    }
                    //ellenorzes

                    //Rossz szam
                    while (tipus != 1 && tipus != 2)
                    {
                        Console.WriteLine("Helytelen szám, csak 1 (Személy) vagy 2 (autó) van nyilvántartásban.");
                        Console.Write("Ember (1) vagy Autó (2) érkezett? ");
                        tipus = int.Parse(Console.ReadLine());
                    }
                    string path = "nyilvantartas.csv";
                    //Rossz szam

                    //ember
                    if (tipus == 1)
                    {
                        Console.Write("Adja meg a személy nevét: ");
                        string nev = Console.ReadLine();
                        Console.Write("Adja meg a személyi azonosító számát: ");
                        string azon = Console.ReadLine();
                        using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                            sw.WriteLine($"{most};{nev};{azon}személy");
                    }
                    //ember

                    //jarmu
                    else if (tipus == 2)
                    {
                        Console.Write("Adja meg az autó típusát: ");
                        string autotipus = Console.ReadLine();
                        Console.Write("Adja meg az autó rendszámát: ");
                        string rendszam = Console.ReadLine();
                        using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                            sw.WriteLine($"{most};{autotipus};{rendszam};jármű");
                    }
                    //jarmu

                }
                //str int helyett
                else { Console.WriteLine("Szöveget nem adhatsz meg!"); }
            }
        }


        else if (menu == 2)
        {
            if (File.Exists("nyilvantartas.csv"))
            {
                Console.WriteLine("Keresés");
                Console.WriteLine();
                Console.Write("Adjon meg egy információt: ");
                string info = Console.ReadLine();
                string inform = info.ToLower();

                bool benne = false;

                foreach (string sor in File.ReadLines("nyilvantartas.csv"))
                {
                    if (sor.ToLower().Contains(inform))
                    {
                        benne = true;
                        Console.WriteLine(sor);
                    }
                }

                if (!benne)
                {
                    Console.WriteLine("Nincs rögzitve ilyen információ!");
                }
            }
            else
            {
                Console.WriteLine("Még üres a nyilvántartás.");
            }
        }

    }
    //str int helyett
    else { Console.WriteLine("Szöveget nem adhatsz meg!"); }
}