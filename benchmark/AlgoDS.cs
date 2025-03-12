namespace AlgoDS.DataStructures
{

    public class LinkedList { 

        public class Node{
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

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
    public class Stack { }
    public class Queue { }
    public class HashTable { }

    public class LinkedList<T> { }
    public class Stack<T> { }
    public class Queue<T> { }
    public class HashTable<K, V> { }


}

namespace AlgoDS.Sorting
{
    public class QuickSort { }
    public class QuickSort<T> { }

}

namespace AlgoDS.Searching
{
    public class LinearSearch {
        public static int Search(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key){
                    return i;
                }
            }
            return -1;
        }
     }
    public class BinarySearch {
        public static int Search(int[] arr, int key)
        {
            int left = 0, right = arr.Length -1;
            while(left <= right){
                int mid = left + (right - left) / 2;
                if (arr[mid] == key) return mid;

                if (arr[mid] < key) 
                {
                    left = mid + 1;
                }
                else right = mid - 1;
            }
            return -1;
            
        }
     }
    public class LinearSearch<T> { }
    public class BinarySearch<T> { }

}