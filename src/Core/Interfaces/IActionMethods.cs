namespace Core.Interfaces;

public interface IActionMethods<out ContextType, in Args, out Output> where ContextType : IDatabaseContext
{
  public ContextType Context { get; }

  public Output Method(Args content);

  // public static Func<Args, Output> Run(ContextType context);
}