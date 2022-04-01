namespace Place.Utilities;

public interface IKeyGenerator
{
    int Generate { get; }
}

public class SimpleKeyGenerator : IKeyGenerator
{
    private int id = 0;

    public int Generate
    {
        get
        {
            Interlocked.Increment(ref id);
            Console.WriteLine(id);
            return id;
        }
    }
}