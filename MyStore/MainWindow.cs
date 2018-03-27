using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadAlbums();
        }

        private void LoadAlbums()
        {
            AlbumsView.DataSource = DatabaseUtil.GetAllAlbums().Tables[0];
            AlbumsView.ClearSelection();
        }

        private int getSelectedAlbumID()
        {
            if (AlbumsView.SelectedCells.Count > 0)
            {
                // Get index of the selected row
                int selectedrowindex = AlbumsView.SelectedCells[0].RowIndex;

                // Get selected row model
                DataGridViewRow selectedRow = AlbumsView.Rows[selectedrowindex];

                // Get index of the album
                string albumID = Convert.ToString(selectedRow.Cells[0].Value);

                if (albumID != "")
                    // Load songs from the album
                    return Int32.Parse(albumID);
            }

            return -1;
        }

        private int getSelectedSongID()
        {
            if (SongsView.SelectedCells.Count > 0)
            {
                // Get index of the selected row
                int selectedrowindex = SongsView.SelectedCells[0].RowIndex;

                // Get selected row model
                DataGridViewRow selectedRow = SongsView.Rows[selectedrowindex];

                // Get index of the album
                string songID = Convert.ToString(selectedRow.Cells[0].Value);

                if (songID != "")
                    // Load songs from the album
                    return Int32.Parse(songID);
            }

            return -1;
        }
        private void AlbumsView_SelectionChanged(object sender, EventArgs e)
        {
            // Get index of the album
            int albumID = getSelectedAlbumID();

            if (albumID > 0)
                // Load songs from the album
                SongsView.DataSource = DatabaseUtil.GetSongsFromAlbum(albumID).Tables[0];
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int albumID = getSelectedAlbumID();
            int songID = getSelectedSongID();
            Boolean result = false;

            if (albumID > 0 && songID > 0)
                result = DatabaseUtil.updateSong(songID, songTitle.Text, albumID, Int32.Parse(songPrice.Text), songGenre.Text);

            if (result)
                // If operation succeeded, load updated songs from the album
                SongsView.DataSource = DatabaseUtil.GetSongsFromAlbum(albumID).Tables[0];
        }
    }
}
