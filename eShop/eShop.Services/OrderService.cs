using eShop.Core.Contracts;
using eShop.Core.Models;
using eShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Services
{
    public class OrderService : IOrderService
    {
        IRepository<Order> orderContext;
        public OrderService(IRepository<Order> orderContext)
        {
            this.orderContext = orderContext;
        }
        public void CreateOrder(Order basketOrder, List<BasketItemViewModel> basketItems)
        {
            foreach(var item in basketItems)
            {
                basketOrder.OrderItems.Add(new OrderItem()
                {
                    ProductId = item.Id,
                    Image = item.Image,
                    Price = item.Price,
                    ProductName = item.ProductName,
                    Quantity = item.Quantity,

                });

                orderContext.Insert(basketOrder);
                orderContext.Commit();
            }
        }
    }
}
