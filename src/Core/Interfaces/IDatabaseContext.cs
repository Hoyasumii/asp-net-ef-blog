using Microsoft.EntityFrameworkCore;

namespace Core.Interfaces;

public interface IDatabaseContext
{
  public Task<int> Save();
}