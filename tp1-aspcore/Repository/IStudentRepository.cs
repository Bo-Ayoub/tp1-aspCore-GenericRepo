using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp1_aspcore.Models;

namespace tp1_aspcore.Repository
{
    internal interface IStudentRepository 
    {
        Task<Student> GetStudentByStudentNumberAsync(int studentNumber);
    }
}
