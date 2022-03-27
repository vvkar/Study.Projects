using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with a field that is a reference 
    /// to a one-dimensional integer array. The class has a constructor 
    /// with one integer argument that specifies the size of the array. 
    /// When an object is created, all array elements are set to zero. 
    /// The following operators are overloaded in the class: 
    /// The unary operator ~ is overloaded in such a way that the result 
    /// is a text string with the value of the elements of the array 
    /// (referenced by the field of the object to which the operator is applied). 
    /// The unary increment operator ++ is overloaded so that its application 
    /// to an object results in the addition of a new element with a value of zero to the array. 
    /// The result is a reference to the operand object. When the decrement operator 
    /// is applied to an object, one element (for example, the last one) is removed 
    /// from the array, and a reference to the operand object is returned as a result. 
    /// The binary addition operator + must be defined so that the sum of two objects, 
    /// an object and a number, and a number and an object can be calculated. In all cases, 
    /// a new object is returned as the result. If two operand objects participate in 
    /// the operation, then the array in the result object is formed by the union 
    /// of the arrays of the added objects. If the sum of an object and a number is calculated, 
    /// then the array in the result object is obtained by adding a new element to the array 
    /// from the operand object. The value of the added element is determined by the value of 
    /// the number of the operand. If an object is added to the number, then the new element 
    /// is added to the beginning of the array. If a number is added to the object, then 
    /// the new element is added to the end of the array.
    /// </summary>
    internal class Ch8Task2
    {
        static void Main(string[] args)
        {
            int arraySize = InputChecker.EnterInteger();

            TaskClass obj = new TaskClass(arraySize);

            Console.WriteLine("Your obj consist of: " + ~obj);

            obj++;

            Console.WriteLine("Incrementer object: " + ~obj);

            int firstNum = InputChecker.EnterInteger("Enter a number to add to obj: ");

            obj += firstNum;

            Console.WriteLine("Obj + num = " + ~obj);

            obj--;

            Console.WriteLine("Decremented object: " + ~obj);

            int secondNum = InputChecker.EnterInteger("Enter a number to add to obj: ");

            obj = secondNum + obj;

            Console.WriteLine("Num + obj = " + ~obj);
        }

        class TaskClass
        {
            public int[] array;

            public TaskClass(int arraySize)
            {
                this.array = new int[arraySize];
            }

            public static string operator~ (TaskClass obj)
            {
                StringBuilder sb = new StringBuilder();

                foreach (int i in obj.array)
                {
                    sb.Append(i +", ");
                }
                return sb.ToString().Trim(',', ' ');
            }

            public static TaskClass operator++ (TaskClass obj)
            {
                int [] newArray = new int[obj.array.Length + 1];

                for(int i = 0; i < obj.array.Length; i++)
                {
                    newArray[i] = obj.array[i];
                }

                obj.array = newArray;

                return obj;
            }

            public static TaskClass operator-- (TaskClass obj)
            {
                int[] newArray = new int[obj.array.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = obj.array[i];
                }

                obj.array = newArray;

                return obj;
            }

            public static TaskClass operator+ (TaskClass obj1, TaskClass obj2)
            {
                int newArraySize = obj1.array.Length + obj2.array.Length;
                
                TaskClass newObject = new TaskClass(newArraySize);

                for (int i = 0; i < obj1.array.Length; i++)
                {
                    newObject.array[i] = obj1.array[i];
                }
                for (int i = 0; i < obj2.array.Length; i++)
                {
                    newObject.array[i + obj1.array.Length] = obj2.array[i];
                }

                return newObject;
            }

            public static TaskClass operator+ (TaskClass obj, int number)
            {
                int newArraySize = obj.array.Length + 1;

                TaskClass newObject = new TaskClass(newArraySize);

                for(int i = 0; i < obj.array.Length; i++)
                {
                    newObject.array[i] = obj.array[i];
                }
                newObject.array[newObject.array.Length - 1] = number;

                return newObject;
            }

            public static TaskClass operator+ (int number, TaskClass obj)
            {
                int newArraySize = obj.array.Length + 1;

                TaskClass newObject = new TaskClass(newArraySize);

                newObject.array[0] = number;

                for (int i = 0; i < obj.array.Length; i++)
                {
                    newObject.array[i + 1] = obj.array[i];
                }

                return newObject;
            }
        }
    }
}
