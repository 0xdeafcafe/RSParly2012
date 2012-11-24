using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XBDMCom.Backend;

namespace XBDMCom.Metro.Dialogs
{
    public class MetroException
    {
        /// <summary>
        /// Show the exception error dialog window.
        /// </summary>
        /// <param name="ex">The exception to pass into the dialog.</param>
        public static void Show(Exception ex)
        {
            Settings.homeWindow.ShowMask();
            ControlDialogs.Exception exceptionDialog = new ControlDialogs.Exception(ex);
            exceptionDialog.Owner = Settings.homeWindow;
            exceptionDialog.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            exceptionDialog.ShowDialog();
            Settings.homeWindow.HideMask();
        }
    }
}