namespace CarsRentalSYS
{
    partial class listCustomers
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAReservationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cancelAReservationToolStripMenuItem
            // 
            this.cancelAReservationToolStripMenuItem.Name = "cancelAReservationToolStripMenuItem";
            this.cancelAReservationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cancelAReservationToolStripMenuItem.Text = "Change a reservation";
            // 
            // cancelAReservationToolStripMenuItem1
            // 
            this.cancelAReservationToolStripMenuItem1.Name = "cancelAReservationToolStripMenuItem1";
            this.cancelAReservationToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.cancelAReservationToolStripMenuItem1.Text = "Cancel a reservation";
            // 
            // rentalsToolStripMenuItem1
            // 
            this.rentalsToolStripMenuItem1.Name = "rentalsToolStripMenuItem1";
            this.rentalsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.rentalsToolStripMenuItem1.Text = "Rentals";
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(8, 43);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(782, 390);
            this.grdCustomers.TabIndex = 7;
            this.grdCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellContentClick);
            // 
            // listCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.menuStrip2);
            this.Name = "listCustomers";
            this.Text = "listCustomers";
            this.Load += new System.EventHandler(this.listCustomers_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem makeAReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAReservationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem1;
        private System.Windows.Forms.DataGridView grdCustomers;
    }
}