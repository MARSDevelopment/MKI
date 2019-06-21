using System;
using System.ComponentModel;
using System.Reflection;

namespace MK1.Utilities
{
  public static class Utilities
  {
    /// <summary>
    /// Returns the Description Attribute assigned to an Enum as a string. Requires a Description Attribute to be assigned to the Enum with a non-whitespace value.
    /// </summary>
    /// <param name="value"></param>
    /// <exception cref="ExtensionException"></exception>
    /// <returns></returns>
    public static string ToFriendlyString(this Enum value)
    {
      Type type = value.GetType();
      string name = Enum.GetName(type, value);
      if (!string.IsNullOrEmpty(name))
      {
        FieldInfo field = type.GetField(name);
        if (field != null)
        {
          DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
          if (attr != null)
          {
            if (!string.IsNullOrWhiteSpace(attr.Description))
              return attr.Description;

            throw new ExtensionException($"Thr Description Attribute for the enum {type}.{value} is null, empty, or whitespace");
          }
          throw new ExtensionException($"A Description Attribute for the enum {type}.{value} could not be found.");
        }
        throw new ExtensionException($"An error occured retrieving the enum {type}.{value}'s field info.");
      }
      throw new ExtensionException($"The enum {type}.{value} does not exist.");

    }
  }
}
