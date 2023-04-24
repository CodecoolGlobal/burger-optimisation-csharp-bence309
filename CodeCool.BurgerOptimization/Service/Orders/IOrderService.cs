using CodeCool.BurgerOptimization.Model;

namespace CodeCool.BurgerOptimization.Service.Orders;

public interface IOrderService
{
    void AddBurger(Burger burger);
    Queue<Meal> ProcessOrders();
}
