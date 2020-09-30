using System;

namespace Class_2._1
{
    public class Cat
    {
        String name;


        public Cat()
        {
            name = "cat";
        }

        public Cat(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        // 2.4.2 Static Methods
        public static void makeNoise(String noise)
        {
            if(noise == null) {
                Console.WriteLine("Roar!");
            }
            else
            {
                Console.WriteLine(noise);
            }
        }
                
    }
}
