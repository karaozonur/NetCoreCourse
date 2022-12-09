using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoriesManager : ICategoriesService
    {
        private ICategoriesDal _categoriesDal;

        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal = categoriesDal;
        }

        public IResult Add(Categories Categories)
        {
            _categoriesDal.Add(Categories);
            return new SuccessResults(true, Messages.ProductAdd);

        }

        public IResult Delete(Categories Categories)
        {
            _categoriesDal.Delete(Categories);
            return new SuccessResults(true, Messages.ProductDelete);

        }

        public IDataResults<Categories> Get(int CategoriesID)
        {
            return new SuccessDataResults<Categories>(_categoriesDal.Get(filter: _categoriesDal => _categoriesDal.CategoryId == CategoriesID));

        }

        public IDataResults<Categories> GetByID(int CategoriesID)
        {
            throw new NotImplementedException();
        }

        public IDataResults<List<Categories>> GetList()
        {
            return new SuccessDataResults<List<Categories>>(_categoriesDal.GetList().ToList());

        }

        public IDataResults<List<Categories>> GetListByCategory(int CategoriesID)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Categories Categories)
        {
            throw new NotImplementedException();
        }
    }
}
