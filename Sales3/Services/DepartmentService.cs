using Sales3.Data;
using Sales3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sales3.Services
{
    public class DepartmentService
    {
        private readonly Sales3Context _context;

        public DepartmentService(Sales3Context context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
