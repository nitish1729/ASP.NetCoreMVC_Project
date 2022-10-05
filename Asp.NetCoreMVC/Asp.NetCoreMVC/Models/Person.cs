using System;
namespace Asp.NetCoreMVC.Models
{
    public class Person
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string FullName { get; set; } = String.Empty;
        public int age { get; set; }
        public string city { get; set; } = String.Empty;
    }
}
