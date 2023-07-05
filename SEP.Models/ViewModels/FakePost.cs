using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Models.ViewModels
{
    public class FakePost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Decimal Rate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int HoursId { get; set; }
        public WeekHour Hours { get; set; }
        public List<FakePost> FakePosts { get; set; }

    }
}
