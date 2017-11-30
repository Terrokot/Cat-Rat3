using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nier_Auto
{
    class Animal
    {
        public int X { get; set; }
        public int Y { get; set; }
        int Speed { get; }

        public Animal(int x, int y, int sp)
        {
            X = x;
            Y = y;
            Speed = sp;
        }

        public static void Hunt(Animal cat, Animal rat)
        {
            Random randX = new Random();
            Random randY = new Random();
            int x = 0;
            int y = 0;
            int count = 0;
            while(!(cat.X==rat.X && cat.Y==rat.Y))
            {
                count++;
                x = randX.Next(1, 5);
                y = randY.Next(1, 5);
                switch (x)
                {
                    case 1:
                        if (cat.X < 100)
                            cat.X += cat.Speed;
                        break;
                    case 2:
                        if(cat.Y<100)
                        cat.Y += cat.Speed;
                        break;
                    case 3:
                        if (cat.X > 0)
                            cat.X -= cat.Speed;
                        break;
                    case 4:
                        if (cat.Y > 0)
                            cat.Y -= cat.Speed;
                        break;
                }
                switch (y)
                {
                    case 1:
                        if (rat.X < 100)
                            rat.X += rat.Speed;
                        break;
                    case 2:
                        if (rat.Y < 100 )
                            rat.Y += rat.Speed;
                        break;
                    case 3:
                        if (rat.X > 0)
                            rat.X -= rat.Speed;
                        break;
                    case 4:
                        if (rat.Y > 0)
                            rat.Y -= rat.Speed;
                        break;


                  

                }
                Console.WriteLine($"{cat.X},{cat.Y}||{rat.X},{rat.Y}");
            }

            Console.WriteLine(count);
            Console.WriteLine("Ham-Ham");
           
        }

    }
}
