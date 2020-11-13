//Corrected by Dustin Johnson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        //adding a new add method to add elements
        //to a Set that allows for duplicates
        public void add(int val)
        {
            elements.Add(val);
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            //create a boolean variable to store 
            //what happens in the loop, initialize
            //to avoid compiler error 
            bool result = false;
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                {
                    result = true;
                    //add break out statement if element is
                    //contained there is no need to continue
                    break;
                }
                else
                    result = false;
            }
            //having this will always return false regardless 
            //return false;
            return result;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        //This method should compare the elements
        //of each Set, only adding what isn't already there
        //public Set union(Set rhs)
        public static Set union(Set a, Set b)
        {
            //add a new Set that is the union of two sets
            Set unionList = new Set();
          //  for (int i = 0; i < rhs.elements.Count; i++)
          for (int i = 0; i < a.elements.Count; i++)
            {
                //this.addElement(rhs.elements[i]);
                unionList.addElement(a.elements[i]);
                unionList.addElement(b.elements[i]);
            }
            //this returns the wrong set
            // return rhs;
            return unionList;
        }
    }
}
