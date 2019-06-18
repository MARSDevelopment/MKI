using System;

namespace MK1.DBHandler
{
  public class DBHandler : IDBHandler
  {
    public Guid HandlerID { get; set; }
    public int DBVersion { get; set; }
  }
}
