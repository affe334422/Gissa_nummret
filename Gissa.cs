


Random rnd =new Random();

int x = rnd.Next(1, 101);

Console.WriteLine("Du ska gissa nummret x som är mellan 0-100");
int a;
int gis = 1; //antal gissningar

do{
    Console.WriteLine("Gissa " + gis++ + ": ");
    string str = Console.ReadLine();
    a = int.Parse(str);

if(a>x){
    Console.WriteLine("x är mindre än " + str);

}

else if(a<x){
    Console.WriteLine("x är större än " + str);
    
}

}
while(a != x);


Console.WriteLine("korrekt");
gis--;
Console.WriteLine("Du tog " + gis + " andtal försök");
