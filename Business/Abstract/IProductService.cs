using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        //IDataResults BAŞARILIMI BAŞARISIZMI

        IDataResults<Product> Get(int productID);
        IDataResults<List<Product>> GetList();
        IDataResults<List<Product>> GetListByCategory(int categoryID);


        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update (Product product);
    }
}
