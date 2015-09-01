﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesImplementation;
using InterfacesImplementation.Classes;

namespace InterfacesImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating by class names
            SeniorStudent senstud = new SeniorStudent();
            JuniorStudent junstud = new JuniorStudent();

            Console.WriteLine(senstud.calculatepercentage(872));
            // the below line of code gives compile time erroe since JuniorStudent Class dont have a definition of calculatedpercentage
            // Instead it has 
            //Console.WriteLine(junstud.calculatepercentage(420)); 
            //instantiating by interface name

            IStudent isenstud = new SeniorStudent();
            IStudent ijunstud = new JuniorStudent();

            Console.WriteLine(isenstud.calculatepercentage(872));

            Console.WriteLine(ijunstud.calculatepercentage(420));
        }
    }
}