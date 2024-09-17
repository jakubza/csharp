Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
//Console.WriteLine("Ahoj, " + meno + "\n");

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
//Console.WriteLine("Máš " + vek + " rokov." + "\n");

/*Console.WriteLine("kolko penazi mas na ucte????");
string money = Console.ReadLine() ?? "0";
float peniaze = float.Parse(money);
Console.WriteLine("Máš " + money + " $ GG" + "\n");*/

Console.WriteLine("ake je tvoje oblubene jedlo?");
string? jedlo = Console.ReadLine();
//Console.WriteLine("Hmmmmmmmmm " + jedlo + " znie dobre" );
Console.WriteLine($"Volas sa {meno}, mas {vek} rokov a tvoje oblubene jedlo je {jedlo} ." + "\n");