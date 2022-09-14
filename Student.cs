using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Student
    {
        private string fname;
        public void SetName(string value)
        {
            this.fname = value;
        }
        public string GetName()
        {
            return this.fname;
        }
    }
}
