using System.ComponentModel.DataAnnotations;
using Domain.Blog;

namespace Domain;

public class Program
{
  public static void Main(string[] args)
  {
    Blog.Blog blog = new()
    {
      Url = "a",
      Email = "um-email-invalido"
    };

    var validationContext = new ValidationContext(blog);
    var validationResults = new List<ValidationResult>();

    bool isValid = Validator.TryValidateObject(blog, validationContext, validationResults, true);

    if (!isValid)
    {
      Console.WriteLine("O objeto Blog é inválido:");
      foreach (var validationResult in validationResults)
      {
        Console.WriteLine($"- {validationResult.ErrorMessage}");
      }
    }
    else
    {
      Console.WriteLine("O objeto Blog é válido.");
    }
  }
}