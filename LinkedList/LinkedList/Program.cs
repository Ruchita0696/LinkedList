namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Insert_front(30);
            list.Insert_front(70);
            list.Display();

        }
    }
}