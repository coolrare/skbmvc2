using System;
using System.Linq;
using System.Collections.Generic;

namespace WebApplication1.Models
{
	public  class CourseRepository : EFRepository<Course>, ICourseRepository
	{
        //public override IQueryable<Course> All()
        //{
        //    return base.All().Where(p => p.IsEnabled == true);
        //}

        public Course Find(int id)
        {
			return this.All().Where(p => p.CourseID == id).First();
        }

		public List<Course> Get所有Git課程()
		{
			return this.All().Where(p => p.Title.Contains("Git")).ToList();
		}
	}

	public  interface ICourseRepository : IRepository<Course>
	{

	}
}