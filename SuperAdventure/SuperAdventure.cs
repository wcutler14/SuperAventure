using System;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;        
        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player();
            _player.currentHitPoints = 10;
            _player.maxHitPoints = 10;
            _player.gold = 20;
            _player.experience = 0;
            _player.level = 1;
            lblHitPoints.Text = _player.currentHitPoints.ToString();
            lblGold.Text = _player.gold.ToString();
            lblExperience.Text = _player.experience.ToString();
            lblLevel.Text = _player.level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }
    }
}
