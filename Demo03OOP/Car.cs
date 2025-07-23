using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03OOP
{
    internal class Car
    {
        #region Attraubites 

        //int id;
        //string Model;
        //double speed;

        #endregion

        #region Properties
        public int id { get; set; }
        public string? model { get; set; } // ? => accept nullable type

        public double speed { get; set; }
        #endregion

        #region CTOR
        //user defaine DT
        public Car(int Id, string? Model, Double Speed)
        {
            this.id = Id;
            this.model = Model;
            this.speed = Speed;
            Console.WriteLine( "1st CTOR");
        }
        // CTOR Overloading
        public Car(int Id, string? Model) : this (Id , Model , 360)
        {
            Console.WriteLine("2st CTOR");
        }

        public Car(int Id) : this(Id, "audoi", 200)
        {
            Console.WriteLine("3st CTOR");
        }
        #endregion

        #region Methods 
        public override string ToString()
        {
            return $"ID : {id} \n Model : {model} \n Speed : {speed}";
        }
        #endregion


    }
}
