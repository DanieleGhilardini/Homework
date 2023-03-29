using Esercizio;

internal class Program
{
    private static void Main(string[] args)
    {
        Carta_ID id = new Carta_ID();
        id.Nome = "Daniele";
        (id.Nome).All(char.IsDigit)
    }
}