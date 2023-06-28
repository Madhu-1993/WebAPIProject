
using WebAPIProject.Data;
using WebAPIProject.Model;
using WebAPIProject.Repository;

namespace WebAPIProject.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public DepartmentRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddDepartment(Department department)
        {
            _dbContext.Departments.Add(department);
            int res = _dbContext.SaveChanges();
            return res;
        }

        public int DeleteDepartment(int id)
        {
            int res = 0;
            var department = _dbContext.Departments.Find(id);
            if (department != null)
            {
                _dbContext.Departments.Remove(department);
                res = _dbContext.SaveChanges();
            }

            return res;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _dbContext.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            var department = _dbContext.Departments.Find(id);
            return department;
        }

        public int UpdateDepartment(Department department)
        {
            int res = 0;
            var p = _dbContext.Departments.Where(x => x.Deptid == department.Deptid).FirstOrDefault();
            if (p != null)
            {
                p.Deptid = department.Deptid;
                p.Deptname = department.Deptname;
                res = _dbContext.SaveChanges();
            }
            return res;
        }
    }
}
