using System.ComponentModel.DataAnnotations;

namespace SEP.Models
{
    public enum Department
    {
        Accountancy,
        [Display(Name = "Business Sciences")] BusinessSciences,
        [Display(Name = "Economics and Finance")] EconomicsFinance,
        Law,
        [Display(Name = "Wits Business School")] BusinessSchool,
        [Display(Name = "Wits School of Governance")] Governance,

        [Display(Name = "Architecture and Planning")] Architecture,
        [Display(Name = "Civil & Environmental Engineering")] Civil,
        [Display(Name = "Chemical & Metallurgical Engineering")] Chemical,
        [Display(Name = "Construction Economics & Management")] Construction,
        [Display(Name = "Electrical & Information Engineering")] Electrical,
        [Display(Name = "Mechanical, Industrial & Aeronautical Engineering")] Mechanical,
        [Display(Name = "Mining Engineering")] Mining,


        [Display(Name = "Anatomical Sciences")] Anatomical,
        [Display(Name = "Clinical Medicine")] Clinical,
        [Display(Name = "Oral Health Sciences")] OralHealth,
        Pathology,
        Physiology,
        [Display(Name = "Public Health")] PublicHealth,
        [Display(Name = "Therapeutic Sciences")] Therapeutic,

        [Display(Name = "Wits School of Arts")] Arts,
        [Display(Name = "Wits School of Education")] Education,
        [Display(Name = "Human and Community Development")] HumanCommunity,
        [Display(Name = "Literature, Language and Media")] Literature,
        [Display(Name = "Social Sciences")] SocialSciences,

        [Display(Name = "Animal, Plant and Environmental Sciences")] AnimalPlantEnvironmental,
        Chemistry,
        [Display(Name = "Computer Science and Applied Mathematics")] ComputerScience,
        [Display(Name = "Geography, Archaeology and Environmental Sciences")] GeographyArchaeologyEnvironmental,
        Geosciences,
        Mathematics,
        [Display(Name = "Molecular and Cell Biology")] MolecularCellBiology,
        Physics,
        [Display(Name = "Statistics and Actuarial Science")] ActuarialScience

    }
}
