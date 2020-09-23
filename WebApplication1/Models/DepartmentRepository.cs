using System;
using System.Linq;
using System.Collections.Generic;

namespace WebApplication1.Models
{
	public  class DepartmentRepository : EFRepository<Department>, IDepartmentRepository
	{

	}

	public  interface IDepartmentRepository : IRepository<Department>
	{

	}
}