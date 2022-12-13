using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace ejemploCrudEmpleados.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        private readonly DAL.Modelo.ejemploCrudEmpleadosContext _context;

        public IndexModel(DAL.Modelo.ejemploCrudEmpleadosContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleado { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Empleados != null)
            {
                Empleado = await _context.Empleados.ToListAsync();
            }
        }
    }
}
