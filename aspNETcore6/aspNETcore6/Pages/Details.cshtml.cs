﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aspNETcore6.Data;

namespace aspNETcore6.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly aspNETcore6.Data.aspNETcore6Context _context;

        public DetailsModel(aspNETcore6.Data.aspNETcore6Context context)
        {
            _context = context;
        }

      public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else 
            {
                Student = student;
            }
            return Page();
        }
    }
}
