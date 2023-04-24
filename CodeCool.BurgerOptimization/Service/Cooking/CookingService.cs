using CodeCool.BurgerOptimization.Model;

namespace CodeCool.BurgerOptimization.Service.Cooking;

public class CookingService : ICookingService
{
    private readonly Dictionary<Cook, int> _workLoadMap = new();

    public Queue<Meal> CookOrders(Queue<Order> orders, List<Cook> cooks)
    {
        return null;
    }

    private void InitializeWorkLoadMap(IEnumerable<Cook> cooks)
    {
        foreach (Cook cook in cooks)
        {
            _workLoadMap[cook] = 0;
        }
    }

    private void AddWorkLoad(Cook cook, int workLoad)
    {
        _workLoadMap[cook] += workLoad;
    }

    private void ResetWorkLoadMap()
    {
        _workLoadMap.Clear();
    }
}
