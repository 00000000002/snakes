using System;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            snake.Instance().star();
            map.Instance().star();
            for(; ; )
            {
                map.Instance().update();
                snake.Instance().update();
                map.Instance().Draw();
                snake.Instance().draw();
                Thread.Sleep(1000);
          
            }
        }
         
        
    }
}
