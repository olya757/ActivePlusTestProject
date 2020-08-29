using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpClassLibrary.SecondTask
{
    public class ListOfDigits
    {
        public ListNode YoungerNode { get; set; }
        
        public int ToInt()
        {
            var node = YoungerNode;
            int result = 0;
            while(!(node is null))
            {
                result = result * 10 + node.Value;
                node = node.ElderNode;
            }
         
            return result;
        }


        public ListOfDigits(int number)
        {
            YoungerNode = new ListNode(null, number);
        }

        public ListOfDigits()
        {
            YoungerNode = new ListNode();
        }

        public override string ToString()
        {
            string result = "-null";
            var node = YoungerNode;
            while(!(node is null))
            {
                result = "-" + node + result;
                node = node.ElderNode;
            }
            result = "null" + result;
            return result;
        }
    }
}
