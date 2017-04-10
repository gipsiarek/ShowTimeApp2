using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class SendMessageCmd : AbstractCommand
    {
        DataSet ds;
        MessageSenderViewModel msvm;
        public SendMessageCmd(DataSet ds)
        {
            this.ds = ds;
        }
        public SendMessageCmd(DataSet ds, MessageSenderViewModel msvm) : this(ds)
        {
            this.msvm = msvm;
        }
        public override Func<object, bool> CanExecuteAction
        {
            get
            {
                return (param) =>
                {
                    return param!=null && !string.IsNullOrEmpty(param.ToString());
                };
            }
        }

        public override Action<object> ExecuteAction
        {
            get
            {
                return (param) =>
                {
                    if(param!=null)
                        ds.MessageForPresenter = param.ToString();  
                    if (msvm != null) msvm.Message = "";
                };
            }
        }
    }
}
