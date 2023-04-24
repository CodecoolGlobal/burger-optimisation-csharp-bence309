using CodeCool.BurgerOptimization.Service.Cooking;
using CodeCool.BurgerOptimization.Service.Menu;
using CodeCool.BurgerOptimization.Service.Orders;
using CodeCool.BurgerOptimization.UI;

ICookProvider cookProvider = null;
IMenuService menuService = new MenuService();
ICookingService cookingService = new CookingService();
IOrderService orderService = null;

BurgerOptimisationUi ui = new BurgerOptimisationUi(menuService, orderService, cookProvider);
ui.Run();
