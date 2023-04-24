using CodeCool.BurgerOptimization.Model;

namespace CodeCool.BurgerOptimization.Service.Menu;

public interface IMenuService
{
    List<Burger> GetAvailableBurgers(List<Cook> cooks);

}
