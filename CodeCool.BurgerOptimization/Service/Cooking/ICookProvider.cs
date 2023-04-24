using CodeCool.BurgerOptimization.Model;

namespace CodeCool.BurgerOptimization.Service.Cooking;

public interface ICookProvider
{
    List<Cook> Cooks { get; }

}
