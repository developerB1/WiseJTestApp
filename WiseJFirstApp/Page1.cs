using Wisej.Web;
using WiseJFirstApp.Components;

namespace WiseJFirstApp
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void navigationBar1_MouseMove(object sender, MouseEventArgs e)
        {
            this.navigationBar1.CompactView = !this.navigationBar1.CompactView;
        }

        private void btnShowToast_Click(object sender, System.EventArgs e)
        {
            D4Toast.Show("Task abgeschlossen", "Der Hintergrundprozess wurde erfolgreich beendet.");
        }
    }
}
