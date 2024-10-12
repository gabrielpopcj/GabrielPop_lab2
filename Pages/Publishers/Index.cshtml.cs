﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GabrielPop_lab2.Data;
using GabrielPop_lab2.Models;

namespace GabrielPop_lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly GabrielPop_lab2.Data.GabrielPop_lab2Context _context;

        public IndexModel(GabrielPop_lab2.Data.GabrielPop_lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
