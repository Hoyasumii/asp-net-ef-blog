using Core.Interfaces;

namespace Application.Shared.Exceptions;

public class ResourceNotFoundException(string? layer) : Exception(
  layer != null ?
    $"Resource Not Found Exception at {layer}." :
    "Resource Not Found Exception."), IApplicationError
{
  public int StatusCode { get; } = 404;
}