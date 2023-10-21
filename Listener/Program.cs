using System;
using System.Text.Json;
using Common;

class Listener
{
    [STAThread]
    static void Main(string[] args)
    {
        string line;
        try
        { 
            StreamReader sr = new StreamReader(Singleton.getInstance().roadf);
            while ((line = sr.ReadLine()) != null)
            {
                Person? json = JsonSerializer.Deserialize<Person>(line);
                Console.WriteLine(json?.memuary);
            }
            sr.Close();
            Console.ReadLine();
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