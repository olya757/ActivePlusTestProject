using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpClassLibrary.SecondTask;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication
{
    public class SecondTaskModel : PageModel
    {
        [BindProperty]
        public int First { get; set; }

        [BindProperty]
        public int Second { get; set; }

        [BindProperty]
        public int SummOfNumbers { get; set; }

        [BindProperty]
        public string SummOfLists { get; set; }


        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {

            if(First>0 && Second > 0)
            {
                SummOfNumbers = First + Second;
                ListOfDigits list1 = new ListOfDigits(First);
                ListOfDigits list2 = new ListOfDigits(Second);
                SummOfLists = ListOfDigitsCalculator.GetSummOfLists(list1, list2).ToString();
            }


            return Page();
        }
    }
}