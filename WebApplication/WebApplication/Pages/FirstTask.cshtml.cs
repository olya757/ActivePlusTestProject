using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                var strs = Array.Split(',', ' ');
                elems =strs.Where(p=>p.Length>0).Select(a => int.Parse(a)).ToArray();
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