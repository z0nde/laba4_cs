using laba4_cs;
using System.Text.Json;
using Common;

class Produscer
{
    public static void Main()
    {
        Person Art = new Person("This is work of art");
        Person egvweg = new Person("Z");
        try
        {
            StreamWriter sw = new StreamWriter(Singleton.getInstance().roadf);
            string json = JsonSerializer.Serialize(Art);
            string json2 = JsonSerializer.Serialize(egvweg);
            sw.WriteLine(json);
            sw.WriteLine(json2);
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}