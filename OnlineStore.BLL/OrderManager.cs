using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Core.Models;
using OnlineStore.Core.Contracts;
using OnlineStore.Core.ViewModels;

namespace OnlineStore.BLL
{
    public class OrderManager : IOrderManager
    {
        IRepository<Order> orderContext;

        public OrderManager(IRepository<Order> orderContext)
        {
            this.orderContext = orderContext;
        }

        public void CreateOrder(Order order, List<BusketItemView> busketItems)
        {
            foreach (var item in busketItems)
            {
                order.OrderItems.Add(new OrderItem()
                {
                    ProductId = item.Id,
                    ProductName = item.ProductName,
                    Image = item.Image,
                    Price = item.Price,                    
                    Quantity = item.Quantity                    
                });

                orderContext.Insert(order);
                orderContext.Commit();
            }
        }
    }
}
