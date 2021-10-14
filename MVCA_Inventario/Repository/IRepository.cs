using MVCA_Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCA_Inventario.Repository
{
    public interface IRepository
    {
        List<Product> GetProducts();
        string addProduct(Product ProdDetails);
        string updateProduct(Product ProdDetails);
        string deleteProduct(Product ProdDetails);
    }

}
