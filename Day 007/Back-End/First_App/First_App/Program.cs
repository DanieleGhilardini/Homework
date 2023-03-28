using First_App;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

internal class Program
{
    private static void Main(string[] args)
    {
        Generic<string, DateTime> identità = new();
        identità.Add("Nome e Cognome", "Data di Nascita", "Daniele Ghilardini", new DateTime(1999, 9, 7));

        ClassToSerialize c = new ClassToSerialize();
        File f = new File("temp.dat");
        Stream s = f.Open(FileMode.Create);
        BinaryFormatter b = new BinaryFormatter();
        b.Serialize(s, c);
        s.Close();
    }
}