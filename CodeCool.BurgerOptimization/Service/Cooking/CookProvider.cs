using System.Collections.Generic;
using CodeCool.BurgerOptimization.Model;

namespace CodeCool.BurgerOptimization.Service.Cooking
{
    public class CookProvider : ICookProvider
    {
        public List<Cook> Cooks { get; }

        public CookProvider()
        {
            // initialize the list of cooks with varying skill levels
            Cooks = new List<Cook>
            {
                new Cook("Martha Stewart", 1, 5),
                new Cook("Jamie Oliver", 2, 6),
                new Cook("Gordon Ramsey", 1, 5)
            };
        }
    }
}
