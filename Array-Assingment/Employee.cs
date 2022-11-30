using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class Employee
    {
        String name;
        int eId;
        int mgrId;

        public Employee()
        {

        }

        public Employee(string name, int eId, int mgrId)
        {
            this.name = name;
            this.eId = eId;
            this.mgrId = mgrId;
        }

        public override string ToString()
        {
            return "Name : " + name + " ID : " + eId + " Manager Id : " + mgrId;
        }


        static void Main(string[] args)
        {
            Employee[] emp = new Employee[5];

            emp[0] = new Employee("Abhijeet", 101, 10);
            emp[1] = new Employee("Abhi", 102, 11);
            emp[2] = new Employee("Ab", 104, 12);
            
            for(int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i]);
            }

        }

    }
}
