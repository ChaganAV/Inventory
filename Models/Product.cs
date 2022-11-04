using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Product
    {
        public int ProductID { get; set;}
        public string? Name { get; set;}
        public string? Serial {get; set;}

        public string? InvNumber {get; set;}

        [Display(Name = "Дата изготовления")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}
        
        public string? Bios {get; set;}
        public string? DallasAdmin {get; set;}
        public string? DallasOper {get; set;}
        public int DoctorID {get; set;}
        //public string? Doctor {get; set;}
        public string? Description {get; set;}
        public string? Category {get; set;}
        public int DepartmentID {get; set;}
        //public string? Department {get; set;}
    }
}