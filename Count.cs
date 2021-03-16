using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITBIT
{
    class Count
    {
        public string name;
        public int number;
        public double sum;
        public Count()
        {
            this.name = "Счёт";
            this.number = 1;
            this.sum = 0;
        }
        public Count(string cName, int cNumber, double cSum)
        {
            this.name = cName;
            this.number = cNumber;
            this.sum = cSum;
        }
    }
}
