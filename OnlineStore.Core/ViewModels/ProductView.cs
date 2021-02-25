using OnlineStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.ViewModels
{
    public class ProductView
    {
        public Product Product { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
