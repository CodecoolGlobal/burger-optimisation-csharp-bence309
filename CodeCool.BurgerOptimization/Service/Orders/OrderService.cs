using System.Collections.Generic;
using CodeCool.BurgerOptimization.Model;
using CodeCool.BurgerOptimization.Service.Cooking;

namespace CodeCool.BurgerOptimization.Service.Orders
{
    public class OrderService : IOrderService
    {
        private readonly List<Order> _orders = new();

        private readonly ICookingService _cookingService;
        private readonly ICookProvider _cookProvider;

        public OrderService(ICookingService cookingService, ICookProvider cookProvider)
        {
            _cookingService = cookingService;
            _cookProvider = cookProvider;
        }

        public void AddBurger(Burger burger)
        {
            int orderId = _orders.Count + 1;
            var order = new Order(orderId, burger);
            _orders.Add(order);
        }

        public Queue<Meal> ProcessOrders()
        {
            var ordersQueue = new Queue<Order>(_orders);
            var cooks = _cookProvider.Cooks;
            var meals = _cookingService.CookOrders(ordersQueue, cooks);
            _orders.Clear();
            return meals;
        }
    }
}