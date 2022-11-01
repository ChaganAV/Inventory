namespace Inventory.Models
{
    public class Product
    {
        public int ProductID { get; set;}
        public string Name { get; set;}
        public DateTime DateProiz {get; set;}
        
        public string? Bios {get; set;}
        public string? DallasAdmin {get; set;}
        public string? DallasOper {get; set;}
        public int DoctorID {get; set;}
        public string? Description {get; set;}
        public string? Category {get; set;}
        public int DepartmentID {get; set;}
    }
}