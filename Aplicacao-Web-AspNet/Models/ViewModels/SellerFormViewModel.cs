using System.Collections;
using System.Collections.Generic;

namespace Aplicacao_Web_AspNet.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
