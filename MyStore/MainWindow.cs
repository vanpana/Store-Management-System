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
        }
    }
}
