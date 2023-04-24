using CodeCool.BurgerOptimization.Service.Cooking;
using CodeCool.BurgerOptimization.Service.Menu;
using CodeCool.BurgerOptimization.Service.Orders;
using CodeCool.BurgerOptimization.UI;

namespace CodeCool.BurgerOptimization
{
    class Program
    {
        static void Main(string[] args)
        {
            ICookProvider cookProvider = new CookProvider();
            IMenuService menuService = new MenuService();
            ICookingService cookingService = new CookingService();
            IOrderService orderService = new OrderService(cookingService, cookProvider);

            BurgerOptimisationUi ui = new BurgerOptimisationUi(menuService, orderService, cookProvider);
            ui.Run();
        }
    }
}
    
