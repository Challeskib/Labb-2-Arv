using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Arv
{
    class Fish : Animal
    {
        //  km/h
        public int SwimSpeed = 0;


        public Fish(string name, string colour, string sex, int age, int weight, int swimSpeed)
        {
            Name = name;
            Colour = colour;
            Sex = sex;
            Age = age;
            Weight = weight;
            SwimSpeed = swimSpeed;

        }

        public Fish()
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Blububububububblbubublub.......blub");
        }


    }
}
