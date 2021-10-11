using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOps2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevOps2.Pages
{
    public class StudiosModel : PageModel
    {
        public IEnumerable<Studios> studios { get; set; }

        public StudiosModel()
        {
            studios = FakeRepository.GetStudio();
        }

        public void OnGet()
        {
        }
        
    }
}
