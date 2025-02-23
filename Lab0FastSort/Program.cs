using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string filePath = "C:\\Users\\Duxfield\\Documents\\Yr2 UCOL\\Programming\\labText.txt";
        string[] tempLines = File.ReadAllLines(filePath);

        int lineLength = tempLines.Length;
        int[] lines = new int[lineLength];

        int i = 0;
        foreach (string tempLine in tempLines)
        {
            lines[i] = Convert.ToInt32(tempLine);
            i++;

        }

        int[] sortedLines = new int[lineLength];
        int loop = -1;

        foreach (int line in lines)
        {
            int sortedLoop = 0;
            loop++;
            
            foreach (int sortedLine in sortedLines)
            {

                if (sortedLine >= line)
                {
                    sortedLines = Sort(sortedLines, sortedLoop, line, loop);
                    break;

                } else if (sortedLoop == loop)
                {
                    sortedLines[sortedLoop] = line;
                    break;

                } else 
                {
                    sortedLoop++;

                }
            }  
        }

        Console.WriteLine("\n\n[{0}]", string.Join(", ", sortedLines));

        stopwatch.Stop();
        TimeSpan elapsed = stopwatch.Elapsed;

        Console.WriteLine($"Time to run: {elapsed.TotalMilliseconds} ms");
        
    }
    public static int[] Sort(int[] array, int index, int newNum, int numSorted)
        {
            int tempStore;
            while (index <= array.Length)
            {
                
                tempStore = array[index];
                array[index] = newNum;
                newNum = tempStore;

                if (numSorted == index){
                    break;
                } 
                index++;
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
            return array;
        }
            
}
