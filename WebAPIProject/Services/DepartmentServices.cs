using WebAPIProject.Model;
using WebAPIProject.Repository;
using WebAPIProject.Services;

namespace WebAPIProject.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepository _repo;

        public DepartmentServices(IDepartmentRepository repo)
        {
            _repo = repo;
        }
        public int AddDepartment(Department department)
        {
            return _repo.AddDepartment(department);
        }
        public int DeleteDepartment(int id)
        {
            return (_repo.DeleteDepartment(id));
        }
        public IEnumerable<Department> GetAllDepartment()
        {
            return _repo.GetAllDepartments();
        }

        public Department GetDepartmentById(int id)
        {
            return _repo.GetDepartmentById(id);
        }

        public int UpdateDepartment(Department department)
        {
            return _repo.UpdateDepartment(department);
        }
    }

}

