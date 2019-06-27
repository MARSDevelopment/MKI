using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MK1.MVVM
{
  /// <summary>
  /// Base for Commands 
  /// </summary>
  public class RelayCommand : ICommand
  {
    private readonly Action action;

    /// <summary>
    /// The event fired when <see cref="CanExecute(object)"/> value has changed
    /// </summary>
    public event EventHandler CanExecuteChanged = (sender, e) => { };

    /// <summary>
    /// Default Constructor
    /// </summary>
    /// <param name="action"></param>
    public RelayCommand(Action action) => this.action = action;

    /// <summary>
    /// A relay command can always execute
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    public virtual bool CanExecute(object parameter) => true;

    /// <summary>
    /// Executes the command's Action
    /// </summary>
    /// <param name="parameter"></param>
    public void Execute(object parameter) => action();
    
  }
}
