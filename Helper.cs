using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal static class Helper
    {
        internal static int ReadValueAsInt(int sVal, int eVal, string message)
        {
            int val = -1;
            while (!(val >= sVal && val <= eVal))
            {
                try
                {
                    val = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(message);
                }
            }
            return val;
        }
        internal static void ReadIntialPosition(Position position)
        {
            Console.WriteLine("Enter X, Y, Facing Value");
            Console.WriteLine("X Value from 0 to 4");
            position.X = Helper.ReadValueAsInt(0, 4, "Invalid Entry Please Enter 0 to 4");
            Console.WriteLine("Y Value from 0 to 4");
            position.Y = Helper.ReadValueAsInt(0, 4, "Invalid Entry Please Enter 0 to 4");
            Console.WriteLine("Select Facing Value from \n1 for NORTH \n2 for EAST \n3 for SOUTH \n4 for WEST");
            position.Facing = (Direction)(Helper.ReadValueAsInt(1, 4, "Invalid Entry Please Enter 1 to 4") - 1);
        }

        internal static void Move(Position position)
        {
            switch ((int)position.Facing)
            {
                case 0:
                    if (position.Y < 4)
                        position.Y++;
                    else
                        Console.WriteLine("Invalid Move");
                    break;
                case 1:
                    if (position.X > 4)
                        position.X--;
                    else
                        Console.WriteLine("Invalid Move");
                    break;
                case 2:
                    if (position.Y > 0)
                        position.Y--;
                    else
                        Console.WriteLine("Invalid Move");
                    break;
                case 3:
                    if(position.X > 0)
                        position.X--;
                    else Console.WriteLine("Invalid Move");
                    break;
            }
        }
    }    
}