using WebAPIProject.Data;
using WebAPIProject.Model;

namespace WebAPIProject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public EmployeeRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            int res = _dbContext.SaveChanges();
            return res;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var emp = _dbContext.Employees.Find(id);
            if (emp != null)
            {
                _dbContext.Employees.Remove(emp);
                res = _dbContext.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = _dbContext.Employees.Find(id);
            return emp;
        }

        public int UpdateEmployee(Employee employee)
        {
            int res = 0;
            var e = _dbContext.Employees.Where(X => X.Eid == employee.Eid).FirstOrDefault();
            if (e != null)
            {
                e.Eid = employee.Eid;
                e.Ename = employee.Ename;
                e.salary = employee.salary;
                e.Deptid = employee.Deptid;
                res = _dbContext.SaveChanges();
            }
            return res;
        }
    }
}
