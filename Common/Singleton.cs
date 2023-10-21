using System.Threading.Tasks.Dataflow;

namespace Common;

public class Singleton
{
    private static Singleton? instance;

    private Singleton()
    { }

    public string roadf { get; private set; } = "C:\\Users\\z0nde\\Desktop\\Common_Lister.txt";

    public static Singleton getInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}