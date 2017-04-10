using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class GetBgImageFileCmd : AbstractCommand
    {
        DataSet ds;
        PreviewSettingsViewModel psvm;
        public GetBgImageFileCmd(DataSet ds)
        {
            this.ds = ds;
        }
        public GetBgImageFileCmd(DataSet ds, PreviewSettingsViewModel psvm)
        {
            this.ds = ds;
            this.psvm = psvm;
        }
        public override Func<object, bool> CanExecuteAction
        {
            get
            {
                return (param) =>
                {
                    return param!=null;
                };
            }
        }

        public override Action<object> ExecuteAction
        {
            get
            {
                return (param) =>{

                    if (param.ToString() == "CLR_BG")
                        ds.Settings.BackgroundPreviewFile = "";
                    else if (param.ToString() == "CLR_LOGO")
                        ds.Settings.LogoPreviewFile = "";
                    else if (param.ToString() == "CLR_ALERT")
                        ds.Settings.AlertPreviewFile = "";
                    else
                    {
                        OpenFileDialog dlg = new OpenFileDialog();

                        dlg.DefaultExt = ".png";
                        dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif;";
                        //ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                        //dlg.Filter = string.Format("{0}| All image files ({1})|{1}|All files|*",
                        //    string.Join("|", codecs.Select(codec =>
                        //    string.Format("{0} ({1})|{1}", codec.CodecName, codec.FilenameExtension)).ToArray()),
                        //    string.Join(";", codecs.Select(codec => codec.FilenameExtension).ToArray()));

                        // Display OpenFileDialog by calling ShowDialog method 
                        Nullable<bool> result = dlg.ShowDialog();

                        if (result == true)
                        {
                            if (param != null)
                            {
                                if (param.ToString() == "BACKGROUND")
                                    ds.Settings.BackgroundPreviewFile = dlg.FileName;
                                else if (param.ToString() == "LOGO")
                                    ds.Settings.LogoPreviewFile = dlg.FileName;
                                else if (param.ToString() == "ALERT")
                                    ds.Settings.AlertPreviewFile = dlg.FileName;
                            }
                        }
                    }

                    if (psvm != null)
                    {
                        psvm.LogoFile = ds?.Settings?.LogoPreviewFile?.Split('\\')[ds.Settings.LogoPreviewFile.Count(x => x == '\\')];
                        psvm.BgFile = ds?.Settings?.BackgroundPreviewFile?.Split('\\')[ds.Settings.BackgroundPreviewFile.Count(x => x == '\\')];
                        psvm.AlertFile = ds?.Settings?.AlertPreviewFile?.Split('\\')[ds.Settings.AlertPreviewFile.Count(x => x == '\\')];
                    }
                };
            }
        }
    }
}
