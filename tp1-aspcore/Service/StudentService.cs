using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tp1_aspcore.Models;
using tp1_aspcore.Repository;

namespace tp1_aspcore.Service
{
    internal class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> GetStudentByStudentNumberAsync(int studentNumber)
        {
            return await _studentRepository.GetStudentByStudentNumberAsync(studentNumber);
        }
    }
}
