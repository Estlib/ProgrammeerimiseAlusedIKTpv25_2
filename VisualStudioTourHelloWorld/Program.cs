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
if (tehtetyyp == "-")
{
    tulemus = arv1 - arv2;
}
if (tehtetyyp == "/")
{
    tulemus = arv1 / arv2;
}
if (tehtetyyp == "*")
{
    tulemus = arv1 * arv2;
}
if (tehtetyyp == "*")
{
    tulemus = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine(tulemus);



