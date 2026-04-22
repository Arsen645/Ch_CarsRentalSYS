namespace CarsRentalSYS
{
    partial class removeCar
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
            this.grdCarsTable = new System.Windows.Forms.DataGridView();
            this.lblCars = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grdCarsTable
            // 
            this.grdCarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCarsTable.Location = new System.Drawing.Point(13, 84);
            this.grdCarsTable.Name = "grdCarsTable";
            this.grdCarsTable.Size = new System.Drawing.Size(757, 339);
            this.grdCarsTable.TabIndex = 14;
            this.grdCarsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCarsTable_CellClick);
            this.grdCarsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCarsTable_CellContentClick);
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCars.Location = new System.Drawing.Point(22, 35);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(72, 31);
            this.lblCars.TabIndex = 19;
            this.lblCars.Text = "Cars";
            // 
            // removeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.grdCarsTable);
            this.Controls.Add(this.menuStrip2);
            this.Name = "removeCar";
            this.Load += new System.EventHandler(this.removeCar_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdCarsTable;
        private System.Windows.Forms.Label lblCars;
    }
}