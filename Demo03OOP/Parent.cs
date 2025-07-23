using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03OOP
{
    internal class Parent
    {
        #region properties 
        public int x { get; set; }
        public int y { get; set; }


        #endregion

        #region CTOR 
        public Parent(int X , int Y)
        {
            this.x = X;
            this.y = Y;
        }
        #endregion

        #region Method 
        public virtual /*visiable*/ int multiple ()
        {
            return x * y;
        }
        public void MyFunc ()
        {
            Console.WriteLine("You are in Parent Class");
        }
        public override string ToString()
        {
            return $"X: {x}\nY :  {y}";
        }
        #endregion
    }
}
