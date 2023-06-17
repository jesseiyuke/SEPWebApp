using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SEP.Models.ViewModels
{
    public class JobPostVM
    {
        [ValidateNever]
        public JobPost JobPost { get; set; }
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        [ValidateNever]
        public IEnumerable<Faculty> FacultyList { get; set; }
        [ValidateNever]
        public IEnumerable<Department> DepartmentList { get; set; }
        [ValidateNever]

        public IEnumerable<JobType> JobTypeList { get; set; }
        [ValidateNever]

        public IEnumerable<WeekHour> WeekHourList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> StatusList { get; set; }

    }
}
