using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesImplementation.Classes
{
    class SeniorStudent : IStudent, IComparable
    {
       
        public SeniorStudent()
        {

        }
        public string name { get; set; }

        // implement interface implicitly
        public char grade { get; set; }

        public float calculatepercentage(int marks)
        {
            return ((float)marks / 1000) * 100;
            //throw new NotImplementedException();
        }

        public bool istoprank(int marks)
        {
            return calculatepercentage(marks) > 80 ? true : false;
        
        }


        public int CompareTo(object obj)
        {
            SeniorStudent student = obj as SeniorStudent;
            return this.name.CompareTo(student.name);
            
        }

    }
}
