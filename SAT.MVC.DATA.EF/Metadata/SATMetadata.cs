using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace SAT.MVC.DATA.EF
{
    public class StudentMetadata
    {
        [Required(ErrorMessage = "* First Name is required")]
        [StringLength(20, ErrorMessage = "* First Name must be less than 20 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Last Name is required")]
        [StringLength(20, ErrorMessage = "* Last Name must be less than 20 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(15, ErrorMessage = "* Major must be less than 15 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string Major { get; set; }

        [StringLength(50, ErrorMessage = "* Address must be less than 50 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string Address { get; set; }

        [StringLength(25, ErrorMessage = "* City must be less than 25 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "* State must be less than 2 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string State { get; set; }

        [StringLength(10, ErrorMessage = "* Zip Code must be less than 10 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [StringLength(13, ErrorMessage = "* Phone number must be less than 13 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "* Please enter a valid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "* Email is required")]
        [StringLength(60, ErrorMessage = "* Email address must be less than 60 characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "* Please enter a valid email address")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "* Photo Url must be less than 100 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [DataType(DataType.ImageUrl, ErrorMessage = "* Please enter a image url")]
        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "* SSID is Required")]
        [Display(Name = "Student Status")]
        public int SSID { get; set; }
    }
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        [Display(Name = "Student Name")]
        public string FullName { get { return FirstName + " " + LastName; } }
    }

    public class StudentStatusMetaData
    {
        [Required(ErrorMessage = "* Student Status Name is Required")]
        [Display(Name = "Student Status")]
        [StringLength(30, ErrorMessage = "* Student Status must be less than 30 characters")]
        public string SSName { get; set; }
        [Display(Name = "Student Status Description")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(250, ErrorMessage = "* Student Status Description must be less than 250 characters")]
        public string SSDescription { get; set; }
    }

    [MetadataType(typeof(StudentStatusMetaData))]
    public partial class StudentStatus
    {

    }

    public class CourseMetadata
    {
        [Required(ErrorMessage = "* Course Name is Required")]
        [Display(Name = "Course Name")]
        [StringLength(50, ErrorMessage = "* Course Name must be less than 50 characters")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "* Course Description is Required")]
        [Display(Name = "Course Description")]
        [StringLength(int.MaxValue)]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "* Number of Credit Hours is required")]
        [Display(Name = "Credit Hours")]
        [Range(1, 15, ErrorMessage = "* Credit Hours must be between 1 and 15 hours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "* Curriculum must be less than 250 characters")]
        public string Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "* Notes must be less than 500 characters")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "* Course Status is Required")]
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {

    }

    public class ScheduledClassStatusMetadata
    {
        [Required(ErrorMessage = "* Class Status is required")]
        [Display(Name = "Scheduled Class Status")]
        [StringLength(50, ErrorMessage = "* Class Status must be less than 50 characters")]
        public string SCSName { get; set; }
    }

    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus
    {

    }

    public class ScheduledClassMetadata
    {
        [Required(ErrorMessage = "* Course ID is required")]
        [Display(Name = "Course")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "* Course Start Date is Required")]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime StartDate { get; set; }

        [Required(ErrorMessage = "* Course End Date is Required")]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage = "* Instructor Name is Required")]
        [Display(Name = "Instructor")]
        [StringLength(40, ErrorMessage = "* Instructor Name must be less than 40 characters")]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "* Location is Required")]
        [StringLength(20, ErrorMessage = "* Location must be less than 20 characters")]
        public string Location { get; set; }

        [Required(ErrorMessage = "* Scheduled Class Status is Required")]
        [Display(Name = "Scheduled Class Status")]
        public int SCSID { get; set; }
    }

    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
    {
        //public string CourseInfo { get { CourseInfo = StartDate + " " + Location + " " +  }; set; }
    }

    public class EnrollmentMetadata
    {
        [Required(ErrorMessage = "* Student ID is Required")]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "* Scheduled Class ID is Required")]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "* Enrollment Date is Required")]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime EnrollmentDate { get; set; }
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {
        //public string StudentEnrolled { get { StudentEnrolled = Student.FullName + "\n" +  }; set; }
    }
}
