using OnlineStore.Core.Models;
using OnlineStore.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Contracts
{
    public interface IOrderManager
    {
        void CreateOrder(Order order, List<BusketItemView> busketItems);
        List<Order> GetOrderList();
        Order GetOrder(string Id);
        void UpdateOrder(Order updatedOrder);

    }
}
