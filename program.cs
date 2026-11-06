Console.WriteLine("Nyilvántartási Rendszer");
Console.WriteLine();
Console.Write("Érkezés ideje: ");
DateTime most = DateTime.Now;
Console.WriteLine(most);
Console.Write("Ember (1) vagy Autó (2) érkezett? ");
int tipus = int.Parse(Console.ReadLine());


while(tipus!=1 && tipus != 2)
{
    Console.WriteLine("Helytelen szám, csak 1-est (Személy) vagy 2-es (autó) van nyilvántartásban.");
    Console.Write("Ember (1) vagy Autó (2) érkezett? ");
    tipus = int.Parse(Console.ReadLine());
}   

if (tipus == 1)
{
    Console.Write("Adja meg a személy nevét: ");
    string nev=Console.ReadLine();
    Console.Write("Adja meg a személyi azonosító számát: ");
    string azon=Console.ReadLine();

}

else if (tipus == 2)
{
    Console.Write("Adja meg az autó típusát: ");
    string autotipus = Console.ReadLine();
    Console.Write("Adja meg az autó rendszámát: ");
    string rendszam = Console.ReadLine();

}