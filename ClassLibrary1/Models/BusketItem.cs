using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Models
{
    public class BusketItem : BaseEntity
    {
        public string BusketId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
