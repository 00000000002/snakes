using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class map
    {
        private static map instance = null;
        public static map Instance()
        {
            if (instance == null)
            {
                instance = new map();
            }
            return instance;
        }
        public const int Blank = 0;
        public const int wall = 1;
        public const int Food = 2;
        private Random rnd = new Random();
        public void genfood()
        {
            point pt;
            for(; ; )
            {
                pt.x = rnd.Next(map0.GetLength(1));
                pt.y = rnd.Next(map0.GetLength(0));
                if (getat(pt) == map.Blank)
                {
                    map0[pt.y, pt.x] = map.Food;
                    return;
                }
            }
        }



        int[,] map0 = new int[20, 20]
        {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },

        };



        public void star()
        {
            genfood();

        }
        public int getat(point pt)
        {
           
            return map0[pt.y, pt.x];
            
                
            
        }

        public void setat(point pt,int value)
        {
            map0[pt.y, pt.x] = value;

        }
      

        public void update()
        {

            
        }
        public void Draw()
        {
            for(int i = 0; i < map0.GetLength(0); i++)
            {
                for (int j = 0; j < map0.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * 2, i);
                    switch (map0[i, j])
                    {
                        case map.wall:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write('●');
                            break;
                        case map.Food:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write('●');
                            break;

                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write('　');
                }
            }
            
        }
        
    }
}
