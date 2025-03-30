using System.Windows.Forms;
using Target.Views;

namespace Target
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdicionarTapPages(string name, string text, UserControl userControl)
        {
            TabPage tabPage = new TabPage();
            userControl.Dock = DockStyle.Fill;
            tabPage.Name = name;
            tabPage.Text = text;
            tabPage.Controls.Add(userControl);
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectTab(tabPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageExercicio1";
            string text = "Exercicio 1";
            UserControlExercicio1 userControlExercicio1 = new UserControlExercicio1();
            AdicionarTapPages(name, text, userControlExercicio1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageExercicio2";
            string text = "Exercicio 2";
            UserControlExercicio2 userControlExercicio2 = new UserControlExercicio2();
            AdicionarTapPages(name, text, userControlExercicio2);
        }
    }
}
