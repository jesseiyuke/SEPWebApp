using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SEP.Models.ViewModels
{
    public class StudentVM
    {
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [StringLength(10, ErrorMessage = "Must be 10 digits")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Cellphone number must contain only numbers.")]
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        [StringLength(10, ErrorMessage = "Must be 10 digits")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Cellphone number must contain only numbers.")]
        [DisplayName("cellphone")]
        public string cellPhone { get; set; }
        [Required]
        [DisplayName("Address")]
        public string Address { set; get; }
        [RegularExpression("(([0-9]{2})(0|1)([0-9])([0-3])([0-9]))([ ]?)(([ 0-9]{4})([ ]?)([ 0-1][8]([ ]?)[ 0-9]))", ErrorMessage = "Invalid ID number")]
        public string? IdNo { set; get; }
        [Required]
        [DisplayName("Drivers License")]
        public int? DriversLicense { set; get; }
        public string? CareerObjective { set; get; }
        [Required]
        [DisplayName("Gender")]
        public int? Gender { set; get; }
        [Required]
        [DisplayName("Race")]
        public int? Race { set; get; }
        [Required]
        [DisplayName("Nationality")]
        public int? Nationality { set; get; }
        [Required]
        [DisplayName("Year of study")]
        public int? YearOfStudy { set; get; }
        [Required]
        [DisplayName("Faculty")]
        public int? Faculty { set; get; }
        [Required]
        [DisplayName("Department")]
        public int? Department { set; get; }
        public string? Skills { set; get; }
        public string? Achivements { set; get; }
        public string? Interests { set; get; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DriverLicenceList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GenderList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> RaceList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> NationalityList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> YearOfStudyList { get; set; }
        [ValidateNever]
        public IEnumerable<Department> DepartmentList { get; set; }
        [ValidateNever]
        public IEnumerable<Faculty> FacutyList { get; set; }
        public IEnumerable<Referees>? Referees { get; set; }
        public IEnumerable<Qualifications>? Qualification { get; set; }
        public IEnumerable<Experience>? Experience { get; set; }

    }
}
