using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Models;
using Repository.Interfaces;

namespace Repository.SqlServer {
	public class InvoiceDetailRepository : Repository, IInvoiceDetailRepository {

		public InvoiceDetailRepository(SqlConnection context, SqlTransaction transaction) {
			this._context = context;
			this._transaction = transaction;
		}

		public InvoiceDetail get(int id) {
			throw new System.NotImplementedException();
		}

		public IEnumerable<InvoiceDetail> getAll() {
			throw new System.NotImplementedException();
		}

		public IEnumerable<InvoiceDetail> getAllByInvoiceId(int invoiceId) {
			var result = new List<InvoiceDetail>();
			var command = createCommand(
				"SELECT * FROM INVOICEDETAIL WITH(NOLOCK) WHERE INVOICEID = @INVOICEID"
			);
			command.Parameters.AddWithValue("@INVOICEID", invoiceId);

			using (var reader = command.ExecuteReader()) {
				while (reader.Read()) {
					result.Add(
						new InvoiceDetail {
							id = Convert.ToInt32(reader["ID"])
							, productId = Convert.ToInt32(reader["PRODUCTID"])
							, quantity = Convert.ToInt32(reader["QUANTITY"])
							, iva = Convert.ToDecimal(reader["IVA"])
							, subTotal = Convert.ToDecimal(reader["SUBTOTAL"])
							, total = Convert.ToDecimal(reader["TOTAL"])
						}
					);
				}
			}

			return result;
		}
	}
}
