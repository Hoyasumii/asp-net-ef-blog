namespace Core;

public class Email(string value) : ObjectValue<string>(value)
{
  protected override EmailValidator Schema { get; } = new();

  public static Email Make(string value)
  {
    return new(value);
  }
}
