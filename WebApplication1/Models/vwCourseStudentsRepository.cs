using System;
using System.Linq;
using System.Collections.Generic;

namespace WebApplication1.Models
{
	public  class vwCourseStudentsRepository : EFRepository<vwCourseStudents>, IvwCourseStudentsRepository
	{

	}

	public  interface IvwCourseStudentsRepository : IRepository<vwCourseStudents>
	{

	}
}