using Models;
using Repository.Interfaces.Actions;

namespace Repository.Interfaces {
	public interface IInvoiceRepository : ICreateRepository<Invoice>
		, IReadRepository<Invoice, int>
		, IUpdateRepository<Invoice>
		, IRemoveRepository<int> {

	}
}
