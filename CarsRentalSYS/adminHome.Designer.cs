namespace CarsRentalSYS
{
    partial class adminHome
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
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSideMenu = new System.Windows.Forms.GroupBox();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnCarTable = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnRemoveType = new System.Windows.Forms.Button();
            this.btnCangeType = new System.Windows.Forms.Button();
            this.btnSetType = new System.Windows.Forms.Button();
            this.grbTable = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grvSearchResult = new System.Windows.Forms.DataGridView();
            this.txtMainSearch = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.grbSideMenu.SuspendLayout();
            this.grbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // grbSideMenu
            // 
            this.grbSideMenu.BackColor = System.Drawing.Color.Orange;
            this.grbSideMenu.Controls.Add(this.btnAnalysis);
            this.grbSideMenu.Controls.Add(this.btnCustomer);
            this.grbSideMenu.Controls.Add(this.btnReservations);
            this.grbSideMenu.Controls.Add(this.btnCarTable);
            this.grbSideMenu.Controls.Add(this.btnAddCar);
            this.grbSideMenu.Controls.Add(this.btnRemoveType);
            this.grbSideMenu.Controls.Add(this.btnCangeType);
            this.grbSideMenu.Controls.Add(this.btnSetType);
            this.grbSideMenu.Location = new System.Drawing.Point(0, 27);
            this.grbSideMenu.Name = "grbSideMenu";
            this.grbSideMenu.Size = new System.Drawing.Size(202, 411);
            this.grbSideMenu.TabIndex = 5;
            this.grbSideMenu.TabStop = false;
            this.grbSideMenu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackColor = System.Drawing.Color.White;
            this.btnAnalysis.Location = new System.Drawing.Point(6, 267);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(185, 29);
            this.btnAnalysis.TabIndex = 6;
            this.btnAnalysis.Text = "Generate Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = false;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(6, 232);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(185, 29);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "List Customers";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.White;
            this.btnReservations.Location = new System.Drawing.Point(6, 197);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(185, 29);
            this.btnReservations.TabIndex = 6;
            this.btnReservations.Text = "Show Reservations";
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnCarTable
            // 
            this.btnCarTable.BackColor = System.Drawing.Color.White;
            this.btnCarTable.Location = new System.Drawing.Point(6, 162);
            this.btnCarTable.Name = "btnCarTable";
            this.btnCarTable.Size = new System.Drawing.Size(185, 29);
            this.btnCarTable.TabIndex = 6;
            this.btnCarTable.Text = "Cars Table";
            this.btnCarTable.UseVisualStyleBackColor = false;
            this.btnCarTable.Click += new System.EventHandler(this.btnCarTable_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.White;
            this.btnAddCar.Location = new System.Drawing.Point(6, 127);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(185, 29);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.Text = "Add A Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnRemoveType
            // 
            this.btnRemoveType.BackColor = System.Drawing.Color.White;
            this.btnRemoveType.Location = new System.Drawing.Point(6, 92);
            this.btnRemoveType.Name = "btnRemoveType";
            this.btnRemoveType.Size = new System.Drawing.Size(185, 29);
            this.btnRemoveType.TabIndex = 6;
            this.btnRemoveType.Text = "Remove Car Type";
            this.btnRemoveType.UseVisualStyleBackColor = false;
            this.btnRemoveType.Click += new System.EventHandler(this.btnRemoveType_Click);
            // 
            // btnCangeType
            // 
            this.btnCangeType.BackColor = System.Drawing.Color.White;
            this.btnCangeType.Location = new System.Drawing.Point(6, 57);
            this.btnCangeType.Name = "btnCangeType";
            this.btnCangeType.Size = new System.Drawing.Size(185, 29);
            this.btnCangeType.TabIndex = 6;
            this.btnCangeType.Text = "Change Car Type";
            this.btnCangeType.UseVisualStyleBackColor = false;
            this.btnCangeType.Click += new System.EventHandler(this.btnCangeType_Click);
            // 
            // btnSetType
            // 
            this.btnSetType.BackColor = System.Drawing.Color.White;
            this.btnSetType.Location = new System.Drawing.Point(6, 22);
            this.btnSetType.Name = "btnSetType";
            this.btnSetType.Size = new System.Drawing.Size(185, 29);
            this.btnSetType.TabIndex = 0;
            this.btnSetType.Text = "Set Car Type";
            this.btnSetType.UseVisualStyleBackColor = false;
            this.btnSetType.Click += new System.EventHandler(this.btnSetType_Click);
            // 
            // grbTable
            // 
            this.grbTable.BackColor = System.Drawing.Color.SkyBlue;
            this.grbTable.Controls.Add(this.btnSearch);
            this.grbTable.Controls.Add(this.label1);
            this.grbTable.Controls.Add(this.grvSearchResult);
            this.grbTable.Controls.Add(this.txtMainSearch);
            this.grbTable.Location = new System.Drawing.Point(211, 27);
            this.grbTable.Name = "grbTable";
            this.grbTable.Size = new System.Drawing.Size(587, 418);
            this.grbTable.TabIndex = 6;
            this.grbTable.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(471, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 20);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter any info about the car:";
            // 
            // grvSearchResult
            // 
            this.grvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSearchResult.Location = new System.Drawing.Point(6, 101);
            this.grvSearchResult.Name = "grvSearchResult";
            this.grvSearchResult.Size = new System.Drawing.Size(575, 292);
            this.grvSearchResult.TabIndex = 13;
            // 
            // txtMainSearch
            // 
            this.txtMainSearch.Location = new System.Drawing.Point(221, 45);
            this.txtMainSearch.Name = "txtMainSearch";
            this.txtMainSearch.Size = new System.Drawing.Size(234, 20);
            this.txtMainSearch.TabIndex = 11;
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTable);
            this.Controls.Add(this.grbSideMenu);
            this.Controls.Add(this.menuStrip2);
            this.Name = "adminHome";
            this.Text = "adminHome";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grbSideMenu.ResumeLayout(false);
            this.grbTable.ResumeLayout(false);
            this.grbTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbSideMenu;
        private System.Windows.Forms.Button btnSetType;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnCarTable;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnRemoveType;
        private System.Windows.Forms.Button btnCangeType;
        private System.Windows.Forms.GroupBox grbTable;
        private System.Windows.Forms.DataGridView grvSearchResult;
        private System.Windows.Forms.TextBox txtMainSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}