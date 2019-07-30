using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    //practice with Methods
    class Point
    {   
        //set fields
        public int X;
        public int Y;
        
        //initialize it
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //method to move this point to a different location
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //overload this method
        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
    }
}
