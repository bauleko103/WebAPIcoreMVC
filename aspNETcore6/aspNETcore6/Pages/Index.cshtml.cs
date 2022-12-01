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
    public class IndexModel : PageModel
    {
        private readonly aspNETcore6.Data.aspNETcore6Context _context;

        public IndexModel(aspNETcore6.Data.aspNETcore6Context context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student
                .Include(s => s.Standard).ToListAsync();
            }
        }
    }
}
