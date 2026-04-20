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
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdCarsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCarsTable
            // 
            this.grdCarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCarsTable.Location = new System.Drawing.Point(11, 128);
            this.grdCarsTable.Name = "grdCarsTable";
            this.grdCarsTable.Size = new System.Drawing.Size(776, 307);
            this.grdCarsTable.TabIndex = 0;
            // 
            // carsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCarsTable);
            this.Name = "carsTable";
            this.Text = "carsTable";
            ((System.ComponentModel.ISupportInitialize)(this.grdCarsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCarsTable;
    }
}