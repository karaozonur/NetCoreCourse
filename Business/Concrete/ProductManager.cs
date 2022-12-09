using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public void Add(Product product)
        {
            //Daha önce ekelenen ürün vs filtremesi
             _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Get(int productID)
        {
            //EFProductDal p = new EFProductDal();
            return _productDal.Get(filter: _productDal => _productDal.ProductID == productID);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList().ToList();
        }

        public List<Product> GetListByCategory(int categoryID)
        {
            return _productDal.GetList().Where(z=>z.CategoryId==categoryID).ToList();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
