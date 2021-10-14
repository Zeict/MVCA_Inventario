using MVCA_Inventario.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCA_Inventario.Repository
{
    public class Repository : IRepository
    {
        public string addProduct(Product ProdDetails)
        {
            string response = "";
            using (DBEntities Contexto = new DBEntities()) 
            {
                Contexto.Database.ExecuteSqlCommand("EXEC InsertProduct @Name, @Description, @Restriction, @Company, @Price, @Photo", new SqlParameter("@Name", ProdDetails.Name), new SqlParameter("@Description", ProdDetails.Description), new SqlParameter("@Restriction", ProdDetails.Restriction),
                    new SqlParameter("@Company", ProdDetails.Company), new SqlParameter("@Price", ProdDetails.Price), new SqlParameter("@Photo", ""));
                response = "Success";
            }
            return response;
        }

        public string deleteProduct(Product ProdDetails)
        {
            string response = "";
            using (DBEntities Contexto = new DBEntities())
            {
                Contexto.Database.ExecuteSqlCommand("EXEC DeleteProduct @ID", new SqlParameter("@ID", ProdDetails.ID));
                response = "Success";
                //will execute sp_DeleteStudentInfo 
            }
            return response;
        }

        public List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();
            using (DBEntities Contexto = new DBEntities())
            {
                list = Contexto.Product.AsNoTracking().ToList();
                //will execute sp_DeleteStudentInfo 
            }
            return list;
        }

        public string updateProduct(Product ProdDetails)
        {
            string response = "";
            using (DBEntities Contexto = new DBEntities())
            {
                Contexto.Database.ExecuteSqlCommand("EXEC UpdateProduct @ID,@Name, @Description, @Restriction, @Company, @Price, @Photo", new SqlParameter("@ID", ProdDetails.ID), new SqlParameter("@Name", ProdDetails.Name), new SqlParameter("@Description", ProdDetails.Description), new SqlParameter("@Restriction", ProdDetails.Restriction),
                    new SqlParameter("@Company", ProdDetails.Company), new SqlParameter("@Price", ProdDetails.Price), new SqlParameter("@Photo", ""));
                response = "Success";
            }
            return response;
        }
    }
}