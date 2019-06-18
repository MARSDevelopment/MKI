using System;
using System.Collections.Generic;
using System.Text;

namespace MK1
{
  public abstract class Entity : IEntity
  {
    public Guid EntityID { get; set; }

    protected Entity() { }
  }
}
