using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_Lesson3
{
    /**
     * this class is the "driver" class for our program
     */
   public class Program
    {
        /**
         * the main method for driver class
         * 
         * @method main
         * @parm {string[]} args
         */
       public static void Main(string[] args)
        {
            // Create a new instance(object) of the person class
            Person person = new Person();
            Console.WriteLine(person.Name);
            // set a value in the name property of the person class
            person.Name = "Inder";
            


        }
    }
}
