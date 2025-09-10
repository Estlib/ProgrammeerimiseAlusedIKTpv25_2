/*
int arv1 = 100; // siin on arv 100
float arv2 = 25.5f;
int arv3 = 50;
int tulemus = arv1 + arv3; // siin on tehe
Console.WriteLine("Tulemus: "+tulemus); //kuvame tulemuse välja
Console.WriteLine("https://meet.google.com/xjy-drff-qbf");
string tekst1 = "mingisugune tekst";
string tekst2 = "AM THIRST, gib water"; //kasutajale esitatav tekst
Console.WriteLine(tekst1 + tekst2);
bool thisthing = false; //mingisugune olek
Console.WriteLine(thisthing);
string yourname = Console.ReadLine();
Console.WriteLine("Tere hommikust, õpilane: "+yourname);
*/
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


Console.WriteLine(tulemus);



/* ISESEISEV TUNNI ÜLESANNE: */
/* Kirjuta ka jagamis, korrutamis ning lahutustehted liitmise eeskujul*/

// + liitmine
// / jagamine
// * korrutamine
// - lahutamine
