using Core.Interfaces;

namespace Application.Exceptions;

public class InvalidArgumentException(string? layer) : Exception(
  layer != null ?
    $"Invalid Argument at Layer {layer}." :
    "Invalid Argument."), IApplicationError
{
  public int StatusCode { get; } = 400;
}