using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace InterfacesImplementation.Classes
{
    class JuniorStudent : IStudent, IDisposable
    {
        // Interface implemented explicitly
        RegistryKey m_key;

        char IStudent.grade
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

         float IStudent.calculatepercentage(int marks)
        {
            return (marks / 470) * 100;
        }

        bool IStudent.istoprank(int marks)
        {
            return (this as IStudent).calculatepercentage(marks) > 80 ? true : false;
            
        }



        void IDisposable.Dispose()
        {
 	        m_key.Dispose();
        }
}
}
