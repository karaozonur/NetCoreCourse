using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBussinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<ProductManager>().As<IProductService>();
           builder.RegisterType<EFProductDal>().As<IProductDal>();

            builder.RegisterType<CategoriesManager>().As<ICategoriesService>();
            builder.RegisterType<EFCategoriesDal>().As<ICategoriesDal>();
        }
    }
}
