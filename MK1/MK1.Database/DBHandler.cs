using System;
using System.Collections.Generic;
using System.Text;

namespace MK1.Database
{
  class DBHandler : IDBHandler
  {
    public Guid HandlerID { get; set; }
    public int DBVersion { get; set; }
  }
}
