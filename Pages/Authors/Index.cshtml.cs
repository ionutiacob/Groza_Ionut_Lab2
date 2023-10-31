using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Groza_Ionut_Lab2.Data;
using Groza_Ionut_Lab2.Models;

namespace Groza_Ionut_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Groza_Ionut_Lab2.Data.Groza_Ionut_Lab2Context _context;

        public IndexModel(Groza_Ionut_Lab2.Data.Groza_Ionut_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Authors = (IList<Author>)await _context.Authors.ToListAsync();
            }
        }
    }
}
