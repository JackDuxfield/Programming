using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        bool random = true;
        int[] trashArray = GetArray(random);

        foreach (int num in trashArray){
            RandomNumbers.Items.Add(num);
        }

    }

    public static int[] GetArray(bool random){
        string filePath = "C:\\Users\\Duxfield\\Documents\\Yr2 UCOL\\Programming\\labText.txt";
        string[] tempLines = File.ReadAllLines(filePath);

        int lineLength = tempLines.Length;
        int[] lines = new int[lineLength];

        int i = 0;
        foreach (string tempLine in tempLines)
        {
            if (int.TryParse(tempLine.Trim(), out lines[i]))
            {
                i++;
            }            

        }
        return lines;
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
            return array;
        }
    private void ButtonSortNumbers_Click(object sender, RoutedEventArgs e)
    {
        bool random = false;
        int[] lines = GetArray(random);

        int[] sortedLines = new int[lines.Length];
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

        foreach (int sortedLine in sortedLines){
            SortedNumbers.Items.Add(sortedLine);
        }
    }
}