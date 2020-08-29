using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpClassLibrary.ThirdTask;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication
{
    public class ThirdTaskModel : PageModel
    {
        [BindProperty]
        public string Word { get; set; }

        [BindProperty]
        public string Result { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (Word is null)
            {
                Result = "Строка пуста!";
                return Page();
            }
            if (Checker.IsPalindrome(Word))
            {
                Result = "Да!";
            }
            else
            {
                Result = "Увы, нет.";
            }
            return Page();
        }

    }
}