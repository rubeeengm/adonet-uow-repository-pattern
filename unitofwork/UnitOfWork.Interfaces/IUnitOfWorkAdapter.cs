using System;

namespace UnitOfWork.Interfaces {
	public interface IUnitOfWorkAdapter : IDisposable {
		IUnitOfWorkRepository repositories { get; }

		void saveChanges();
	}
}
