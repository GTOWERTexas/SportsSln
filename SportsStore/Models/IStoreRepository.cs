using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
   public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }// получение последовательности объектов Product// производный от IEnumerable// коллекция объектов
        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);

    }
}
