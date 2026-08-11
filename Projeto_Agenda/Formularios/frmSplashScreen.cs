using Projeto_Agenda.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formularios
{
    public partial class frmSplashScreen : Form
    {
        private Timer timer;
        private SoundPlayer player;
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 1;
            player = new SoundPlayer(Resources.Aint_No_Party);
            player.Play();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if (this.Opacity <= 0)
            {
                timer.Stop();
                player.Stop();
                this.Hide();
                frmLogon login = new frmLogon();
                login.Show();
            }
        }
    }
}
