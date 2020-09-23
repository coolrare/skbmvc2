using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {
        private class CourseMetadata
        {
            public int CourseID { get; set; }
            [Required]
            [MaxLength(30)]
            [身分證字號]
            public string Title { get; set; }
            [Required]
            [Range(1, 5)]
            public int Credits { get; set; }
            public int DepartmentID { get; set; }
            [Required]
            public System.DateTime CreatedOn { get; set; }
        }
    }
}