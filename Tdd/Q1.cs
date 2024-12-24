using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd
{
    public class Information
    {
        string _name, _lastNamel;
        public Information(string name , string lastName) { 

            _name = name;
            _lastNamel = lastName;

        }

        public static Information _information;
        public static Information AddInformation(string name, string lastName) { 
        
            _information = new Information(name,lastName);


            Console.WriteLine(name+" Added . ");
            return _information;
        
        }
    }


    public class Main
    {
       

        static string name = "ali";
        static string lastname = "gholami";

        static string name2 = "mamad";
        static string lastname2 = "hasani";

        Information information = Information.AddInformation(name, lastname);
        Information information2 = Information.AddInformation(name2, lastname2);

        


    }


}
