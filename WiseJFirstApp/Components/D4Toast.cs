using System;
using System.Diagnostics;
using Wisej.Web;

namespace WiseJFirstApp.Components
{
    public class D4Toast
    {
        public enum ToastIcon
        {
            None,
            Info
        }

        public string Title { get; set; }
        public string Message { get; set; }

        public static void Show(string title, string message)
        {
            Show(title, message, ToastIcon.Info, string.Empty);
        }
        public static void Show(string title, string message, ToastIcon icon, string stackTrace)
        {
            var toastConfig = new Toast
            {
                Text = $"<b>{title}</b><br>{message}",
                AllowHtml = true,
                BackColor = System.Drawing.Color.FromArgb(51, 122, 183),
                IconSource = "resource.wx/WiseJ.Ext.FontAwesome/info.svg",

            };
            toastConfig.Show();

            var dlg = new D4ToastStackTrace("Toast Status", "Toast wird angezeigt. Wählen Sie eine Option:");
            dlg.ShowDialog();

            // Auswertung der Benutzerwahl:
            if (dlg.DialogResultCustom == CustomDialogResult.Close)
            {
                toastConfig.Close();
            }
            else if (dlg.DialogResultCustom == CustomDialogResult.ShowStackTrace)
            {
                // Zeigt den Stacktrace in einer einfachen MessageBox an.
                MessageBox.Show(stackTrace, "Stacktrace", MessageBoxButtons.OK);
                // Optional: Toast auch schließen, falls gewünscht.
                toastConfig.Close();
            }

            //var result = MessageBox.Show("Toast wird angezeigt. Möchten Sie es schließen?", "Toast Status", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    toastConfig.Close();
            //}

        }

    }
}
