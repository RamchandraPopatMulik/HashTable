namespace HashTable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<int, string> myMapNode = new MyMapNode<int ,string>(6);
            myMapNode.Add(0,"To");
            myMapNode.Add(1,"be");
            myMapNode.Add(2,"or");
            myMapNode.Add(3,"not");
            myMapNode.Add(4,"to");
            myMapNode.Add(5,"be");
            myMapNode.Get(0);
            myMapNode.Get(1);
            myMapNode.Get(2);
            myMapNode.Get(3);
            myMapNode.Get(4);
            myMapNode.Get(5);
            Console.WriteLine("The Added Statement is :: ");
            for(int i=0;i< myMapNode.array.Length;i++)
            {
                Console.WriteLine($"{myMapNode.array[i]}");
            }
            Console.WriteLine("Frequency of Words is : ");
            myMapNode.FrequencyOfWords(myMapNode.array,myMapNode.array.Length);
        }
    }
}