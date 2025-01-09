using BeED.Data;
using BeED.Interfaces;
using BeED.Models;
using Dapper;

namespace BeED.Services
{
    public class ProductService : BaseConnection, IProduct
    {
        public ProductService(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<EntityResult<Product>> GetAllProduct()
        {
            EntityResult<Product> result = new EntityResult<Product>();

            try
            {
                string sql = "SELECT p.Id, p.Name, p.Price, c.Id CategoryId, c.Name CategoryName FROM Product as p JOIN Category as c ON p.CategoryID = c.Id";
                result.Value = await connection.QueryAsync<Product>(sql);

                string countSql = "SELECT count(*) FROM Product";
                result.TotalRows = await connection.ExecuteScalarAsync<int>(countSql);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return result;
        }
    }
}
