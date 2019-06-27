using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MK1.MVVM
{
  /// <summary>
  /// Base for ViewModels
  /// </summary>
  public abstract class ViewModel : INotifyPropertyChanged
  {
    /// <summary>
    /// Event fired when the property is changed
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Executes the property changed event
    /// </summary>
    /// <param name="propertyName"></param>
    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged?.Invoke(this, e);

    /// <summary>
    /// Executes the property changed event
    /// </summary>
    /// <param name="propertyName"></param>
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }

}
