using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03OOP
{
    internal class Child : Parent
    {
        #region properites

        //public int x { get; set; }
        //public int y { get; set; }
        public int z { get; set; }
        #endregion

        #region CTOR
        public Child(int X , int Y , int Z) : base (X,Y)
        {
            this.z = Z;
        }
        #endregion

        #region Methods
        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        public override int multiple()
        {
            return base.multiple() * z;
        }

        public new void MyFunc() //kda new function 
        {
            Console.WriteLine("cild");
        }
        #endregion
    }
}
