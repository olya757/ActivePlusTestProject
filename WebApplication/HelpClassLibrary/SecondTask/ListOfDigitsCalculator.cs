using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpClassLibrary.SecondTask
{
    public static class ListOfDigitsCalculator
    {
        public static ListOfDigits GetSummOfLists(ListOfDigits a, ListOfDigits b)
        {
            var a_node = a.YoungerNode;
            var b_node = b.YoungerNode;
            ListNode biggest_node = null;
            ListOfDigits result = new ListOfDigits();
            var res_node = result.YoungerNode;
            int added_sum = 0;
            while (!(a_node is null) && !(b_node is null))
            {
                int tmp_sum = a_node.Value + b_node.Value + added_sum;
                res_node.Value = tmp_sum % 10;
                added_sum = tmp_sum / 10;
                ListNode elderNode = new ListNode();
                res_node.ElderNode = elderNode;
                elderNode.YoungerNode = res_node;
                res_node = elderNode;
                a_node = a_node.ElderNode;
                b_node = b_node.ElderNode;
            }

            if (!(a_node is null))
            {
                biggest_node = a_node;
            }
            else
            if (!(b_node is null))
            {
                biggest_node = b_node;
            }
            while(!(biggest_node is null))
            {
                int tmp_sum = biggest_node.Value + added_sum;
                res_node.Value = tmp_sum % 10;
                added_sum = tmp_sum / 10;
                ListNode elderNode = new ListNode();
                res_node.ElderNode = elderNode;
                elderNode.YoungerNode = res_node;
                res_node = elderNode;
                biggest_node = biggest_node.ElderNode;
            }
            if (added_sum > 0)
            {
                res_node.Value = added_sum;
            }
            else
            {
                res_node.YoungerNode.ElderNode = null;
            }
            return result;
        }
    }
}
