namespace HashTable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<int, string> myMapNode = new MyMapNode<int ,string>(19);
            myMapNode.Add(0,"Paranoids");
            myMapNode.Add(1,"are");
            myMapNode.Add(2,"not");
            myMapNode.Add(3,"paranoid");
            myMapNode.Add(4,"because");
            myMapNode.Add(5,"they");
            myMapNode.Add(6, "are");
            myMapNode.Add(7, "paranoid");
            myMapNode.Add(8, "but");
            myMapNode.Add(9, "because");
            myMapNode.Add(10, "they");
            myMapNode.Add(11, "keep");
            myMapNode.Add(12, "putting");
            myMapNode.Add(13, "themselves");
            myMapNode.Add(14, "deliberately");
            myMapNode.Add(15, "into");
            myMapNode.Add(16, "paranoid");
            myMapNode.Add(17, "avoidable");
            myMapNode.Add(18, "situations");
           
           
            myMapNode.Get(0);
            myMapNode.Get(1);
            myMapNode.Get(2);
            myMapNode.Get(3);
            myMapNode.Get(4);
            myMapNode.Get(5);
            myMapNode.Get(6);
            myMapNode.Get(7);
            myMapNode.Get(8);
            myMapNode.Get(9);
            myMapNode.Get(10);
            myMapNode.Get(11);
            myMapNode.Get(12);
            myMapNode.Get(13);
            myMapNode.Get(14);
            myMapNode.Get(15);
            myMapNode.Get(16);
            myMapNode.Get(17);
            myMapNode.Get(18);
         


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