using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MediaPlayerSDM4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IList<string> GetKeys()
        {
            return new List<string>(this.tracknames.Keys);
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Dictionary<string, string> tracknames = new Dictionary<string, string>();

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL =tracknames[@track_list.Text];
            player.Ctlcontrols.play();
            lbl_msg.Text = "Playing...";
            timer1.Start();
            trackBar1.Value = 50;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.URL =tracknames[@track_list.Text];
            player.Ctlcontrols.play();
            lbl_msg.Text = "Playing...";
            timer1.Start();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            lbl_msg.Text = "Playback paused...";
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            lbl_msg.Text = "";
            lbl_track_start.Text = "00:00";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            }
            
        }

        private void lbl_track_start_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;
            if (ofd.ShowDialog()==DialogResult.Cancel)
                return;
            foreach(string s in ofd.FileNames)
            {
                tracknames.Add(Path.GetFileName(s), Path.GetFullPath(s));
            }
            track_list.DataSource = GetKeys();
            track_list.Refresh();
        }
    }
}
