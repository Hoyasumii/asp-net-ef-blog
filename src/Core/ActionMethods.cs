using Core.Interfaces;

namespace Core;

public abstract class ActionMethods<ContextType, Args, Output>(ContextType context) : IActionMethods<ContextType, Args, Output> where ContextType : IDatabaseContext
{
  public ContextType Context { get; } = context;

  public abstract Output Method(Args content);

  // public abstract static Func<Args, Output> Run(ContextType context);
  // Eu acho que eu vou resolver isso com Extension Methods
}