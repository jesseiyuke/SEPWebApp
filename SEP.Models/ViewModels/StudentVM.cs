using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public string? cellPhone { get; set; }
        public string? Address { set; get; }
        [RegularExpression("(([0-9]{2})(0|1)([0-9])([0-3])([0-9]))([ ]?)(([ 0-9]{4})([ ]?)([ 0-1][8]([ ]?)[ 0-9]))", ErrorMessage = "Invalid ID number")]
        public string? IdNo { set; get; }
        public int? DriversLicense { set; get; }
        public string? CareerObjective { set; get; }
        public int? Gender { set; get; }
        public int? Race { set; get; }
        public int? Nationality { set; get; }
        public int? YearOfStudy { set; get; }
        public int? Faculty { set; get; }
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
