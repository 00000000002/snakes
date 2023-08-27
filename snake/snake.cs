using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake
    {
        point tail;
        private static snake instance = null;
        public static snake Instance()
        {
            if (instance==null)
            {
                instance = new snake();
            }
            return instance;
        }


        List<point> body = new List<point>();
        direction dir = direction.right;
        public void update()
        {
            if (game())
            {
                return;
            }
            else
            {
                turn();
                
                move();
                eat();
            }

        }
        public void draw()
        {
            for(int i = 0; i < body.Count; i++)
            {
                point pt = body[i];
                Console.SetCursorPosition(pt.x* 2, pt.y);
                Console.ForegroundColor = i == 0 ? ConsoleColor.DarkMagenta : ConsoleColor.Yellow;
                Console.BackgroundColor = i == 0 ? ConsoleColor.DarkMagenta : ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.BackgroundColor = ConsoleColor.Red;
                Console.Write('●');
            }

        }

        public void star()
        {
            body.Add(new point(2, 2));
            body.Add(new point(2, 3));
            body.Add(new point(2,4));

        }
        private bool game()
        {
            point head = body[0];

            if (map.Instance().getat(head) == map.wall)
            {
                return false;
            }
            for (int i = 1; i < body.Count; i++)
            {
                if (body[i] == head)
                {
                    return true;
                }
                return false;
            }
            throw new NotImplementedException();
        }
        private void turn()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key=Console.ReadKey(true).Key;
                if(key==ConsoleKey.LeftArrow && dir != direction.right)
                {
                    dir = direction.left;
                }
                else if (key == ConsoleKey.RightArrow && dir != direction.left)
                {
                    dir = direction.right;
                }
                else if (key == ConsoleKey.UpArrow && dir != direction.down)
                {
                    dir = direction.up;
                }
                else if (key == ConsoleKey.DownArrow && dir != direction.up)
                {
                    dir = direction.down;
                }

            }

        }
        private void move()
        {

            point offset=new point(0,0);
            switch (dir)
            {
                case direction.left:
                    offset = new point(-1, 0);
                    break;
                case direction.right:
                    offset = new point(1, 0);
                    break;
                case direction.up:
                    offset = new point(0, -1);
                    break;
                case direction.down:
                    offset = new point(0, 1);
                    break;

            }
            point head = body[0];
            head = head + offset;
            body.Insert(0, head);
            tail =body[body.Count - 1];
            body.RemoveAt(body.Count - 1);

        }
        private void eat()
        {
            point head = body[0];
            if (map.Instance().getat(head) == map.Food)
            {
                map.Instance().setat(head, map.Blank);
                body.Add(tail);
                map.Instance().genfood();
                

            }

        }


    }
}
