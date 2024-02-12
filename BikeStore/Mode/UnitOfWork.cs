using BikeStore.Interfaces;

namespace BikeStore.Mode
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategories Categories { get; set; }

        public UnitOfWork(ICategories Categories)
        {
            this.Categories = Categories;
        }
    }
}
