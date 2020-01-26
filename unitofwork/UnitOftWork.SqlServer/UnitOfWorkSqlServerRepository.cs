using System.Data.SqlClient;
using UnitOfWork.Interfaces;

namespace UnitOftWork.SqlServer {
	public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository {
		public UnitOfWorkSqlServerRepository(
			SqlConnection context, SqlTransaction transaction
		) {

		}
	}
}
