using System;
using System.Collections.Generic;
using System.Text;

namespace MK1.DBHandler
{
  internal interface IDBHandler
  {
    Guid HandlerID { get; set; }
    int DBVersion { get; set; }
  }
}
