namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.Add(70);
            list.Insert_front(30);
            list.Insert_front(56);
            list.Display();

        }
    }
}