namespace Core.Interfaces;

public interface IService<RepositoryType, Args, Output> 
  where RepositoryType : IRepository<IDatabaseContext>
  where Args : IDataTransferObject
  where Output : IEntity
{
  public RepositoryType Repository { get; }

  public Task<Output> Run(Args data);
}
