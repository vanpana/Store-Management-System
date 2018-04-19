﻿using System;
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
            setTextEdits(DatabaseUtil.getColNames());
        }

        private void LoadAlbums()
        {
            AlbumsView.DataSource = DatabaseUtil.GetParent().Tables[0];
            AlbumsView.ClearSelection();
        }

        private void setTextEdits(List<string> colNames)
        {
            int i = 0;
            foreach (string column in colNames)
            {
                TextBox textBox = new TextBox();
                textBox.Name = column;
                textBox.Text = column;
                textBox.Size = new Size(200, 90);
                textBox.Location = new Point(0, i);
                i += 20;
                Holder.Controls.Add(textBox);
            }
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
                SongsView.DataSource = DatabaseUtil.GetChildByParentID(albumID).Tables[0];
        }

        
        private void updateButton_Click(object sender, EventArgs e)
        {
            int albumID = getSelectedAlbumID();
            int songID = getSelectedSongID();
            Boolean result = false;
            
            result = DatabaseUtil.updateSong(Holder);

            if (result)
                // If operation succeeded, load updated songs from the album
                SongsView.DataSource = DatabaseUtil.GetChildByParentID(albumID).Tables[0]; 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /*
            int songID = getSelectedSongID();
            Boolean result = false;

            if (songID > 0)
                result = DatabaseUtil.deleteSong(songID);

            if (result)
                // If operation succeeded, load updated songs from the album
                SongsView.DataSource = DatabaseUtil.GetSongsFromAlbum(getSelectedAlbumID()).Tables[0]; */
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int albumID = getSelectedAlbumID();
            int songID = getSelectedSongID();
            Boolean result = false;

            if (albumID > 0 && songID > 0)
                result = DatabaseUtil.addChild(Holder);

            if (result)
                // If operation succeeded, load updated songs from the album
                SongsView.DataSource = DatabaseUtil.GetChildByParentID(albumID).Tables[0];
        }
        
    }
}
