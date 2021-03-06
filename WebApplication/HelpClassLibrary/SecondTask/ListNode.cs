﻿
namespace HelpClassLibrary.SecondTask
{
    public class ListNode
    {
        public ListNode ElderNode { get;set; }
        public ListNode YoungerNode { get; set; }
        private int value;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if(value>=0 && value<=9)
                    this.value = value;
            }
        }      
        
        public ListNode(ListNode younderNode, int number)
        {
            value = number % 10;
            number = number / 10;
            YoungerNode = younderNode;
            if (number > 0)
            {
                ElderNode = new ListNode(this, number);
            }
            else
            {
                ElderNode = null;
            }
        }

        public ListNode(int number=0)
        {
            value = number;
            ElderNode = null;
            YoungerNode = null;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }

    
}
