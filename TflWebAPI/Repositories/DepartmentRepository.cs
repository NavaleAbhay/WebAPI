using System.Collections.Generic;
using System.Linq;
using TflWebAPI.Model;
using TflWebAPI.Repositories.Interfaces;
using TflWebAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TflWebAPI.Repositories;

public class DepartmentRepository : IDepartmentRepository
{
    public  async Task<List<Department>> GetAllDepartment(){
        
        await using (var context = new DepartmentContext())
        {
            var departments =  from dept in context.Departments select dept;
            return  departments.ToList<Department>();
        }
    }
}
