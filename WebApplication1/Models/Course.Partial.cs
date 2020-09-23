using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Title.StartsWith("A") && this.Credits < 3)
            {
                yield return new ValidationResult("天龍國課程必須 Credits 大於等於 3", new[] { "Title" });
            }

            if (!this.Title.StartsWith("A") && this.Credits < 2)
            {
                yield return new ValidationResult("所有課程必須 Credits 大於等於 2", new[] { "Title" });
            }

            //yield return ValidationResult.Success;
        }

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