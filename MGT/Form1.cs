using System.Collections;

namespace MGT
{
    public partial class Form1 : Form
    {
        ArrayList GameLibrary;
        //ArrayList LogList
        public Form1()
        {
            InitializeComponent();
            GameLibrary = GameLogger.LoadGameLibrary();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }
    }
}
