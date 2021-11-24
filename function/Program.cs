using System;

namespace function
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals("sag");
            animals.NamudiHayvon("sag");
            string functionText = Convert.ToString(animals.Hayvon(12, "gurba"));
            Console.WriteLine(functionText);
            Console.WriteLine(animals.Hayvon(12, "gurba").Name);
            Console.ReadLine();
        }
    }
}
