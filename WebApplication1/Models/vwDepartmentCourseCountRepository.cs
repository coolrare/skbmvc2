using System;
using System.Linq;
using System.Collections.Generic;

namespace WebApplication1.Models
{
	public  class vwDepartmentCourseCountRepository : EFRepository<vwDepartmentCourseCount>, IvwDepartmentCourseCountRepository
	{

	}

	public  interface IvwDepartmentCourseCountRepository : IRepository<vwDepartmentCourseCount>
	{

	}
}