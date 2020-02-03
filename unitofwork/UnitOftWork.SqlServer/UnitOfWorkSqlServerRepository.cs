using System.Data.SqlClient;
using Repository.Interfaces;
using Repository.SqlServer;
using UnitOfWork.Interfaces;

namespace UnitOftWork.SqlServer {
	public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository {
		public IProductRepository productRepository { get;  }
		public IClientRepository clientRepository { get;  }
		public IInvoiceRepository invoiceRepository { get; }
		public IInvoiceDetailRepository invoiceDetailRepository { get;  }

		public UnitOfWorkSqlServerRepository(
			SqlConnection context, SqlTransaction transaction
		) {
			clientRepository = new ClientRepository(context, transaction);
			productRepository = new ProductRepository(context, transaction);
			invoiceRepository = new InvoiceRepository(context, transaction);
			invoiceDetailRepository = new InvoiceDetailRepository(context, transaction);
		}
	}
}
