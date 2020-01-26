namespace Repository.Interfaces.Actions {
	public interface IRemoveRepository<T> {
		void delete(T id);
	}
}
