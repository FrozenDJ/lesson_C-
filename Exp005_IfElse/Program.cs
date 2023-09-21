Console.WriteLine("Write your name: ");
string username = Console.ReadLine ();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hey, it's dear MASHA");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}