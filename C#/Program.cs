using System;

namespace TechnicalTest
{    class Program
    {
        public static int BoundryboxY = 0;
        public static int BoundryboxX = 0;
        public static int BBMX = 0;
        public static int BBMY = 0;
        public static string Coord = string.Empty;
        public static int i = 1;
        
        public static void Boundry()
        {
            

            Console.WriteLine("Enter the max Boundry X ");
            string BoundryboxXM = Console.ReadLine();

            Console.WriteLine("Enter the max Boundry Y ");
            string BoundryboxYM = Console.ReadLine();

            BBMX = Convert.ToInt32(BoundryboxXM);
            BBMY = Convert.ToInt32(BoundryboxYM);

            Console.WriteLine("Boundry Box Value {0} {1} ",BoundryboxX,BoundryboxY);
            Console.WriteLine("Max Boundry Box Value {0} {1} ",BBMX,BBMY);
        }
        public static void RobotCoord()
        {
            int IFN = 0;
            
            Console.WriteLine("Enter the Robots X co-ordinate ");
            string RX = Console.ReadLine();

            Console.WriteLine("Enter the Robots Y co-ordinate ");
            string RY = Console.ReadLine();

            int RobotX = Convert.ToInt32(RX);
            int RobotY = Convert.ToInt32(RY);

            Console.WriteLine("Enter the Robots Orientation ");
            string OR = Console.ReadLine();

            Console.WriteLine("Robots Co-ordinates {0} {1} {2} ",RobotX,RobotY,OR);

            if (OR == "N")
            {
                IFN = 1;
            }
            else if (OR == "E")
            {
                IFN = 2;
            }
             else if (OR == "S")
            {
                IFN = 3;
            }
             else if (OR == "W")
            {
                IFN = 4;
            }
            else
            {
                Console.WriteLine("You Haven't Selected A Co-ordinate");
                
            }

            while(i == 1) {
            switch (IFN) 
            {
            case 1:
             OR = "N";
             Console.WriteLine("Please Enter Directions using <, > and ^");
             Coord = Console.ReadLine();
             if (Coord == "<")
             {
                 IFN = 4;
             }
             else if (Coord == ">")
             {
                 IFN = 2;
             }
             else if (Coord == "^")
             {
                 RobotY = RobotY +1;
                 if (RobotY > BBMY)
                 {
                     RobotY = RobotY -1;
                 }
                 Console.WriteLine("Robots Co-ordinates {0} {1} {2} ",RobotX,RobotY,OR);
             }
             else
             {
                i = 0;
             }
             break;
            case 2:
             OR = "E";
             Console.WriteLine("Please Enter Directions using <, > and ^");
             Coord = Console.ReadLine();
             if (Coord == "<")
             {
                 IFN = 1;
             }
             else if (Coord == ">")
             {
                 IFN = 3;
             }
             else if (Coord == "^")
             {
                 RobotX = RobotX +1;
                 if (RobotX > BBMX)
                 {
                     RobotX = RobotX -1;
                 }
                 Console.WriteLine("Robots Co-ordinates {0} {1} {2} ",RobotX,RobotY,OR);
             }
             else
             {
                i = 0;
             }
             break;
            case 3:
             OR = "S";
             Console.WriteLine("Please Enter Directions using <, > and ^");
             Coord = Console.ReadLine();
             if (Coord == "<")
             {
                 IFN = 2;
             }
             else if (Coord == ">")
             {
                 IFN = 4;
             }
             else if (Coord == "^")
             {
                 RobotY = RobotY -1;
                 if (RobotY < BoundryboxY)
                 {
                     RobotY = RobotY +1;
                 }
                 Console.WriteLine("Robots Co-ordinates {0} {1} {2} ",RobotX,RobotY,OR);
             }
             else
             {
                i = 0;
             }
             break;
            case 4:
             OR = "W";
             Console.WriteLine("Please Enter Directions using <, > and ^");
             Coord = Console.ReadLine();
             if (Coord == "<")
             {
                 IFN = 3;
             }
             else if (Coord == ">")
             {
                 IFN = 1;
             }
             else if (Coord == "^")
             {
                 RobotX = RobotX -1;
                 if (RobotX < BoundryboxX)
                 {
                     RobotX = RobotX +1;
                 }
                 Console.WriteLine("Robots Co-ordinates {0} {1} {2} ",RobotX,RobotY,OR);
             }
             else
             {
                i = 0;
             }
             break;
            }
        }

        }
        public static void Main(string[] args)
        {
            Boundry();
            RobotCoord();
        }
        
    }
}
