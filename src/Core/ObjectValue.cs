using FluentValidation;

namespace Core;

public abstract class ObjectValue<TValue>
{
  protected abstract AbstractValidator<TValue> Schema { get; }
  public TValue Value { get; private set; }

  protected ObjectValue(TValue value)
  {
    Validate(value);

    Value = value;
  }

  private void Validate(TValue value)
  {
    if (!Schema.Validate(value).IsValid)
    {
      throw new Exception();
    }
  }

  public TValue Set(TValue value)
  {
    Validate(value);

    Value = value;

    return value;
  }

  public override string ToString()
  {
    return Value?.ToString() ?? throw new Exception();
  }
}