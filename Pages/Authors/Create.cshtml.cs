﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ardelean_Alexandra_Lab2.Data;
using Ardelean_Alexandra_Lab2.Models;

namespace Ardelean_Alexandra_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Ardelean_Alexandra_Lab2.Data.Ardelean_Alexandra_Lab2Context _context;

        public CreateModel(Ardelean_Alexandra_Lab2.Data.Ardelean_Alexandra_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Authors { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Authors == null || Authors == null)
            {
                return Page();
            }

            _context.Authors.Add(Authors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
