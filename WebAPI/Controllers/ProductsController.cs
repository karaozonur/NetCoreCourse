using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet(template:"getAll")]
        public IActionResult GetList()
        {
            var result=_productService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet(template: "getbyCategory")]
        public IActionResult getbyCategory(int categoryID)
        {
            var result = _productService.GetListByCategory(categoryID);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpGet(template: "getbyID")]
        public IActionResult getbyID(int categoryID)
        {
            var result = _productService.GetByID(categoryID);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpPost(template: "add")]
        public IActionResult add(Product PR)
        {
            var result = _productService.Add(PR);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpPost(template: "update")]
        public IActionResult update(Product PR)
        {
            var result = _productService.Update(PR);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPost(template: "delete")]
        public IActionResult delete(Product PR)
        {
            var result = _productService.Delete(PR);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
