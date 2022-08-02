using System;

namespace BestBuyBestPractices
{
    public class Department : IDepartmentRepository
    {
        public Department()
        {
        }

        public int ID { get; set };

        public string Name { get; set };

        public IEnumerable<Department> GetAllDepartments()
        {
            throw new NotImplementedException();
        }
    }
}

