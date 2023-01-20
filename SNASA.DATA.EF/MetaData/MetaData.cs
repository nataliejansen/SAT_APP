using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SNASA.DATA.EF.Models//.MetaData
{
    public class CourseMetadata
    {

        public int CourseId { get; set; }

        [Required(ErrorMessage = "* Course Name is required")]
        [StringLength(50)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = null!;

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "* Course Description is required")]
        [DataType(DataType.MultilineText)]
        public string CourseDescription { get; set; } = null!;

        [Display(Name = "Credit Hours")]
        [Required(ErrorMessage = "* Credit Hours is required")]
        [Range(0, byte.MaxValue)]
        public byte CreditHours { get; set; }

        [StringLength(250)]
        public string? Curriculum { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        [Display(Name = "Active?")]
        public bool IsActive { get; set; }

    }

    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

    }

    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }

        [Display(Name = "Course")]
        public int CourseId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Instructor Name")]
        [StringLength(40)]
        public string InstructorName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string Location { get; set; } = null!;

        [Display(Name = "Scheduled Class Status")]
        public int Scsid { get; set; }
    }

    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }
        [Required]
        [Display(Name = "Scheduled Class Status")]
        [StringLength(50)]
        public string Scsname { get; set; } = null!;
    }

    public class StudentMetadata
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "* First Name is required")]
        [StringLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "* Last Name is required")]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [StringLength(50)]
        public string? Major { get; set; }

        [StringLength(50)]
        public string? Address { get; set; }

        [StringLength(25)]
        public string? City { get; set; }

        [StringLength(2)]
        public string? State { get; set; }

        [StringLength(5)]
        [DataType(DataType.PostalCode)]
        public string? ZipCode { get; set; }

        [StringLength(13)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required]
        [StringLength(60)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        public string? PhotoUrl { get; set; }
        public int Ssid { get; set; }
    }

    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Student Status Name")]
        public string Ssname { get; set; } = null!;

        [StringLength(250)]
        [Display(Name = "Student Status Description")]
        public string? Ssdescription { get; set; }
    }
}
