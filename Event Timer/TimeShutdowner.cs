using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Event_Timer
{
    public partial class TimeShutdowner : Form
    {
        public Timer t = new Timer();
        public Event myEvent;
        public bool started = false;
        public string proccess;
        public string args;  
        public class Event
        {
            public DateTime Time;
            public DateTime Date;
            public string EventName;
        }

        public TimeShutdowner()
        {
            InitializeComponent();

            myEvent = new Event();
            eventName_ComboBox.SelectedIndex = 0;
            datePicker.Value = DateTime.Now;
            TimePicker.Value = DateTime.Now;

            StartTimers();
        }

        void StartTimers()
        {
            t.Tick += new EventHandler(T_Tick);
            t.Interval = 1000;
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void ShowApp()
        {       
            if(this.Opacity == 1)
            {
                Opacity = 0;
            }
            else
            {
                Opacity = 1;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SetEvent();
        }
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            SetEvent();
        }
        private void eventName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEvent();
        }

        void SetEvent()
        {
            started = false;
            myEvent = new Event { Time = TimePicker.Value, Date = datePicker.Value, EventName = eventName_ComboBox.SelectedItem.ToString() };
            preview_text.Text = "Event:\nnull";
            start_button.Enabled = true;
            start_button.Text = "Start";
            hide_Button.Visible = false;
        }

        private void startEvent_button(object sender, EventArgs e)
        {
            StartCounting();
        }
        void StartCounting()
        {
            started = true;
            start_button.Enabled = false;
            start_button.Text = "Started";
            preview_text.Text = $"Event:\n{myEvent.EventName}\nAt:{myEvent.Time.ToString("HH:mm:ss")}\nOn:{myEvent.Date.ToShortDateString()}";
            MessageBox.Show($"{myEvent.EventName} will be performed at: {myEvent.Time.ToShortTimeString()} days: {myEvent.Date.ToShortDateString()}\nNow you can minimize the window.", $"Success.", MessageBoxButtons.OK);
            hide_Button.Visible = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString();

            if (!started)
                return;
            
            DateTime now = DateTime.Now;
            if (myEvent.Date.Date == now.Date)
            {
                //Console.WriteLine("Same day: {0}", myEvent.Date.Date);
                if (myEvent.Time.ToString("HH:mm:ss") == now.ToString("HH:mm:ss"))
                {                 
                    //Console.WriteLine("Same time: {0}", myEvent.Time.TimeOfDay);
                    EventAction();
                }
            }
        }

        void EventAction()
        {
            switch (myEvent.EventName)
            {
                case "Shutdown":
                    proccess = "shutdown.exe";
                    args = "-s";
                    break;
                case "Restart":
                    proccess = "shutdown.exe";
                    args = "-r";
                    break;
                case "Logoff":
                    proccess = "shutdown.exe";
                    args = "-l";
                    break;
                case "Lock":
                    proccess = "Rundll32.exe";
                    args = "User32.dll, LockWorkStation";
                    break;
                case "Hibernation":
                    proccess = @"%windir%\system32\rundll32.exe";
                    args = "PowrProf.dll, SetSuspendState";
                    break;
                case "Sleep":
                    proccess = "Rundll32.exe";
                    args = "powrprof.dll, SetSuspendState 0,1,0";
                    break;
            }

            ProcessStartInfo startinfo = new ProcessStartInfo(proccess, args);
            Process.Start(startinfo);
        }

        private void hide_Button_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}