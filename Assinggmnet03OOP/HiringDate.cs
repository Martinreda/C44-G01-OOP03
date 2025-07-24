using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinggmnet03OOP
{
    internal class HiringDate
    {
        #region Attrubites 
        private int day;
        private int month;
        private int year;
        #endregion
        #region CTOR
        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion

        #region Methods 
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
        #endregion
    }
}
