using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string filePath = "C:\\Users\\Duxfield\\Documents\\Yr2 UCOL\\Programming\\labText.txt";
        string[] lines = File.ReadAllLines(filePath);

        int secondNum;
        int loopNum = 0;
        int lineLength = lines.Length;
        var rng = new Random();

        while (loopNum < lineLength)
        {
            loopNum = 0;
            int firstNum = 0;

            foreach (string line in lines)
            {
                secondNum = Convert.ToInt32(line);

                if (secondNum < firstNum)
                {
                    Console.WriteLine("[{0}]", string.Join(", ", lines));

                    rng.Shuffle(lines);
                    break;

                }
                else
                {
                    firstNum = secondNum;
                    loopNum++;
                }
            }

        }

        Console.WriteLine("\n\n[{0}]", string.Join(", ", lines));
        
        stopwatch.Stop();
        TimeSpan elapsed = stopwatch.Elapsed;

        Console.WriteLine($"Time to run: {elapsed.TotalMilliseconds} ms");
    }
}

static class RandomExtensions
{
public static void Shuffle<T> (this Random rng, T[] array){
    int n = array.Length;
    
    while (n > 1){
        int k = rng.Next(n--);
        T temp = array[n];
        array[n] = array[k];
        array[k] = temp;
    }
}
}


