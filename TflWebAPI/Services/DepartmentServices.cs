using TflWebAPI.Model;
using TflWebAPI.Repositories.Interfaces;
using TflWebAPI.Repositories;
using TflWebAPI.Services.Interfaces;

namespace TflWebAPI.Services;
public class DepartmentService:IDepartmentService{
    private readonly IDepartmentRepository _departmentrepo;
    public DepartmentService( IDepartmentRepository departmentRepository){
        this._departmentrepo=departmentRepository;
    }
    public  async Task<List<Department>> GetAllDepartment()=> await _departmentrepo.GetAllDepartment();

    // public Employee GetEmployeeById(int id)=>_employeerepo.GetEmployeeById(id);

    // public void InsertEmployee(Employee employee)=>_employeerepo.InsertEmployee(employee);

    // public void DeleteEmployee(int id)=> _employeerepo.DeleteEmployee(id);

    // public void UpdateEmployee(Employee employee) => _employeerepo.UpdateEmployee(employee);
}