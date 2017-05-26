using nTierApplication.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTierApplication.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IDepartmentRepository Departments { get; }
        IGradeRepository Grades { get; }
        IInstructorRepository Instructors { get; }
        IStudentRepository Students { get; }
        int Complete();
    }
}
