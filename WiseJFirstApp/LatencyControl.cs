using System;
using System.Drawing;
using Wisej.Web;

namespace WiseJFirstApp
{

    public partial class LatencyControl : Wisej.Web.UserControl
    {
        private DateTime _requestStart;
        private Timer _timer;

        public LatencyControl()
        {
            InitializeComponent();
            this.labelLatency.Text = "Warte...";
            _timer = new Timer();
            _timer.Interval = 5000; // 5000 ms = 5 Sekunden
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _requestStart = DateTime.Now;
            this.Invoke(new Action(() => InvokeCallback(DateTime.Now)));
        }


        private void InvokeCallback(object result)
        {
            double latency = (DateTime.Now - _requestStart).TotalMilliseconds;

            this.labelLatency.Text = $"{latency:N0} ms";

            if (latency < 50)
                this.pictureBoxIcon.ForeColor = Color.Green;
            else if (latency < 150)
                this.pictureBoxIcon.ForeColor = Color.Yellow;
            else
                this.pictureBoxIcon.ForeColor = Color.Red;
        }

    }
}
