namespace BasicFacebookFeatures
{
    partial class FormMyEvents
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
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LinkCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttendingCountCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonShowMyEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEvents
            // 
            this.listViewEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.PlaceCol,
            this.DescriptionCol,
            this.StartTimeCol,
            this.LinkCol,
            this.AttendingCountCol});
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(214, 302);
            this.listViewEvents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(996, 627);
            this.listViewEvents.TabIndex = 0;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.Width = 219;
            // 
            // PlaceCol
            // 
            this.PlaceCol.Text = "Place";
            this.PlaceCol.Width = 196;
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.Text = "Description";
            this.DescriptionCol.Width = 379;
            // 
            // StartTimeCol
            // 
            this.StartTimeCol.Text = "Start Time";
            this.StartTimeCol.Width = 198;
            // 
            // LinkCol
            // 
            this.LinkCol.Text = "Link";
            this.LinkCol.Width = 166;
            // 
            // AttendingCountCol
            // 
            this.AttendingCountCol.Text = "Attending Count";
            this.AttendingCountCol.Width = 294;
            // 
            // buttonShowMyEvents
            // 
            this.buttonShowMyEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowMyEvents.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonShowMyEvents.FlatAppearance.BorderSize = 0;
            this.buttonShowMyEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowMyEvents.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMyEvents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowMyEvents.Location = new System.Drawing.Point(428, 210);
            this.buttonShowMyEvents.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonShowMyEvents.Name = "buttonShowMyEvents";
            this.buttonShowMyEvents.Size = new System.Drawing.Size(494, 54);
            this.buttonShowMyEvents.TabIndex = 22;
            this.buttonShowMyEvents.Text = "Show My Events";
            this.buttonShowMyEvents.UseVisualStyleBackColor = false;
            this.buttonShowMyEvents.Click += new System.EventHandler(this.buttonShowMyEvents_Click);
            // 
            // FormMyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 1173);
            this.Controls.Add(this.buttonShowMyEvents);
            this.Controls.Add(this.listViewEvents);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMyEvents";
            this.Text = "My Events";
            this.Load += new System.EventHandler(this.formMyEvents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader PlaceCol;
        private System.Windows.Forms.ColumnHeader DescriptionCol;
        private System.Windows.Forms.ColumnHeader StartTimeCol;
        private System.Windows.Forms.ColumnHeader LinkCol;
        private System.Windows.Forms.ColumnHeader AttendingCountCol;
        private System.Windows.Forms.Button buttonShowMyEvents;
    }
}