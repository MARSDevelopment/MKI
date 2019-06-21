using System;
using System.Collections.Generic;
using System.Text;

namespace MK1
{
  public abstract class Context : IContext
  {
    protected Context() { }

    public abstract Guid ID { get; }
    public abstract string Name { get; }
  }
}
