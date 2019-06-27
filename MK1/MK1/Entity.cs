using System;
using System.Collections.Generic;
using System.Text;

namespace MK1
{
  /// <summary>
  /// Base for Instantiated Objects
  /// </summary>
  public abstract class Entity : IEntity
  {
    public Guid EntityID { get; set; }
    public DateTime LastUpdatedDateTime { get; set; }

    protected Entity() { }
  }
}
