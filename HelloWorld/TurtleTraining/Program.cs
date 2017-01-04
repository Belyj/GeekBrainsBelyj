using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void WriteT(int size)
        {
            Turtle.Move(size*2);
            Turtle.Angle = 270;
            Turtle.Move (size);
            Turtle.Angle = 90;
            Turtle.Move (size*2);
        }

        static void WriteO()
        {
            for (int i = 0; i < 2; i++)
            {
                Turtle.Move(70);
                Turtle.TurnRight();
                Turtle.Move(40);
                Turtle.TurnRight();
            }
        }

        static void WriteP()
        {
            Turtle.Move(70);
            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(40);
            }

        }
        static void Main(string[] args)
        {
            Turtle.X = 150;
            Turtle.Y = 200;
            WriteT(50);
            Turtle.X = 200;
            Turtle.Y = 200;
            Turtle.Angle = 0;
            WriteO();
            Turtle.X = 270;
            Turtle.Y = 200;
            WriteP();
            Turtle.X = 370;
            Turtle.Y = 200;
            Turtle.Angle = 0;
            WriteT(35);
        }
    }
}
