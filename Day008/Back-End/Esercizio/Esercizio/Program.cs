using Esercizio;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Carta_ID id = new Carta_ID();
        id.Nome = "Daniele";
        id.Cognome = "Ghilardini";
        id.CittaResidenza = "Albino";
        id.DataNascita = new DateTime(1999, 9, 7);
        id.Sesso = 'M';
        id.Statura = 190;

        string jsonSerializer = JsonConvert.SerializeObject(id);

        using (StreamWriter sw = new StreamWriter("DriveDirs.txt"))
        {
            sw.WriteLine(jsonSerializer);
        }

        string readJson;
        using (StringReader sr = new StringReader("DriveDirs.txt"))
        {
            readJson = sr.ReadToEnd();
        }
        Carta_ID deserializedJson = JsonConvert.DeserializeObject<Carta_ID>(readJson);
        Console.ReadKey();
    }
}