using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Product
    {
        public int ProductID { get; set;}

        [Display(Name = "Наименование")]
        public string? Name { get; set;}

        [Display(Name = "Серийный номер")]
        public string? Serial {get; set;}

        [Display(Name = "Инвентарный номер")]
        public string? InvNumber {get; set;}

        [Display(Name = "Дата изготовления")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}
        
        [Display(Name = "Биос")]
        public string? Bios {get; set;}
        public string? DallasAdmin {get; set;}
        public string? DallasOper {get; set;}
        public int DoctorID {get; set;}
        //public string? Doctor {get; set;}

        [Display(Name = "Описание")]
        public string? Description {get; set;}

        [Display(Name = "Категория")]
        public string? Category {get; set;}
        
        public int DepartmentID {get; set;}
        //public string? Department {get; set;}
    }
}