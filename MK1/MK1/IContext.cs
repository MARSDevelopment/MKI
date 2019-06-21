using System;
using System.Collections.Generic;
using System.Text;

namespace MK1
{
  public interface IContext
  {
    Guid ID { get; }
    string Name { get; }
  }
}
