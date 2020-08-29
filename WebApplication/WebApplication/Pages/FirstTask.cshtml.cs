using System;
using System.Linq;
using HelpClassLibrary.FirstTask;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication
{
    public class FirstTaskModel : PageModel
    {
        [BindProperty]
        public string Array { get; set; }

        [BindProperty]
        public string Result { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            int[] elems;
            try
            {
                elems = Array.Split(',', ' ').Where(p=>p.Length>0).Select(a => int.Parse(a)).ToArray();
                Result = Counter.GetSummOfOddNumbers(elems).ToString();
            }
            catch (Exception e)
            {
                Result = "Неверно введены данные";
            }
            return Page();
        }
    }
}