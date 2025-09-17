Console.WriteLine("Tere. Sisesta esimene arv");
int arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere. Sisesta teine arv");
int arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Sisesta tehtemärk: / * + -");
string tehtetyyp = Console.ReadLine();

int tulemus = 0;
if (tehtetyyp == "+") 
{    
    tulemus = arv1 + arv2;
}
else if (tehtetyyp == "-")
{
    tulemus = arv1 - arv2;
}
else if (tehtetyyp == "/")
{
    tulemus = arv1 / arv2;
}
else if (tehtetyyp == "*")
{
    tulemus = arv1 * arv2;
}
else if (tehtetyyp == "*")
{
    tulemus = (int)Math.Pow(arv1, arv2);
}
else
{
    Console.WriteLine("Palun sisesta tehe, mida kalkulaator tuvastada oskab");
}

if (tulemus != 0)
{
    Console.WriteLine(tulemus);
}
else
{
    Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
}
Console.WriteLine("Kas sa tahad õuna või banaani?");
string vastus = Console.ReadLine();
if (vastus == "õuna")
{
    Console.WriteLine("õun, palun: 🍎🍏");
}
else if (vastus == "banaani")
{
    Console.WriteLine("banaan, palun: 🍌🍌🍌🍌🍌");
}
else 
{
    Console.WriteLine("Sellist puuvilja ma ei tunne");
};


