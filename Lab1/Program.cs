using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int[] numbers = [1,2,3,4,5];

        PrintArray(numbers);
        int bigNum = MaxValue(numbers);

        Console.WriteLine("Max Value = " + bigNum);
    }

    public static void PrintArray(int[] arr | int[,] arrMatrix ){
        for (int i = 0; i < 5; i++){
            Console.Write(arr[0,i].ToString());
        }   
        Console.WriteLine(); 
    }

    public static int MaxValue(int[] arr){
        return arr.Max();
    }

    public static void CreateMatrix(int[] arr){

        int[,] arrMatrix = new int[5,5];
        
        Console.WriteLine("write 5 numbers you wish to store");

        for (int i = 0; i < 5; i++){
            arrMatrix[0,i] = arr [i];

            while(true){
                try{
                    arrMatrix[1,i] = Int32.Parse(Console.ReadLine());
                    break;
                }catch (FormatException){
                    Console.WriteLine("Write a fucking number.");
                }
            }

        }





         
    }
}