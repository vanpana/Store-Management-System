namespace MyStore
{
    partial class MainWindow
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
            this.AlbumsView = new System.Windows.Forms.DataGridView();
            this.SongsView = new System.Windows.Forms.DataGridView();
            this.songTitle = new System.Windows.Forms.TextBox();
            this.songTitleLabel = new System.Windows.Forms.Label();
            this.songPriceLabel = new System.Windows.Forms.Label();
            this.songPrice = new System.Windows.Forms.TextBox();
            this.songGenreLabel = new System.Windows.Forms.Label();
            this.songGenre = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongsView)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbumsView
            // 
            this.AlbumsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlbumsView.Location = new System.Drawing.Point(56, 179);
            this.AlbumsView.Name = "AlbumsView";
            this.AlbumsView.RowTemplate.Height = 31;
            this.AlbumsView.Size = new System.Drawing.Size(632, 405);
            this.AlbumsView.TabIndex = 0;
            this.AlbumsView.SelectionChanged += new System.EventHandler(this.AlbumsView_SelectionChanged);
            // 
            // SongsView
            // 
            this.SongsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongsView.Location = new System.Drawing.Point(753, 179);
            this.SongsView.Name = "SongsView";
            this.SongsView.RowTemplate.Height = 31;
            this.SongsView.Size = new System.Drawing.Size(631, 405);
            this.SongsView.TabIndex = 1;
            // 
            // songTitle
            // 
            this.songTitle.Location = new System.Drawing.Point(654, 679);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(100, 29);
            this.songTitle.TabIndex = 2;
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AutoSize = true;
            this.songTitleLabel.Location = new System.Drawing.Point(649, 651);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(93, 25);
            this.songTitleLabel.TabIndex = 3;
            this.songTitleLabel.Text = "Song title";
            // 
            // songPriceLabel
            // 
            this.songPriceLabel.AutoSize = true;
            this.songPriceLabel.Location = new System.Drawing.Point(796, 651);
            this.songPriceLabel.Name = "songPriceLabel";
            this.songPriceLabel.Size = new System.Drawing.Size(106, 25);
            this.songPriceLabel.TabIndex = 5;
            this.songPriceLabel.Text = "Song price";
            // 
            // songPrice
            // 
            this.songPrice.Location = new System.Drawing.Point(801, 679);
            this.songPrice.Name = "songPrice";
            this.songPrice.Size = new System.Drawing.Size(100, 29);
            this.songPrice.TabIndex = 4;
            // 
            // songGenreLabel
            // 
            this.songGenreLabel.AutoSize = true;
            this.songGenreLabel.Location = new System.Drawing.Point(946, 651);
            this.songGenreLabel.Name = "songGenreLabel";
            this.songGenreLabel.Size = new System.Drawing.Size(114, 25);
            this.songGenreLabel.TabIndex = 7;
            this.songGenreLabel.Text = "Song genre";
            // 
            // songGenre
            // 
            this.songGenre.Location = new System.Drawing.Point(951, 679);
            this.songGenre.Name = "songGenre";
            this.songGenre.Size = new System.Drawing.Size(100, 29);
            this.songGenre.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(679, 733);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 36);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(814, 733);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 36);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(963, 733);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 36);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 928);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.songGenreLabel);
            this.Controls.Add(this.songGenre);
            this.Controls.Add(this.songPriceLabel);
            this.Controls.Add(this.songPrice);
            this.Controls.Add(this.songTitleLabel);
            this.Controls.Add(this.songTitle);
            this.Controls.Add(this.SongsView);
            this.Controls.Add(this.AlbumsView);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AlbumsView;
        private System.Windows.Forms.DataGridView SongsView;
        private System.Windows.Forms.TextBox songTitle;
        private System.Windows.Forms.Label songTitleLabel;
        private System.Windows.Forms.Label songPriceLabel;
        private System.Windows.Forms.TextBox songPrice;
        private System.Windows.Forms.Label songGenreLabel;
        private System.Windows.Forms.TextBox songGenre;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

