using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SEP.Models.ViewModels
{
    public class JobPostVM
    {
        public JobPost JobPost { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> FacultyList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DepartmentList { get; set; }
        [ValidateNever]

        public IEnumerable<SelectListItem> JobTypeList { get; set; }
        [ValidateNever]

        public IEnumerable<SelectListItem> WeekHourList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> StatusList { get; set; }

    }
}
