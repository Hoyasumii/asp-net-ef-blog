namespace Core.Interfaces;

public interface IService<RepositoryType, Args, Output> 
  where RepositoryType : IRepository<IDatabaseContext>
  where Args : IDataTransferObject
{
  public Task<Output> Run(Args data);
}
