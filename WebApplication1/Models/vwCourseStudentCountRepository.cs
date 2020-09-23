using System;
using System.Linq;
using System.Collections.Generic;

namespace WebApplication1.Models
{
	public  class vwCourseStudentCountRepository : EFRepository<vwCourseStudentCount>, IvwCourseStudentCountRepository
	{

	}

	public  interface IvwCourseStudentCountRepository : IRepository<vwCourseStudentCount>
	{

	}
}