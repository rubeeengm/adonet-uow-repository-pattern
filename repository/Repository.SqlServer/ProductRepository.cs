using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Models;
using Repository.Interfaces;

namespace Repository.SqlServer {
	public class ProductRepository : Repository, IProductRepository {

		public ProductRepository(SqlConnection context, SqlTransaction transaction) {
			this._context = context;
			this._transaction = transaction;
		}

		public Product get(int id) {
			var command = createCommand(
				"SELECT * FROM PRODUCTS WITH(NOLOCK) WHERE ID = @PRODUCTID"
			);

			command.Parameters.AddWithValue("@PRODUCTID", id);

			using (var reader = command.ExecuteReader()) {
				reader.Read();

				return new Product {
					id = Convert.ToInt32(reader["ID"])
					, price = Convert.ToDecimal(reader["PRICE"])
					 , name = reader["NAME"].ToString()
				};
			}
		}

		public IEnumerable<Product> getAll() {
			throw new System.NotImplementedException();
		}
	}
}