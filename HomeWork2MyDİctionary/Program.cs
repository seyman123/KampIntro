namespace HomeWork2MyDİctionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Denizli", 20);
            myDictionary.Add("Ankara", 06);

            Console.WriteLine(myDictionary.Count());
        }
    }
}