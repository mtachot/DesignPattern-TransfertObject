using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransfertObjectPattern.Classes
{
    public class StudentVO
    {
        public string Name { get; set; }
        public int RollNo { get; set; }

        public StudentVO(string name, int rollNo)
        {
            this.Name = name;
            this.RollNo = rollNo;
        }
    }
}
