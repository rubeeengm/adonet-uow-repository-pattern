using Common;
using System.Data.SqlClient;
using UnitOfWork.Interfaces;

namespace UnitOftWork.SqlServer {
	public class UnitOfWorkSqlServerAdapter : IUnitOfWorkAdapter {
		private SqlConnection _context { get; set; }
		private SqlTransaction _transaction { get; set; }
		public IUnitOfWorkRepository repositories { get; set; }

		public UnitOfWorkSqlServerAdapter() {
			_context = new SqlConnection(Parameters.connectionString);
			_context.Open();

			_transaction = _context.BeginTransaction();
			repositories = new UnitOfWorkSqlServerRepository(_context, _transaction);
		}

		public void Dispose() {
			if (_transaction !=  null) {
				_transaction.Dispose();
			}

			if (_context != null) {
				_context.Close();
				_context.Dispose();
			}

			repositories = null;
		}

		public void saveChanges() {
			_transaction.Commit();
		}
	}
}
