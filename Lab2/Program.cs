using System;
using System.Web;
internal class Program
{
    private static void Main(string[] args)
    {
        //Queue example
        Console.WriteLine("Queue example");
        IntQueue queue = new IntQueue(5);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine(queue.Peek());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Peek());

        //Stack acts the same as a queue but is LIFO rather than FIFO
        Console.WriteLine("\n\nStack Example");
        IntStack stack = new IntStack(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());

        //Hash Table Example
        Console.WriteLine("\n\nHash Example");
        SimpleHashTable hashTable = new SimpleHashTable();
        hashTable.Insert("Alice", 25);
        hashTable.Insert("Bob", 30);
        hashTable.Insert("Bbo", 29);
        Console.WriteLine(hashTable.GetValue("Alice"));
        Console.WriteLine(hashTable.GetValue("Bbo"));
        Console.WriteLine(hashTable.GetValue("Bob"));

        // Generic Class Example
        Console.WriteLine("\n\nGeneric class example");
        Box<int> intBox = new Box<int>(10);
        Box<string> strBox = new Box<string>("Hello");
        Console.WriteLine(intBox.Value);
    }

}

//Simple queue implementaion

public class IntQueue
{
    private int[] elements;
    private int size;

    //Initialise a new queue with the capacity of the array as an input
    public IntQueue(int capacity)
    {
        elements = new int[capacity];
        size = 0;
    }

    //Add item to the end of the queue after checking if the array is full
    public void Enqueue(int item)
    {
        if (size == elements.Length)
        {
            throw new InvalidOperationException ("Queue is full");
        }
   
        elements[size] = item; //add item at the end
        size++;
    }

    //Takes the first item out of the queue
    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException ("Queue is Empty");
        }

        int item = elements[0]; //get first item

        //Shift all elements to the left
        for (int i = 1; i < size; i++)
        {
            elements [i-1] = elements [i];
        }

        size--; //reduce the size
        return item;
    }

    //Shows the next item in queue
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is Empty");
        }

        return elements[0]; //return next item in queue
    }

    public bool IsEmpty()
    {
        return size == 0;
    }
}

public class IntStack
{
    private int[] elements;
    private int size;

    //Initialise a new stack with the capacity of the array as an input
    public IntStack(int capacity)
    {
        elements = new int[capacity];
        size = 0;
    }

    //Add item to the top of the stack after checking if the stack is full
    public void Push(int item)
    {
        if (size == elements.Length)
        {
            throw new InvalidOperationException ("Queue is full");
        }
   
        elements[size] = item; //add item at the top
        size++;
    }

    //Takes the top item out of the stack
    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException ("Queue is Empty");
        }

        int item = elements[size -1]; //get top item

        elements[size] = 0;

        size--; //reduce the size
        return item;
    }

    //Shows the top item in stack
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty");
        }

        return elements[size -1]; //return top item in the Stack
    }

    public bool IsEmpty()
    {
        return size == 0;
    }
}



//Hash has fast data lookups as it creates a hash with "key"/data which is has a 
// modulus(remainder) operator applied then used as the index.
//When the data is looked for It simply recreates the hash which recreates the index.
public class SimpleHashTable 
{
    private int size = 10; //This table has constant size but could take user input
    private string[] keys;
    private int[] values;

    public SimpleHashTable()
    {
        keys = new string[size]; //Stores keys
        values = new int[size]; //Stores Values
    }

    private int GetHash(string key)
    {
        int hash = 0;
        foreach (char c in key)
        {
            hash += c;
        }
        // modulo % ensures has within range of indicies
        return hash % size;
    }

    public void Insert(string key, int value)
    {
        int index = GetHash(key);

        // If the key matches, overwrite the value
        do{
            if (keys[index] == key || keys[index] == null)
            {
                keys[index] = key;
                values[index] = value;
            }else{
                //if index has a different key & not null skip 2 slots and try again.
                //if index will loop if exceeding length.

                if (index > keys.Length -4){
                    index -= keys.Length;
                }
                index += 3;

            }
            //if index has a different key & not null skip 2 slots and try again.
            //if index will loop if exceeding length.
            
         
        } while (keys[index] != key);
    }

    public int? GetValue(string key)
    {
        //gets hash from key
        int index = GetHash(key);

        //loop until the key entered is the same as the key in the array
        //checks every 3rd slot
        while(keys[index] != key)
        {
            if (index > keys.Length - 4){
                index -= keys.Length;
            }
            index += 3;
        } 
        //returns correct value evene with hash collisions
        return values[index];

    }
}

//Generic classes 
//*can put anything in the box but have to 
// be ready for anything to come out*

public class Box<T> 
{
    public T Value { get; set; }
    public Box(T value) {Value = value; }
}



