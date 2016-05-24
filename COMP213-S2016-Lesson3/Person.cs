using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_Lesson3
{
    /**
     * This class defines a generic person
     * 
     * @class person
     * @field _name {string}
     */
   public class Person
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++
       private string _name;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++

            /**
             * this is property for our _name field
             * 
             * @property {string} Name
             */
        
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            } 
        }
        /**
         * This is a default empty constructor for the person class
         * 
         * @constructor person
         */



        public Person()
        {
            this.Name = "Unknown name";
        }

        /**
         * This is a constructor that takes name as as paramater and 
         * passes it to the _name Private instance variable
         * 
         * @constructor person
         * @parm {string} _name
         */

        public Person(string name)
        {
            this.Name = "Unknown name";
        }
    }
}
