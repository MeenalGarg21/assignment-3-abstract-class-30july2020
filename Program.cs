using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InheritanceAbstract
{

    abstract class Quadrilateral
    {
        public int length;

         public abstract int Area();
    }
    class Rectangle : Quadrilateral
    {
       public  int breadth;
        public bool IsSquare
        {
            set { return IsSquare; }
            get
            {
                if (breadth == length)
                {
                    return true;

                }
                else
                {
                    Console.WriteLine("The rectangle is not equal to square");
                }
            }
        }
        
      public   int length;
        public Rectangle(int _breadth, int _length)
        {
            length = _length;
            breadth = _breadth;
        }

        public override int Area()
        {
            return  breadth * length;
        }

    }
    class Square : Quadrilateral
    {
        int side;
        public Square(int n)
        {
            side = n;
        }
        public override int Area()

        {
            return side * side;
        }
        
    }
   


    class Program
    {
        public static void Main()
        {
            Square sq = new Square(4);
            Console.WriteLine("Area of a square  is " + sq.Area());
            Console.ReadLine();
            Rectangle rec = new Rectangle(5, 6);
            Console.WriteLine("Area of rectangle is"+ rec.Area());
          if(sq.Area()>>rec.Area())
            {
                Console.WriteLine("square is bigger");
            }
            else
            {
                Console.WriteLine("rectangle is bigger");
            }
        
              

        }
    }


}