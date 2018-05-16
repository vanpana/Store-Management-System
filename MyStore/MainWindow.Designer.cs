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
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Holder = new System.Windows.Forms.Panel();
            this.deadlock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongsView)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbumsView
            // 
            this.AlbumsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlbumsView.Location = new System.Drawing.Point(57, 27);
            this.AlbumsView.Name = "AlbumsView";
            this.AlbumsView.RowTemplate.Height = 31;
            this.AlbumsView.Size = new System.Drawing.Size(632, 405);
            this.AlbumsView.TabIndex = 0;
            this.AlbumsView.SelectionChanged += new System.EventHandler(this.AlbumsView_SelectionChanged);
            // 
            // SongsView
            // 
            this.SongsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongsView.Location = new System.Drawing.Point(749, 27);
            this.SongsView.Name = "SongsView";
            this.SongsView.RowTemplate.Height = 31;
            this.SongsView.Size = new System.Drawing.Size(631, 405);
            this.SongsView.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1117, 789);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 36);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1198, 789);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 36);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1292, 789);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 36);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Holder
            // 
            this.Holder.Location = new System.Drawing.Point(57, 478);
            this.Holder.Name = "Holder";
            this.Holder.Size = new System.Drawing.Size(1323, 266);
            this.Holder.TabIndex = 11;
            // 
            // deadlock
            // 
            this.deadlock.Location = new System.Drawing.Point(198, 789);
            this.deadlock.Name = "deadlock";
            this.deadlock.Size = new System.Drawing.Size(249, 36);
            this.deadlock.TabIndex = 12;
            this.deadlock.Text = "Make deadlock";
            this.deadlock.UseVisualStyleBackColor = true;
            this.deadlock.Click += new System.EventHandler(this.deadlock_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 928);
            this.Controls.Add(this.deadlock);
            this.Controls.Add(this.Holder);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
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
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel Holder;
        private System.Windows.Forms.Button deadlock;
    }
}

