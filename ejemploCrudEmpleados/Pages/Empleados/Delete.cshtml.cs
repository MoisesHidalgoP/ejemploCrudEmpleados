﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace ejemploCrudEmpleados.Pages.Empleados
{
    public class DeleteModel : PageModel
    {
        private readonly DAL.Modelo.ejemploCrudEmpleadosContext _context;

        public DeleteModel(DAL.Modelo.ejemploCrudEmpleadosContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Empleado Empleado { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Empleados == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados.FirstOrDefaultAsync(m => m.Id == id);

            if (empleado == null)
            {
                return NotFound();
            }
            else 
            {
                Empleado = empleado;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.Empleados == null)
            {
                return NotFound();
            }
            var empleado = await _context.Empleados.FindAsync(id);

            if (empleado != null)
            {
                Empleado = empleado;
                _context.Empleados.Remove(Empleado);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
