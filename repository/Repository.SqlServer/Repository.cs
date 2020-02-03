using System.Data.SqlClient;

namespace Repository.SqlServer {
	public abstract class Repository {
		protected SqlConnection _context;
		protected SqlTransaction _transaction;

		protected SqlCommand createCommand(string query) {
			return new SqlCommand(query, _context, _transaction);
		}
	}
}