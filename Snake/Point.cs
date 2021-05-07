using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    { /*хранение данных о точке*/
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym) /*конструктор, принимающий значения и затем передающий их в хранящиеся данные*/
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw() /*вывод данных на экран*/
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);         
        }
    }
}
