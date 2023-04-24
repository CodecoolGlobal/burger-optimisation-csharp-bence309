using CodeCool.BurgerOptimization.Model;

namespace CodeCool.BurgerOptimization.Service.Menu;

public class MenuService : IMenuService
{
    private readonly List<Burger> _allBurgers;

    public MenuService()
    {
        _allBurgers = GenerateAllBurgers();
    }

    public List<Burger> GetAvailableBurgers(List<Cook> cooks)
    {
        return null;
    }

    private static List<Burger> GenerateAllBurgers()
    {
        return new List<Burger>
        {
            new("All in burger", 6),
            new("Vegan bean burger", 7),
            new("Light beef burger", 5),
            new("Cheeseburger", 4),
            new("Double cheese burger", 9),
            new("Meat lover burger", 8),
            new("Chilli cheese angus burger", 10),
            new("Impossible burger", 12)
        };
    }
}
