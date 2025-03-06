using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPr4
{
    internal class Program
    {
        //create methods
        static void AddGrade();
        static void RemoveGrade();
        static void DisplayGrades();
        static void AverageGrade();
        static void HighestGrade();
        static void LowestGrade();

        static void Main(string[] args)
        {
            //create menu
            Console.WriteLine("Grade Menu:");
            Console.WriteLine("1. Add Grade");
            Console.WriteLine("2. Remove Grade");
            Console.WriteLine("3. Display Grades");
            Console.WriteLine("4. Highest Grade");
            Console.WriteLine("5. Lowest Grade");


            {
                Console.WriteLine("Type an option from the menu above:");//ask user to make a selection

            }

            //process selection

            switch()
            {
                case 1:
                    AddGrade();
                    break;
                case 2:
                    RemoveGrade();
                    break;
                case 3:
                    DisplayGrades();
                    break;
                case 4:
                    HighestGrade();
                    break;
                case 5:
                    LowestGrade();
                    break;
            }
            //process add grade

            //process remove grade

            //process display grade

            //process highest grade

            //process lowest grade

            Console.ReadLine();// hold screen for user to view
        }

    }
}

