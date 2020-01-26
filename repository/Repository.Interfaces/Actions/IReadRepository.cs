using System.Collections.Generic;

namespace Repository.Interfaces.Actions {
	public interface IReadRepository<T,Y> where T : class {
		IEnumerable<T> getAll();
		T get(Y id);
	}
}
