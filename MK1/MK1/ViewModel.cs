using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MK1
{
  /// <summary>
  /// Base for ViewModels
  /// </summary>
  public abstract class ViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
      PropertyChanged?.Invoke(this, e);
    }

    protected void OnPropertyChanged<T>(string propertyName, T previousValue, T currentValue)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs<T>(propertyName, previousValue, currentValue));
    }

  }


  public class PropertyChangedEventArgs<T> : PropertyChangedEventArgs
  {
    public T PreviousValue { get; private set; }

    public T CurrentValue { get; private set; }

    public PropertyChangedEventArgs(string propertyName, T previousValue, T currentValue)
        : base(propertyName)
    {
      this.PreviousValue = previousValue;
      this.CurrentValue = currentValue;
    }
  }

}
