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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 928);
            this.Controls.Add(this.SongsView);
            this.Controls.Add(this.AlbumsView);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AlbumsView;
        private System.Windows.Forms.DataGridView SongsView;
    }
}

