using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tp1_aspcore.Data;
using tp1_aspcore.Models;

namespace tp1_aspcore.Repository
{
    internal class StudentRepository :IStudentRepository
    {
        private readonly DbContext _context;

        public StudentRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<Student> GetStudentByStudentNumberAsync(int studentNumber)
        {
            return await _context.Set<Student>()
                .FromSqlRaw("EXEC GetStudentByStudentNumber @StudentNumber",
                            new SqlParameter("@StudentNumber", studentNumber))
                .FirstOrDefaultAsync();
        }
    }
}
