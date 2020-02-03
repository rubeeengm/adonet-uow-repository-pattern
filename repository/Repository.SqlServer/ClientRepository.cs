using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Models;
using Repository.Interfaces;

namespace Repository.SqlServer {
	public class ClientRepository : Repository, IClientRepository {

		public ClientRepository(SqlConnection context, SqlTransaction transaction) {
			this._context = context;
			this._transaction = transaction;
		}

		public Client get(int id) {
			var command = createCommand("SELECT * FROM CLIENTS WITH(NOLOCK) WHERE ID = @CLIENTID");
			command.Parameters.AddWithValue("@CLIENTID", id);

			using (var reader = command.ExecuteReader()) {
				reader.Read();

				return new Client {
					id = Convert.ToInt32(reader["ID"])
					, name = reader["NAME"].ToString()
				};
			}
		}

		public IEnumerable<Client> getAll() {
			throw new System.NotImplementedException();
		}
	}
}
