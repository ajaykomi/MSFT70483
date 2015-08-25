using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesImplementation.Classes
{
    class SeniorStudent : IStudent
    {

        // implement interface implicitly
        public char grade
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float calculatepercentage(int marks)
        {
            return (marks / 1000) * 100;
            //throw new NotImplementedException();
        }

        public bool istoprank(int marks)
        {
            return calculatepercentage(marks) > 80 ? true : false;
            throw new NotImplementedException();
        }
    }
}
