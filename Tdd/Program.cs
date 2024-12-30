using System;
using System.ComponentModel;
using System.Transactions;
using System.Xml.Linq;
using static Program;

class Program
{
    static void Main(string[] args){

         string name = "ali";
         string lastname = "gholami";

         string name2 = "mamad";
         string lastname2 = "hasani";

        string name3 = "josef";
        string lastname3 = "oohh";

        Information information = Information.GetInformation();
        Information information2 = Information.GetInformation();


        information.AddInformation(name, lastname);
        information2.AddInformation(name2, lastname2);


    }


    public sealed class Information
    {
        string _name, _lastNamel;
        private Information(){}

        public static Information _information;

        public static Information GetInformation() {

            if (_information == null) {
                Console.WriteLine("null");
                _information = new Information();
            }
            else
            {
                Console.WriteLine("we have");
            }

            
            return _information;

        }

        public string AddInformation(string name, string lastName)
        {
            Console.WriteLine(name + " Added . ");
            return name;
        }
    }
}



