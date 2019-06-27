using System;
using System.Collections.Generic;
using System.Text;

namespace MK1
{
  /// <summary>
  /// Base for Application Contexts
  /// </summary>
  public abstract class Context : IContext
  {
    protected Context() { }

    public abstract Guid ID { get; }
    public abstract string Name { get; }
  }
}
