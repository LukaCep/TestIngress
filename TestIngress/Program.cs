using TestIngress;


Console.WriteLine("DNS");
string dns = Console.ReadLine();
Console.WriteLine("Port");
int port = int.Parse(Console.ReadLine());
Console.WriteLine("Poruka");
string message = Console.ReadLine();

UDPSocket klasa = new UDPSocket();

string responseMessage;
bool response = klasa.SendMessage(dns, port, message, out responseMessage);

Console.WriteLine("");
Console.WriteLine(responseMessage);

if (response)
{
    //nesto
}
else
{
    //nesto drugo
}

Console.ReadLine();

/*
ingress.mobilisis.com
5333
*/