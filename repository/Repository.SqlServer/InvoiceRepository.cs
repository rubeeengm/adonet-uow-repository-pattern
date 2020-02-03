using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository.SqlServer {
	public class InvoiceRepository : Repository, IInvoiceRepository {

		public InvoiceRepository(SqlConnection context, SqlTransaction transaction) {
			this._context = context;
			this._transaction = transaction;
		}

		public void create(Invoice t) {
			throw new NotImplementedException();
		}

		public void delete(int id) {
			throw new NotImplementedException();
		}

		public Invoice get(int id) {
			var result = new Invoice();
			var command = createCommand("SELECT * FROM INVOICES WHERE ID = @ID");
			command.Parameters.AddWithValue("@ID", id);

			using (var reader = command.ExecuteReader()) {
				reader.Read();

				result.id = Convert.ToInt32(reader["ID"]);
				result.iva = Convert.ToDecimal(reader["IVA"]);
				result.subTotal = Convert.ToDecimal(reader["SUBTOTAL"]);
				result.total = Convert.ToDecimal(reader["TOTAL"]);
				result.clientId = Convert.ToInt32(reader["CLIENTID"]);
			}

			return result;
		}

		public IEnumerable<Invoice> getAll() {
			throw new NotImplementedException();
		}

		public void update(Invoice t) {
			throw new NotImplementedException();
		}
	}
}
