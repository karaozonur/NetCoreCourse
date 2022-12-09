using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoriesService
    {
        IDataResults<Categories> Get(int CategoriesID);
        IDataResults<List<Categories>> GetList();
        IDataResults<List<Categories>> GetListByCategory(int CategoriesID);

        IDataResults<Categories> GetByID(int CategoriesID);

        IResult Add(Categories Categories);
        IResult Delete(Categories Categories);
        IResult Update(Categories Categories);
    }
}
