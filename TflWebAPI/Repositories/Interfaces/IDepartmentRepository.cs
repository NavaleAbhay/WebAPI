using TflWebAPI.Model;
namespace TflWebAPI.Repositories.Interfaces;
public interface IDepartmentRepository{
   Task<List<Department>> GetAllDepartment();

}