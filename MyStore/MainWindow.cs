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

        private void AlbumsView_SelectionChanged(object sender, EventArgs e)
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
                    SongsView.DataSource = DatabaseUtil.GetSongsFromAlbum(Int32.Parse(albumID)).Tables[0];

            }
        }
    }
}
