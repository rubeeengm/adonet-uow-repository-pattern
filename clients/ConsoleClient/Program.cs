using Services;
using UnitOftWork.SqlServer;

namespace ConsoleClient {
    class Program {
        static void Main(string[] args) {
			var unitOfWork = new UnitOfWorkSqlServer();
			var invoiceService = new InvoiceService(unitOfWork);

			//var result = invoiceService.get(2);
			var result2 = invoiceService.get(1);
		}
    }
}
