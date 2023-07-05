using SEP.Models;
using Bogus;
using SEP.Models.ViewModels;

namespace SEP.DataAccess.Data
{
    public class FakeJobPost
    {
        Faker<FakePost>? faker = null;
        public List<FakePost> GenerateFakePost(int count)
        {
            if(faker == null)
            {
                int id = 0;
                faker = new Faker<FakePost>()
                    .RuleFor(s => s.Id, id++)
                    .RuleFor(s => s.Title, f => f.Name.JobTitle())
                    .RuleFor(s => s.Rate, f => f.Random.Decimal(50, 400))
                    .RuleFor(s => s.DepartmentId, f => f.Random.Number(1, 32))
                    .RuleFor(s => s.HoursId, f => f.Random.Number(1, 6));
            }

            return faker.Generate(count);
        }
        public Dictionary<string, decimal> GetAverageRateByDepartment(List<FakePost> fakePosts)
        {
            Dictionary<string, decimal> totalRateByDepartment = new Dictionary<string, decimal>();
            Dictionary<string, int> countByDepartment = new Dictionary<string, int>();

            foreach (var post in fakePosts)
            {
                string departmentName = post.Department.Name;

                if (!totalRateByDepartment.ContainsKey(departmentName))
                {
                    totalRateByDepartment[departmentName] = post.Rate;
                    countByDepartment[departmentName] = 1;
                }
                else
                {
                    totalRateByDepartment[departmentName] += post.Rate;
                    countByDepartment[departmentName]++;
                }
            }

            Dictionary<string, decimal> averageRateByDepartment = new Dictionary<string, decimal>();

            foreach (var department in totalRateByDepartment.Keys)
            {
                decimal totalRate = totalRateByDepartment[department];
                int count = countByDepartment[department];
                decimal averageRate = totalRate / count;
                averageRateByDepartment[department] = averageRate;
            }

            return averageRateByDepartment;
        }

        public Dictionary<string, decimal> GetAverageRateByWeekHour(List<FakePost> fakePosts)
        {
            Dictionary<string, decimal> totalRateByWeekHour = new Dictionary<string, decimal>();
            Dictionary<string, int> countByWeekHour = new Dictionary<string, int>();


            foreach (var post in fakePosts)
            {
 
                string hourName = post.Hours.Name;

                if (!totalRateByWeekHour.ContainsKey(hourName))
                {
                    totalRateByWeekHour[hourName] = post.Rate;
                    countByWeekHour[hourName] = 1;
                }
                else
                {
                    totalRateByWeekHour[hourName] += post.Rate;
                    countByWeekHour[hourName]++;
                }
            }

            Dictionary<string, decimal> averageRateByWeekHour = new Dictionary<string, decimal>();

            foreach (var weekHour in totalRateByWeekHour.Keys)
            {
                decimal totalRate = totalRateByWeekHour[weekHour];
                int count = countByWeekHour[weekHour];
                decimal averageRate = totalRate / count;
                averageRateByWeekHour[weekHour] = averageRate;
            }

            return averageRateByWeekHour;
        }

    }
}
