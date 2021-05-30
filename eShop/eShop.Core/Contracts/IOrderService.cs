using eShop.Core.Models;
using eShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Core.Contracts
{
    public interface IOrderService
    {
        void CreateOrder(Order order, List<BasketItemViewModel> basketItems);
        Order GetOrder(string Id);
        List<Order> GetOrderList();
        void UpdateOrder(Order updateOrder);
    }
}
