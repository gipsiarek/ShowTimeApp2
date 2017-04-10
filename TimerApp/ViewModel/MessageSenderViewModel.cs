using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerApp.Command;
using TimerApp.Model;
using TimerApp.Model.Abstract;

namespace TimerApp.ViewModel
{
    public class MessageSenderViewModel : AbstractViewModel
    {
        PreviewViewModel tvm;
        DataSet ds;
        string message;
        SendMessageCmd sendMessageCmd;


        public MessageSenderViewModel(DataSet ds, PreviewViewModel tvm)
        {
            this.tvm = tvm;
            this.ds = ds;
        }
        public DataSet Ds => ds;
        public PreviewViewModel Tvm
        {
            get { return tvm; }

            set
            {
                tvm = value;
                OnPropertyChanged(() => Tvm);
            }
        }

        public string Message
        {
            get { return message; }

            set
            {
                message = value;
                OnPropertyChanged(() => Message);
            }
        }

        public SendMessageCmd SendMessageCmd
        {
            get
            {
                if (sendMessageCmd == null)
                    sendMessageCmd = new SendMessageCmd(ds, this);
                return sendMessageCmd;
            }
        }
    }
}
