using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;   
        }
        public IResult Add(Product product)
        {
            //Daha önce ekelenen ürün vs filtremesi
            _productDal.Add(product);
            return new SuccessResults(true, Messages.ProductAdd);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResults(true, Messages.ProductDelete);
        }

        //GET
        //public Product Get(int productID)
        //{
        //   
        //    return _productDal.Get(filter: _productDal => _productDal.ProductID == productID);
        //}
        public IDataResults<Product> Get(int productID)
        {
            return new SuccessDataResults<Product>(_productDal.Get(filter: _productDal => _productDal.ProductID == productID));
        }

       

        //public List<Product> GetList()
        //{
        //    return _productDal.GetList().ToList();
        //}

        public IDataResults<List<Product>> GetList()
        {
            return new SuccessDataResults<List<Product>> (_productDal.GetList().ToList());
        }
        public IDataResults<Product> GetByID(int productID)
        {
            return new SuccessDataResults<Product>(_productDal.Get(filter: p => p.ProductID == productID));
        }

        

        //public List<Product> GetListByCategory(int categoryID)
        //{
        //    return _productDal.GetList().Where(z=>z.CategoryId==categoryID).ToList();
        //}

        public IDataResults<List<Product>> GetListByCategory(int categoryID)
        {
            return new SuccessDataResults<List<Product>> (_productDal.GetList().Where(z => z.CategoryId == categoryID).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResults(true, Messages.ProductUpdate);
        }
    }
}
