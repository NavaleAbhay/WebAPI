using TflWebAPI.Model;
namespace TflWebAPI.Repositories.Interfaces;
public interface IDepartmentRepository{
    List<Department> GetAllDepartment();
    
}