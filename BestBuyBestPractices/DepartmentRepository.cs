using System;
using System.Data;
using Dapper;

namespace BestBuyBestPractices
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public DepartmentRepository()
        {
        }

        //Constructor
        public DepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }
    }
}

