using System.Reflection;

namespace Demo03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region User Defiene Datatype [Class] 
            /*
             * Blueprint contain Objects [member variables , methods ]
             * class is referance type object stored in stack and values stored in heap 
             * ComPiler Will Generate Empty Parameters CTOR
             * if user defiend CTOR found , Compiler Willno longer need parameterless CTOR
             *   - Attributes 
             *   - Functions 
             *   - Methods
             *   - EVent
             * 6 Access modifier Allowed 
             * Defual access mod inside class Privte 
             * Defualt Internal 
             * */

            #endregion

            /*  //Car C1; 
              ////declars referance type from 'Car' Class 
              ////C1 refer to defualt in heap 
              //// this referance C1 can refer to an instance of type Car or any Data type inhiert from Car
              //// //CLR will allocatr 4 byte at stack for object C1 

              //C1 = new Car(10 , "BMW", 600 ); // hna lazm values  () 3l4an al CROT ---
              //                                    // lw 3aiaz ben al () kda lazm a3ml Default cTOR
              //                                    // id = 0; model = "Unknown"; 

              //Console.WriteLine( C1);

              //Car C2 = new Car(20, "fait");
              //Console.WriteLine(C2);

              //Car c3 = new Car(10);
              //Console.WriteLine(c3);*/

            #region Struct vs Class 

            /*          memoery 
             * Class--- is  -- referance type --- stored on heap (referance stored on stack)
             * Struct-- is --  value type     --- stored on Stack
             *  
             *         inheritance
             * Class ---- Supports inheritance
             * Struct --- Don't supports inheritance
             *
             *        nullablitiy
             *Class -- can be null
             *Struct - can't be null
             *
             *       performance
             *Class -- more overhead (heap allocation) 
             *Struct - lightwighet for small data faster allocation on stack 
             *
             *     when i can use
             *Class -- Use class when you need a reference type with inheritance and complex behavior.
             *Struct - Use struct when you need a lightweight value type with simple data and no inheritance.
             */



            #endregion


            #region inheritance

            // C# Not allowed multible class inheritance
            /* inheritanve :___ 
             *             one of pillars of OOP
             *             aviod Code duplication
             * 
             * C# Support 3 category of inheritance 
             *    1- single inheritance
             *      class inhert from one class
             *      
             *    2- Multi level inheritance
             *    
             *      class inhert fron class and this class inhert from another class
             *      -parent
             *      -child 
             *      -grand child
             *      
             *    3-hier inhert 
             *       Multiable Classes can inhert from only one base class 
             *       
             *       C# Doesn't allow multiple inheritance
             *       */

            //Parent P1 = new Parent(1, 2);

            //P1.x = 10;
            //P1.y = 20;
            //Console.WriteLine( P1);
            //Console.WriteLine(P1.multiple());
            //P1.MyFunc();

            Child C1 = new Child(1, 2, 5);

            C1.x = 20;
            Console.WriteLine( C1);
            Console.WriteLine( C1.multiple());
            C1.MyFunc();


            #endregion
            

        }
    }
}
