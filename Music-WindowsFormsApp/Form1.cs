using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace Music_WindowsFormsApp
{
    public partial class MusicPlayer : Form
    {
        bool playing = false;
        int volume = 50;
        int song_index = 0;
        int current_song_index = -1;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public static IDictionary<int, Song> songs = new Dictionary<int, Song>();

        public MusicPlayer()
        {
            InitializeComponent();
            tbVolume.Value = 50;
            player.settings.volume = volume;

            CheckForUpdates();
        }

        private async Task CheckForUpdates()
        {
            using (var manager = new Squirrel.UpdateManager(@"C:\Temp\MusicPlayerReleases"))
            {

            }
        }

        private void btnToggleSongState_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                playing = false;
                btnToggleSongState.Text = "Play";
                player.controls.pause();
            }
            else if (!playing)
            {
                playing = true;
                btnToggleSongState.Text = "Pause";
                player.controls.play();
            }
        }

        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_item_index = lbSongs.SelectedIndex;

            if (current_song_index != selected_item_index)
            {
                Song selected_song = songs[selected_item_index];

                song_index = selected_item_index;
                updateSong(selected_song, false);
                btnToggleSongState.Text = "Play";
                current_song_index = selected_item_index;
            }
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            volume = tbVolume.Value;
            player.settings.volume = volume;
            /*txtbVolume.Text = volume.ToString();*/
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (ofdSongs.ShowDialog() == DialogResult.OK)
            {
                string[] files = ofdSongs.FileNames;
                foreach (var file in files)
                {
                    string file_name = Path.GetFileName(file);
                    Song song = new Song();
                    song.song_name = Path.GetFileNameWithoutExtension(file);
                    song.song_path = file;

                    songs.Add(song_index, song);
                    lbSongs.Items.Add(file_name);
                    song_index++;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (current_song_index - 1 > -1)
            {
                current_song_index -= 1;
                try
                {
                    updateSong(songs[current_song_index], true);
                } catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString() + song_index.ToString());
                }
                lbSongs.SelectedIndex = current_song_index;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current_song_index + 1 < songs.Count)
            {
                current_song_index += 1;
                updateSong(songs[current_song_index], true);
                lbSongs.SelectedIndex = current_song_index;
            } else if (current_song_index == songs.Count-1 && songs.Count > 0)
            {
                current_song_index = 0;
                updateSong(songs[current_song_index], true);
                lbSongs.SelectedIndex = current_song_index;

            }
        }

        public void updateSong(Song song, bool play)
        {
            lablSongName.Text = song.song_name;
            player.URL = song.song_path;
            if (play)
            {
                player.controls.play();
                playing = true;
                btnToggleSongState.Text = "Pause";
            }
        }

        private void btnSavePlaylist_Click(object sender, EventArgs e)
        {
            if (!(songs.Count > 0)) { return; } 
            if (sfdSavePlaylist.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var json_playlist = JsonConvert.SerializeObject(songs);
                    string path = sfdSavePlaylist.FileName;
                    File.WriteAllText(path, json_playlist);
                } catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void sfdSavePlaylist_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnLoadPlaylist_Click(object sender, EventArgs e)
        {
            if (ofdLoadPlaylist.ShowDialog() == DialogResult.OK)
            {
                string file = ofdLoadPlaylist.FileName;
                using (StreamReader reader = File.OpenText(file))
                {
                    string json_data = reader.ReadToEnd();
                    songs.Clear();
                    IDictionary<int, Song> playlist_songs = JsonConvert.DeserializeObject<Dictionary<int, Song>>(json_data);
                    int nbr_songs = playlist_songs.Count;
                    foreach (int i in Enumerable.Range(0, nbr_songs))
                    {
                        Song song = playlist_songs[i];
                        lbSongs.Items.Add(song.song_name);
                        songs.Add(i, song);
                    }
                }
            }
        }

        private void ofdLoadPlaylist_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
    public class Song
    {
        public string song_path { get; set; }
        public string song_name { get; set; }
    }
}
