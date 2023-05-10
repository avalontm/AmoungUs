
using System.Diagnostics;

namespace AmoungUs
{
    public partial class FrmMain : Form
    {
        AmoungUS process { set; get; }

        public FrmMain()
        {
            InitializeComponent();
            process = new AmoungUS();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            process.Init();

            if (process.Load())
            {
                TxtName.Text = process.Players[0].Name;
                TxtRol.Text = process.Players[0].Rol.ToString();
                TxtTeam.Text = process.Players[0].Team.ToString();
                TxtNivel.Text = process.Players[0].Level.ToString();
            }
        }
    }
}