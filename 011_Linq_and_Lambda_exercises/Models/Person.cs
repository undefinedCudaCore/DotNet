﻿namespace _011_Linq_and_Lambda_exercises.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Pet> Pets { get; set; }

        public Person()
        {
            Pets = new List<Pet>();
        }
    }
}
