using System.ComponentModel.DataAnnotations;

namespace SEP.Models
{
    public enum WeekHour
    {
        [Display(Name = "<2")] LessThanTwo,
        [Display(Name = "2 to 4")] TwoToFour,
        [Display(Name = "4 to 6")] FourToSix,
        [Display(Name = "6 to 8")] SixToEight,
        [Display(Name = "8 to 12")] EightToTwelve,
        [Display(Name = ">12")] GreaterThanTwelve,

    }
}
