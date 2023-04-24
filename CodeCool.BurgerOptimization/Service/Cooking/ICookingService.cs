using CodeCool.BurgerOptimization.Model;

namespace CodeCool.BurgerOptimization.Service.Cooking;

public interface ICookingService
{
    public Queue<Meal> CookOrders(Queue<Order> orders, List<Cook> cooks);
}
