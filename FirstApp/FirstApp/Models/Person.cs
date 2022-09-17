using System;
namespace FirstApp.Models
{
    public class Person
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string Location { get; set; } = String.Empty;
        public void NaturalNumber()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
