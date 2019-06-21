using System;

namespace MK1.Database
{
  public interface IDBHandler
  {
    Guid HandlerID { get; set; }
    int DBVersion { get; set; }
  }
}
