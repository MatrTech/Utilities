// public interface IGenericFactory
// {
// #if NETSTANDARD2_1
//     public List<(Type, object?)> GetRegisteredServices();
// #else
//     public List<(Type, object)> GetRegisteredServices();
// #endif
//     public virtual T Create<T>();
//     public virtual void RegisterOrReplaceService<TService>(TService service);
//     public virtual void EmptyDependencies();
//     public virtual void RemoveService<TService>();
//     public virtual bool IsRegistered<T>();

// }