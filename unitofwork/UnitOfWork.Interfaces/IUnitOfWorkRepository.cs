using Repository.Interfaces;

namespace UnitOfWork.Interfaces {
	public interface IUnitOfWorkRepository {
		public IProductRepository productRepository { get; }
		public IClientRepository clientRepository { get; }
		public IInvoiceRepository invoiceRepository { get; }
		public IInvoiceDetailRepository invoiceDetailRepository { get; }
	}
}