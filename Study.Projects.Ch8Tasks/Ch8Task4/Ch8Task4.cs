using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with integer and text fields. 
    /// Overload all comparison operators. The comparison for more or 
    /// less is performed based on the comparison of the length of text 
    /// values ​​(meaning the text fields of the objects being compared). 
    /// When comparing for "greater than or equal to" or "less than or 
    /// equal to", the values ​​of integer fields of objects are compared. 
    /// When comparing for "equal" or "not equal", integer and text fields
    /// of objects are compared. Also suggest a way to override Equals( ) 
    /// and GetHashCode( ) methods.
    /// </summary>
    internal class Ch8Task4
    {
        static void Main(string[] args)
        {
            string textOne = InputChecker.EnterString();
            int numOne = InputChecker.EnterInteger();
         
            TaskClass obj1 = new TaskClass (textOne, numOne);

            Console.WriteLine("First object data:\n" + obj1);

            string textTwo = InputChecker.EnterString();
            int numTwo = InputChecker.EnterInteger();

            TaskClass obj2 = new TaskClass(textTwo, numTwo);

            Console.WriteLine("Second object data:\n" + obj2);

            Console.WriteLine("\nObj1 > Obj2: " + (obj1 > obj2));
            Console.WriteLine("\nObj1 < Obj2: " + (obj1 < obj2));
            Console.WriteLine("\nObj1 >= Obj2: " + (obj1 >= obj2));
            Console.WriteLine("\nObj1 <= Obj2: " + (obj1 <= obj2));
            Console.WriteLine("\nObj1 == Obj2: " + (obj1 == obj2));
            Console.WriteLine("\nObj1 != Obj2: " + (obj1 != obj2));
            Console.WriteLine("\nObj1 hashcode: " + obj1.GetHashCode());
            Console.WriteLine("\nObj2 hashcode: " + obj2.GetHashCode());

        }
    }

    class TaskClass
    {
        private string text;
        private int number;

        public TaskClass(string text, int number)
        {
            this.text = text;
            this.number = number;
        }

        public static bool operator > (TaskClass obj1, TaskClass obj2)
        {
            if(obj1.text.Length > obj2.text.Length)
            {
                return true;
            }
            return false;
        }

        public static bool operator < (TaskClass obj1, TaskClass obj2)
        {
            if(obj1.text.Length < obj2.text.Length)
            {
                return true;
            }
            return false;
        }
        
        public static bool operator >= (TaskClass obj1, TaskClass obj2)
        {
            if(obj1.number >= obj2.number)
            {
                return true;
            }
            return false;
        }

        public static bool operator <= (TaskClass obj1, TaskClass obj2)
        {
            if(obj1.number <= obj2.number)
            {
                return true;
            }
            return false;
        }

        public static bool operator == (TaskClass obj1, TaskClass obj2)
        {
            if((obj1.text == obj2.text) && (obj1.number == obj2.number))
            {
                return true;
            }
            return false;
        }
        
        public static bool operator != (TaskClass obj1, TaskClass obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object obj) 
        {
            return this == (TaskClass)obj;
        }

        public override int GetHashCode()
        {
            int result = 0;

            foreach(char c in this.text)
            {
                result += (int)c;
            }
            result += this.number;

            return result;
        }

        public override string ToString()
        {
            return $"text: \"{this.text}\", number = {this.number}";
        }
    }
}
