
namespace Music_WindowsFormsApp
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ofdSongs = new System.Windows.Forms.OpenFileDialog();
            this.panelSongList = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSavePlaylist = new System.Windows.Forms.Button();
            this.btnLoadPlaylist = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.panelSongInfos = new System.Windows.Forms.Panel();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lablSongName = new System.Windows.Forms.Label();
            this.lablPlaying = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnToggleSongState = new System.Windows.Forms.Button();
            this.sfdSavePlaylist = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoadPlaylist = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelSongList.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelSongInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ofdSongs
            // 
            this.ofdSongs.FileName = "s";
            this.ofdSongs.Filter = "Audio Files |*.mp3;*.wav;*.ogg";
            this.ofdSongs.Multiselect = true;
            // 
            // panelSongList
            // 
            this.panelSongList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelSongList.Controls.Add(this.flowLayoutPanel1);
            this.panelSongList.Controls.Add(this.btnAddSong);
            this.panelSongList.Controls.Add(this.lbSongs);
            this.panelSongList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSongList.Location = new System.Drawing.Point(0, 0);
            this.panelSongList.Name = "panelSongList";
            this.panelSongList.Size = new System.Drawing.Size(300, 577);
            this.panelSongList.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSavePlaylist);
            this.flowLayoutPanel1.Controls.Add(this.btnLoadPlaylist);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 47);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnSavePlaylist
            // 
            this.btnSavePlaylist.FlatAppearance.BorderSize = 0;
            this.btnSavePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePlaylist.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSavePlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSavePlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePlaylist.Location = new System.Drawing.Point(3, 3);
            this.btnSavePlaylist.Name = "btnSavePlaylist";
            this.btnSavePlaylist.Size = new System.Drawing.Size(144, 43);
            this.btnSavePlaylist.TabIndex = 2;
            this.btnSavePlaylist.Text = "Save Playlist";
            this.btnSavePlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSavePlaylist.UseVisualStyleBackColor = true;
            this.btnSavePlaylist.Click += new System.EventHandler(this.btnSavePlaylist_Click);
            // 
            // btnLoadPlaylist
            // 
            this.btnLoadPlaylist.FlatAppearance.BorderSize = 0;
            this.btnLoadPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPlaylist.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLoadPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPlaylist.Location = new System.Drawing.Point(153, 3);
            this.btnLoadPlaylist.Name = "btnLoadPlaylist";
            this.btnLoadPlaylist.Size = new System.Drawing.Size(144, 43);
            this.btnLoadPlaylist.TabIndex = 3;
            this.btnLoadPlaylist.Text = "Load Playlist";
            this.btnLoadPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoadPlaylist.UseVisualStyleBackColor = true;
            this.btnLoadPlaylist.Click += new System.EventHandler(this.btnLoadPlaylist_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddSong.FlatAppearance.BorderSize = 0;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSong.Location = new System.Drawing.Point(0, 534);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(300, 43);
            this.btnAddSong.TabIndex = 1;
            this.btnAddSong.Text = "Add Song  ";
            this.btnAddSong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lbSongs
            // 
            this.lbSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSongs.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.lbSongs.ForeColor = System.Drawing.SystemColors.Window;
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 25;
            this.lbSongs.Location = new System.Drawing.Point(12, 53);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(275, 475);
            this.lbSongs.TabIndex = 0;
            this.lbSongs.SelectedIndexChanged += new System.EventHandler(this.lbSongs_SelectedIndexChanged);
            // 
            // panelSongInfos
            // 
            this.panelSongInfos.AutoSize = true;
            this.panelSongInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelSongInfos.Controls.Add(this.tbVolume);
            this.panelSongInfos.Controls.Add(this.lablSongName);
            this.panelSongInfos.Controls.Add(this.lablPlaying);
            this.panelSongInfos.Location = new System.Drawing.Point(312, 12);
            this.panelSongInfos.Name = "panelSongInfos";
            this.panelSongInfos.Size = new System.Drawing.Size(627, 483);
            this.panelSongInfos.TabIndex = 3;
            // 
            // tbVolume
            // 
            this.tbVolume.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbVolume.Location = new System.Drawing.Point(579, 5);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 475);
            this.tbVolume.SmallChange = 5;
            this.tbVolume.TabIndex = 1;
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbVolume.Value = 50;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // lablSongName
            // 
            this.lablSongName.AutoSize = true;
            this.lablSongName.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Italic);
            this.lablSongName.ForeColor = System.Drawing.Color.White;
            this.lablSongName.Location = new System.Drawing.Point(16, 69);
            this.lablSongName.Name = "lablSongName";
            this.lablSongName.Size = new System.Drawing.Size(269, 45);
            this.lablSongName.TabIndex = 1;
            this.lablSongName.Text = "No song selected";
            // 
            // lablPlaying
            // 
            this.lablPlaying.AutoSize = true;
            this.lablPlaying.Font = new System.Drawing.Font("Nirmala UI", 28.75F, System.Drawing.FontStyle.Bold);
            this.lablPlaying.ForeColor = System.Drawing.Color.White;
            this.lablPlaying.Location = new System.Drawing.Point(15, 17);
            this.lablPlaying.Name = "lablPlaying";
            this.lablPlaying.Size = new System.Drawing.Size(256, 52);
            this.lablPlaying.TabIndex = 0;
            this.lablPlaying.Text = "Now playing";
            // 
            // panelControls
            // 
            this.panelControls.AutoSize = true;
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelControls.Controls.Add(this.btnNext);
            this.panelControls.Controls.Add(this.btnPrevious);
            this.panelControls.Controls.Add(this.btnToggleSongState);
            this.panelControls.Location = new System.Drawing.Point(312, 511);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(626, 57);
            this.panelControls.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNext.Location = new System.Drawing.Point(131, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 57);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(131, 57);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnToggleSongState
            // 
            this.btnToggleSongState.AutoSize = true;
            this.btnToggleSongState.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToggleSongState.FlatAppearance.BorderSize = 0;
            this.btnToggleSongState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleSongState.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnToggleSongState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnToggleSongState.Location = new System.Drawing.Point(495, 0);
            this.btnToggleSongState.Name = "btnToggleSongState";
            this.btnToggleSongState.Size = new System.Drawing.Size(131, 57);
            this.btnToggleSongState.TabIndex = 0;
            this.btnToggleSongState.Text = "Play";
            this.btnToggleSongState.UseVisualStyleBackColor = true;
            this.btnToggleSongState.Click += new System.EventHandler(this.btnToggleSongState_Click);
            // 
            // sfdSavePlaylist
            // 
            this.sfdSavePlaylist.FileName = "my_playlist";
            this.sfdSavePlaylist.Filter = "Json Format (.json)|*.json";
            this.sfdSavePlaylist.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSavePlaylist_FileOk);
            // 
            // ofdLoadPlaylist
            // 
            this.ofdLoadPlaylist.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLoadPlaylist_FileOk);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelSongInfos);
            this.Controls.Add(this.panelSongList);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MusicPlayer";
            this.Text = "MusicAll";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelSongList.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelSongInfos.ResumeLayout(false);
            this.panelSongInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog ofdSongs;
        private System.Windows.Forms.Panel panelSongList;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Panel panelSongInfos;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label lablSongName;
        private System.Windows.Forms.Label lablPlaying;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnToggleSongState;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSavePlaylist;
        private System.Windows.Forms.SaveFileDialog sfdSavePlaylist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLoadPlaylist;
        private System.Windows.Forms.OpenFileDialog ofdLoadPlaylist;
    }
}

