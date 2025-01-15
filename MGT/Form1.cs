using System.Collections;
using System.Configuration;
using System.Diagnostics;

namespace MGT
{
    public partial class Form1 : Form
    {
        ArrayList GameLibrary;
        ArrayList LogList;
        Boolean isLogging = false;
        int minute;
        int second;
        public Form1()
        {
            InitializeComponent();
            GameLibrary = GameLogger.LoadGameLibrary();
            LogList = GameLogger.LoadLogList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(txtb_GameName.Text.ToString());
            GameLibrary.Add(newGame);
            cmb_Select.Items.Add(newGame.GetName());


            //verify game then add
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            String GameName = cmb_Select.Items[cmb_Select.SelectedIndex].ToString();
            Log newLog = new Log(GameName, DateTime.Now);
            LogList.Add(newLog);
            Debug.WriteLine(newLog.ToString());

            if (!isLogging)
            {
                minute = 0;
                second = 0;

                timer_LogLapsed.Start();//maybe we can switch to timer?
                isLogging = true;
            }
            else
            {
                txtBox_ConsoleOutput.AppendText(GameName + "played for " + second + "minutes!" + "\r\n");
                timer_LogLapsed.Stop();
                isLogging = false;
            }
        }
        private String translate_timer(int minute, int second)
        {
            Debug.WriteLine(minute + ":" + second);
            String S_minute = "";
            String S_second = "";


            S_minute = minute.ToString();
            if (minute <= 9)
            {
                S_minute = "0" + S_minute;
            }

            S_second = second.ToString();
            if (second <= 9)
            {
                S_second = "0" + S_second;
            }

            Debug.WriteLine("Actual -> " + S_minute + ":" + S_second);
            return S_minute + " : " + S_second;
        }

        private void updateSelection()
        {

        }

        private void timer_LogLapsed_Tick(object sender, EventArgs e)
        {
            second++;

            if (second >= 60)
            {
                minute++;
                second = 0;
            }

            txtBox_TimerOutput.Text = translate_timer(minute, second);
        }
    }
}
