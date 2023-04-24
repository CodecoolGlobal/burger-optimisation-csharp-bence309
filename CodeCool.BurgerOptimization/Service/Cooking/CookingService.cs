using System.Collections.Generic;
using System.Linq;
using CodeCool.BurgerOptimization.Model;

namespace CodeCool.BurgerOptimization.Service.Cooking
{
    public class CookingService : ICookingService
    {
        private readonly Dictionary<Cook, int> _workLoadMap = new();

        public Queue<Meal> CookOrders(Queue<Order> orders, List<Cook> cooks)
        {
            InitializeWorkLoadMap(cooks);
            var meals = new Queue<Meal>();

            while (orders.Any())
            {
                var order = orders.Dequeue();
                var availableCooks = FindAvailableCooks(order.Burger, cooks);
                var chosenCook = ChooseCook(availableCooks);

                AddWorkLoad(chosenCook, order.Burger.NumberOfDifferentIngredients);
                meals.Enqueue(new Meal(order, chosenCook));
            }

            ResetWorkLoadMap();
            return meals;
        }

        private List<Cook> FindAvailableCooks(Burger burger, List<Cook> cooks)
        {
            return cooks.Where(cook => cook.IngredientCapacity >= burger.NumberOfDifferentIngredients).ToList();
        }

        private Cook ChooseCook(List<Cook> availableCooks)
        {
            return availableCooks.OrderBy(cook => _workLoadMap[cook]).First();
        }

        private void InitializeWorkLoadMap(IEnumerable<Cook> cooks)
        {
            foreach (var cook in cooks)
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
}