using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Interfaces;

namespace Core;

public abstract class Entity: IEntity
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public Guid Id { get; set; } = Guid.NewGuid();
  public DateTime CreatedAt { get; set; } = DateTime.Now;
}
