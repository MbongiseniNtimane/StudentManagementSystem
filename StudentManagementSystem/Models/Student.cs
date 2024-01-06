using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        [Key]
        [Display(Name ="Student Number")]
        [Required(ErrorMessage ="Student Number is required")]
        [StringLength(10,MinimumLength =10,ErrorMessage ="The Student Number may " + "only be 10 digits")]
        [RegularExpression("^[0-9]+$",ErrorMessage ="Only numbers are allowed ")]
        public string StudentNumber {  get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "The First name may " + "only be between 2 charecters and 40")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only charecters are allowed ")]
        public string FirstName { get; set;}

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "The Last Name may " + "only be between 2 charecters and 40")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only charecters are allowed ")]
        public string LastName { get; set;}

        [Display(Name = "Course")]
        public string Course { get; set;}

        [Display(Name ="Enrollment Date")]
        [Required(ErrorMessage = "Enrollment Date is required")]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set;}

    }
}
