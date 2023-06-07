using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SEP.Models.ViewModels
{
    public class StudentVM
    {
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        public string? cellPhone { get; set; }
        public string? Address { set; get; }
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
        public IEnumerable<SelectListItem> DepartmentList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> FacutyList { get; set; }

    }
}
