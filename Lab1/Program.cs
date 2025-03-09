using System.Globalization;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        //class methods
        Person Jack = new Person("Jack", 24, [null]);
        Person Perry = new Person("Perry", 14, [null]);
        Person Duxfield = new Person("Duxfield", 39, [null]);
        Person Sarah = new Person("Sarah-jane", 54, [Jack, Perry, Duxfield]);

        Sarah.DisplayInfo();

        //Array methods
        int[] numbers = [1,2,3,4,5];

        PrintArray(numbers);
        int bigNum = MaxValue(numbers);

        Console.WriteLine("\nMax Value = " + bigNum +"\n");

        int[,] arrMatrix = null;
        bool matrixLoop = true;
        do{
            Console.Write("\nWould you like to add to array? y/n: ");
            string newMatrix = Console.ReadLine();
            switch (newMatrix){
                case "y":
                arrMatrix = CreateMatrix(numbers);
                matrixLoop = false;
                break;

                case "n":
                matrixLoop = false;
                break;

                default:
                Console.WriteLine("\nPlease answer y or n\n");
                break;

        }
        } while (matrixLoop);

        if (arrMatrix != null){
            PrintMatrixArray(arrMatrix);
        }else{
            PrintArray(numbers);
        }

        //List methods using numbers array
        LinkedList newList = new LinkedList();
        newList.Add(1);
        newList.Add(2);
        newList.Add(3);
        newList.Add(4);
        newList.Add(5);
        newList.Add(6);
        newList.PrintList();

        newList.Delete(4);

        newList.PrintList();

    }


    //for matrix/array printing

    public static void PrintArray(int[] arr){
        for (int i = 0; i < 5; i++){
            Console.Write($"arr[i].ToString()");
        }   
        Console.WriteLine("\n\n"); 
    }

    public static void PrintMatrixArray(int[,] arr){
        int i = 0;
        Console.Write("\n[");
        do {
            for (int x = 0; x<5; x++){    
            Console.Write($"{arr[i,x].ToString()}");
            if (x<4) Console.Write(", ");
            }
            i++;
        }  while (i<2);
        Console.Write("]\n\n"); 
    }
    

    public static int MaxValue(int[] arr){
        return arr.Max();
    }

    public static int[,] CreateMatrix(int[] arr){

        int[,] arrMatrix = new int[5,5];
        
        Console.WriteLine("Write 5 numbers you wish to store");

        for (int i = 0; i < 5; i++){
            arrMatrix[0,i] = arr [i];

            while(true){
                try{
                    arrMatrix[1,i] = Int32.Parse(Console.ReadLine());
                    break;
                }catch (FormatException){
                    Console.WriteLine("Write a number.");
                }
            }
        }
        return arrMatrix;
    }
}

public class Node{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}


public class LinkedList{
    private Node head;

    public void Add(int data){
        Node newNode = new Node(data);
        //checks to see if first
        if (head == null)
        {
            head = newNode;
        } else
        {
            //makes current node the first node
            Node current = head;
            //checks to see if is the last node, if not sets the current node to the next node.
            //essentially just a foreach loop to find the last node.
            while (current.Next != null)
            {
                current = current.Next;
            }

            //when at last node sets the next node to the new data
            current.Next = newNode;
        }
    }

    public void PrintList(){
        Node current = head;
        while( current != null){
            Console.WriteLine(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("List End\n\n");
    }

    public void Delete(int num){
        Node current = head;
        Node previous = head;
        while (current != null){

            //checks if the data = data we are looking for
            //Changes the previous list link to go to the next link of this chain skipping deleted node
            //sets deleted node to 0/null
            if (current.Data == num){
                previous.Next = current.Next;

                current.Data = 0;
                current.Next = null;
                break;

            }
            previous = current;
            current = current.Next;
        }
    }
}


public class Person {
    private string name;
    public string Name
    {
        get{ return name;}
        set{name = value;}
    }
    private int age;
    public int Age
    {
        get{ return age;}
        set{Age = value;}
    }
    private Person?[] children;
    public Person?[] Children
    {
        get{ return children;}
        set{children = value;}
    }

    public Person(string newName, int newAge, Person?[] newChildren) {
        name = newName;
        age = newAge;
        children = newChildren;
    }

    public void DisplayInfo(){
        Console.WriteLine("Name: " + Name + " \nAge: " + Age);
        if (Children[0] != null){ 
            Console.WriteLine("Number of children: " + Children.Length);
            foreach (Person? Child in Children){
                if (Child != null){
                    Console.Write("Childs info: ");
                    Child.DisplayInfo();
                }
            }
            
        }
    }


}

/*
Question 1: When searching/inserting/deleting large amounts of information as list take less time to 
find and make these changes compared to arrays


Question 2: Each node can be located anywhere in memory as it can be located by pointers but need more storage due to the extra pointers
Arrays must be stored contiguously in the same area of storage or you will not be able to find parts of the array.

*/

