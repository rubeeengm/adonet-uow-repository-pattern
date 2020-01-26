using UnitOfWork.Interfaces;

namespace UnitOftWork.SqlServer {
	public class UnitOfWorkSqlServer : IUnitOfWork {
		public IUnitOfWorkAdapter create() {
			return new UnitOfWorkSqlServerAdapter();
		}
	}
}
