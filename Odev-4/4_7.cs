Console.WriteLine(YaşBüyüklüğü());
Console.WriteLine(YaşBüyüklüğü(18));
Console.WriteLine(YaşBüyüklüğü(30));

static int YaşBüyüklüğü(int Yaş = 18)
{
    return Yaş - 18;
}