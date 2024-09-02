
Random rnd =new Random();

int x = rnd.Next(1, 101);

Console.WriteLine("Du ska gissa nummret x som är mellan 0-100");
int a;
do{
Console.Write("Gissa: ");
string str = Console.ReadLine();
a = int.Parse(str);

if(a>x){
Console.Write("x är mindre");
Console.WriteLine(" ");
    if(a<=x+10){
        Console.Write()
    }
}
else if(a<x){
    Console.Write("x är större");
    Console.WriteLine(" ");
}

}
while(a != x);


Console.Write("korrekt");
