using System.Drawing;
using Wisej.Web;

namespace WiseJFirstApp.Components
{
    public enum CustomDialogResult
    {
        Close,
        ShowStackTrace,
        Cancel
    }
    public class D4ToastStackTrace : Form
    {
        public CustomDialogResult DialogResultCustom { get; set; }
        public D4ToastStackTrace(string title, string message)
        {

            this.Text = title;
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            var lblMessage = new Label
            {
                Text = message,
                Dock = DockStyle.Top,
                Height = 50,
                AutoSize = false
            };

            var btnClose = new Button
            {
                Text = "Schließen",
                Dock = DockStyle.Bottom,
                Height = 30
            };
            btnClose.Click += (s, e) =>
            {
                DialogResultCustom = CustomDialogResult.Close;
                this.Close();
            };

            var btnStackTrace = new Button
            {
                Text = "Stacktrace anzeigen",
                Dock = DockStyle.Bottom,
                Height = 30
            };
            btnStackTrace.Click += (s, e) =>
            {
                DialogResultCustom = CustomDialogResult.ShowStackTrace;
                this.Close();
            };

            var btnCancel = new Button
            {
                Text = "Abbrechen",
                Dock = DockStyle.Bottom,
                Height = 30
            };
            btnCancel.Click += (s, e) =>
            {
                DialogResultCustom = CustomDialogResult.Cancel;
                this.Close();
            };

            this.Controls.Add(btnCancel);
            this.Controls.Add(btnStackTrace);
            this.Controls.Add(btnClose);
            this.Controls.Add(lblMessage);

        }

    }
}
