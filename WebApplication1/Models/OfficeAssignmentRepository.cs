using System;
using System.Linq;
using System.Collections.Generic;

namespace WebApplication1.Models
{
	public  class OfficeAssignmentRepository : EFRepository<OfficeAssignment>, IOfficeAssignmentRepository
	{

	}

	public  interface IOfficeAssignmentRepository : IRepository<OfficeAssignment>
	{

	}
}