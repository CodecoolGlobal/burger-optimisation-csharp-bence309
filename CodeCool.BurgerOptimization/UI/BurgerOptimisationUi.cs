using CodeCool.BurgerOptimization.Model;
using CodeCool.BurgerOptimization.Service.Cooking;
using CodeCool.BurgerOptimization.Service.Menu;
using CodeCool.BurgerOptimization.Service.Orders;

namespace CodeCool.BurgerOptimization.UI;

public class BurgerOptimisationUi
{
    private readonly IMenuService _menuService;
    private readonly IOrderService _orderService;
    private readonly ICookProvider _cookProvider;

    public BurgerOptimisationUi(
        IMenuService menuService,
        IOrderService orderService,
        ICookProvider cookProvider)
    {
        _menuService = menuService;
        _orderService = orderService;
        _cookProvider = cookProvider;
    }

    public void Run()
    {
        List<Cook> cooks = _cookProvider.Cooks;
        List<Burger> availableBurgers = _menuService.GetAvailableBurgers(cooks);

        DisplayAvailableBurgers(availableBurgers);

        List<Burger> burgers = Orders(availableBurgers);

        AddOrdersToIOrderService(burgers);
        Queue<Meal> meals = PrepareOrders();
        DisplayMeals(meals);
    }

    private void DisplayAvailableBurgers(List<Burger> burgers)
    {
    }


    private void AddOrdersToIOrderService(List<Burger> burgers)
    {
    }

    private Queue<Meal> PrepareOrders()
    {
        return _orderService.ProcessOrders();
    }

    private static List<Burger> Orders(List<Burger> availableBurgers)
    {
        //randomly order some burgers
        return new List<Burger>
        {
            availableBurgers[1],
            availableBurgers[1],
            availableBurgers[2],
            availableBurgers[2],
            availableBurgers[1],
            availableBurgers[0],
            availableBurgers[0]
        };
    }

    private void DisplayMeals(Queue<Meal> meals)
    {
    }
}
