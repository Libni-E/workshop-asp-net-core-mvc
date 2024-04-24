using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Aplicacao_Web_AspNet.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="{0} Requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="{0} deve ser entre {2} a {1}")] // chaves 0 pega o nome do atributo
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Enter com um {0} valido")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} Requerido")]
        public string  Email { get; set; }

        [Required(ErrorMessage = "{0} Requerido")]
        [Display (Name = "Birth Date")]
        [DataType (DataType.Date)]
        public DateTime BirthDate { get; set; }


        [Required(ErrorMessage = "{0} Requerido")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display (Name ="Base Salary")]
        [DataType(DataType.Currency)]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales  { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr) 
        {
            Sales.Add(sr);

        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
