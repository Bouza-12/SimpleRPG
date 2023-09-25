using Engine;

namespace UI
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);

            lbl_hitPoints.Text = _player.CurrentHitPoints.ToString();
            lbl_Gold.Text = _player.Gold.ToString();
            lbl_Experience.Text = _player.ExperiencePoints.ToString();
            lbl_Level.Text = _player.Level.ToString();

            Location location = new Location(1, "Home", "This is your house");

        }



    }
}