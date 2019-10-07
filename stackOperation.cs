using System;
using System.Collections.Generic;
using System.Linq;

namespace stackProblemSolution
{
    public class StackOperation
    {
        public List<int> elementlists = new List<int>();                 //using list

        public bool Push(int val)
        {
            using (var db = new Model2())
            {
                var st = new Stack();
                st.elementlists = val;

                db.Stacks.Add(st);
                db.SaveChanges();
            }
           
            return true;
        }   
        
        public void Pop()
        {
            if (!Convert.ToBoolean(elementlists.Count()))
            {
                throw new Exception("stack is empty");
            }
            else
                elementlists.RemoveAt(elementlists.Count() - 1);
            
        }
        public int printMaximumElement()
        {
           
            if(!Convert.ToBoolean(elementlists.Max()))
            {
                throw new Exception("stack is empty");
            }
            else
            return (elementlists.Max());
        }
    }
}
