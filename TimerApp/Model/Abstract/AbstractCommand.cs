using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TimerApp.Model.Abstract
{
    public abstract class AbstractCommand : AbstractViewModel, ICommand
    {
        public abstract Func<object, bool> CanExecuteAction { get; }

        public abstract Action<object> ExecuteAction { get; }

        private bool execInTry = true;

        /// <summary>
        /// In Debug ExecInTry  always be set on false;
        /// </summary>
        public bool ExecInTry { get { return execInTry; } set { execInTry = value; } }

        private Exception canExecEx;

        public Exception CanExecEx { get { return canExecEx; } }

        public virtual bool CanExecute(object parameter)
        {
            if (CanExecuteAction != null)
            {
#if DEBUG
                execInTry = false;
#endif

                if (execInTry)
                {
                    try
                    {
                        if (canExecEx != null)
                        {
                            canExecEx = null;
                            OnPropertyChanged(() => CanExecEx);
                        }
                        return CanExecuteAction(parameter);
                    }
                    catch (Exception ex)
                    {
                        canExecEx = ex;
                        OnPropertyChanged(() => CanExecEx);
                        return false;
                    }
                }
                else
                    return CanExecuteAction(parameter);
            }
            else
                return false;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public virtual void Execute(object parameter)
        {
            Action A = () => {
#if DEBUG
                execInTry = false;
#endif
                if (execInTry)
                {
                    try
                    {
                        if (UseTask && OnTaskStart != null) System.Windows.Application.Current.Dispatcher.Invoke(OnTaskStart, parameter);
                        ExecuteAction?.Invoke(parameter);
                        if (UseTask && OnTaskEnd != null) System.Windows.Application.Current.Dispatcher.Invoke(OnTaskEnd, parameter);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Application.Current.Dispatcher.Invoke((() => {
                            MessageBox.Show(ex.Message, this.ToString(), MessageBoxButton.OK, MessageBoxImage.Error );
                        }));
                    }
                    finally
                    {
                        try
                        {
                            finaly?.Invoke();
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Application.Current.Dispatcher.Invoke(() => {
                                MessageBox.Show(ex.Message, this.ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
                            });
                        }
                    }
                }
                else
                {
                    if (UseTask && OnTaskStart != null) System.Windows.Application.Current.Dispatcher.Invoke(OnTaskStart, parameter);
                    ExecuteAction?.Invoke(parameter);
                    if (UseTask && OnTaskEnd != null) System.Windows.Application.Current.Dispatcher.Invoke(OnTaskEnd, parameter);
                    finaly?.Invoke();
                }
            };

            if (UseTask)
                Task.Factory.StartNew(A);
            else
                A();
        }

        private Action finaly;

        public Action Finaly { set { finaly = value; } }

        private bool useTask;

        public bool UseTask
        {
            get { return useTask; }
            set { useTask = value; }
        }

        public Action<object> OnTaskStart { get; set; }
        public Action<object> OnTaskEnd { get; set; }
    }

}
