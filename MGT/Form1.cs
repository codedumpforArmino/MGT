using System.Collections;
using System.Diagnostics;

namespace MGT
{
    public partial class Form1 : Form
    {
        ArrayList GameLibrary;
        ArrayList LogList;
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
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            Log newLog = new Log(cmb_Select.Items[cmb_Select.SelectedIndex].ToString(), DateTime.Now);
            LogList.Add(newLog);
            Debug.WriteLine(newLog.ToString());
        }

        private void updateSelection()
        {

        }

        
    }
}
