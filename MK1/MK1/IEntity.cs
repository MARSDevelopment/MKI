using System;
using System.Collections.Generic;
using System.Text;

namespace MK1
{
  public interface IEntity
  {
    Guid EntityID { get; set; }
    DateTime LastUpdatedDateTime { get; set; }
  }
}
