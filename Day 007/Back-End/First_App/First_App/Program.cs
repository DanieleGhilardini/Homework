using First_App;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
       // Generic<string, DateTime> identità = new();
       // identità.Add("Nome e Cognome", "Data di Nascita", "Daniele Ghilardini", new DateTime(1999, 9, 7));

        Class1 class1 = new Class1();
        class1.Nome = "Daniele";
        class1.Cognome = "Ghilardini";
        class1.Nascita = new DateTime (1999, 9, 7);

        string jsonSerializer = JsonConvert.SerializeObject(class1);

        using (StreamWriter sw = new StreamWriter("DriveDirs.txt"))
        {
            sw.WriteLine(jsonSerializer);
        }

        string readJson;
        using(StringReader sr = new StringReader("DriveDirs.txt"))
        {
            readJson = sr.ReadToEnd();
        }
        Class1 deserializedJson = JsonConvert.DeserializeObject<Class1>(readJson);
    }
}