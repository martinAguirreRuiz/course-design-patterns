using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;

namespace DesignPatternsAsp.Strategies
{
    public class BeerStrategyContext
    {
        private IBeerStrategy _strategy;
        public IBeerStrategy Strategy { set { _strategy = value; } }
        public BeerStrategyContext (IBeerStrategy strategy)
        {
            _strategy = strategy;
        }
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVM, unitOfWork);  
        }
    }
}
