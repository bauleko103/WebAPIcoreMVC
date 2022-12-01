using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using aspNETcore6.Data;

namespace aspNETcore6.Pages
{
    public class CreateModel : PageModel
    {
        private readonly aspNETcore6.Data.aspNETcore6Context _context;

        public CreateModel(aspNETcore6.Data.aspNETcore6Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StandardId"] = new SelectList(_context.Set<Standard>(), "StandardId", "StandardId");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
