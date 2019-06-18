using System;
using System.Collections.Generic;
using System.Text;

namespace MK1.Utilities
{
  /// <summary>
  /// Reflects an error occuring from an Extension Method
  /// </summary>
  public class ExtensionException : Exception
  {
    public ExtensionException() { }

    public ExtensionException(string message) : base(message) { }

    public ExtensionException(string message, Exception innerException) : base(message, innerException) { }
  }
}
