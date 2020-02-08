using Models;
using Repository.Interfaces.Actions;
using System.Collections.Generic;

namespace Repository.Interfaces {
	public interface IInvoiceDetailRepository 
		: IReadRepository<InvoiceDetail, int> {
		IEnumerable<InvoiceDetail> getAllByInvoiceId(int invoiceId);
	}
}
