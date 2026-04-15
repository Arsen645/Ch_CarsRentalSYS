namespace CarsRentalSYS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.carClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCarTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCarTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCarTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addACarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeACarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAReservationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerACustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carDamageAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomersRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairCostAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewCars = new System.Windows.Forms.Button();
            this.txtMainSearch = new System.Windows.Forms.TextBox();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grvSearchResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(14, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 469);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carClassesToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.rentalsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(914, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // carClassesToolStripMenuItem
            // 
            this.carClassesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCarTypeToolStripMenuItem,
            this.changeCarTypeToolStripMenuItem,
            this.removeCarTypeToolStripMenuItem});
            this.carClassesToolStripMenuItem.Name = "carClassesToolStripMenuItem";
            this.carClassesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.carClassesToolStripMenuItem.Text = "Car Classes";
            this.carClassesToolStripMenuItem.Click += new System.EventHandler(this.carClassesToolStripMenuItem_Click);
            // 
            // setCarTypeToolStripMenuItem
            // 
            this.setCarTypeToolStripMenuItem.Name = "setCarTypeToolStripMenuItem";
            this.setCarTypeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.setCarTypeToolStripMenuItem.Text = "Set Car Type";
            this.setCarTypeToolStripMenuItem.Click += new System.EventHandler(this.setCarTypeToolStripMenuItem_Click);
            // 
            // changeCarTypeToolStripMenuItem
            // 
            this.changeCarTypeToolStripMenuItem.Name = "changeCarTypeToolStripMenuItem";
            this.changeCarTypeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.changeCarTypeToolStripMenuItem.Text = "Change Car Type";
            this.changeCarTypeToolStripMenuItem.Click += new System.EventHandler(this.changeCarTypeToolStripMenuItem_Click);
            // 
            // removeCarTypeToolStripMenuItem
            // 
            this.removeCarTypeToolStripMenuItem.Name = "removeCarTypeToolStripMenuItem";
            this.removeCarTypeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.removeCarTypeToolStripMenuItem.Text = "Remove Car Type";
            this.removeCarTypeToolStripMenuItem.Click += new System.EventHandler(this.removeCarTypeToolStripMenuItem_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addACarToolStripMenuItem,
            this.removeACarToolStripMenuItem});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.carsToolStripMenuItem.Text = "Cars";
            // 
            // addACarToolStripMenuItem
            // 
            this.addACarToolStripMenuItem.Name = "addACarToolStripMenuItem";
            this.addACarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addACarToolStripMenuItem.Text = "Add a car";
            this.addACarToolStripMenuItem.Click += new System.EventHandler(this.addACarToolStripMenuItem_Click);
            // 
            // removeACarToolStripMenuItem
            // 
            this.removeACarToolStripMenuItem.Name = "removeACarToolStripMenuItem";
            this.removeACarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeACarToolStripMenuItem.Text = "Remove a car";
            this.removeACarToolStripMenuItem.Click += new System.EventHandler(this.removeACarToolStripMenuItem_Click);
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAReservationToolStripMenuItem,
            this.cancelAReservationToolStripMenuItem,
            this.cancelAReservationToolStripMenuItem1});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // makeAReservationToolStripMenuItem
            // 
            this.makeAReservationToolStripMenuItem.Name = "makeAReservationToolStripMenuItem";
            this.makeAReservationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.makeAReservationToolStripMenuItem.Text = "Make a reservation";
            this.makeAReservationToolStripMenuItem.Click += new System.EventHandler(this.makeAReservationToolStripMenuItem_Click);
            // 
            // cancelAReservationToolStripMenuItem
            // 
            this.cancelAReservationToolStripMenuItem.Name = "cancelAReservationToolStripMenuItem";
            this.cancelAReservationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cancelAReservationToolStripMenuItem.Text = "Change a reservation";
            this.cancelAReservationToolStripMenuItem.Click += new System.EventHandler(this.cancelAReservationToolStripMenuItem_Click);
            // 
            // cancelAReservationToolStripMenuItem1
            // 
            this.cancelAReservationToolStripMenuItem1.Name = "cancelAReservationToolStripMenuItem1";
            this.cancelAReservationToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.cancelAReservationToolStripMenuItem1.Text = "Cancel a reservation";
            this.cancelAReservationToolStripMenuItem1.Click += new System.EventHandler(this.cancelAReservationToolStripMenuItem1_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerACustomerToolStripMenuItem,
            this.listCustomersToolStripMenuItem,
            this.updateCustomerInformationToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // registerACustomerToolStripMenuItem
            // 
            this.registerACustomerToolStripMenuItem.Name = "registerACustomerToolStripMenuItem";
            this.registerACustomerToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.registerACustomerToolStripMenuItem.Text = "Register a customer";
            this.registerACustomerToolStripMenuItem.Click += new System.EventHandler(this.registerACustomerToolStripMenuItem_Click);
            // 
            // listCustomersToolStripMenuItem
            // 
            this.listCustomersToolStripMenuItem.Name = "listCustomersToolStripMenuItem";
            this.listCustomersToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listCustomersToolStripMenuItem.Text = "List customers";
            this.listCustomersToolStripMenuItem.Click += new System.EventHandler(this.listCustomersToolStripMenuItem_Click);
            // 
            // updateCustomerInformationToolStripMenuItem
            // 
            this.updateCustomerInformationToolStripMenuItem.Name = "updateCustomerInformationToolStripMenuItem";
            this.updateCustomerInformationToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.updateCustomerInformationToolStripMenuItem.Text = "Update customer information";
            this.updateCustomerInformationToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerInformationToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carDamageAnalysisToolStripMenuItem,
            this.showCustomersRateToolStripMenuItem,
            this.repairCostAnalysisToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // carDamageAnalysisToolStripMenuItem
            // 
            this.carDamageAnalysisToolStripMenuItem.Name = "carDamageAnalysisToolStripMenuItem";
            this.carDamageAnalysisToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.carDamageAnalysisToolStripMenuItem.Text = "Generate analysis";
            this.carDamageAnalysisToolStripMenuItem.Click += new System.EventHandler(this.carDamageAnalysisToolStripMenuItem_Click);
            // 
            // showCustomersRateToolStripMenuItem
            // 
            this.showCustomersRateToolStripMenuItem.Name = "showCustomersRateToolStripMenuItem";
            this.showCustomersRateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.showCustomersRateToolStripMenuItem.Text = "Show customers rates";
            this.showCustomersRateToolStripMenuItem.Click += new System.EventHandler(this.showCustomersRateToolStripMenuItem_Click);
            // 
            // repairCostAnalysisToolStripMenuItem
            // 
            this.repairCostAnalysisToolStripMenuItem.Name = "repairCostAnalysisToolStripMenuItem";
            this.repairCostAnalysisToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.repairCostAnalysisToolStripMenuItem.Text = "Generate invoice";
            this.repairCostAnalysisToolStripMenuItem.Click += new System.EventHandler(this.repairCostAnalysisToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // btnViewCars
            // 
            this.btnViewCars.Location = new System.Drawing.Point(705, 79);
            this.btnViewCars.Name = "btnViewCars";
            this.btnViewCars.Size = new System.Drawing.Size(157, 40);
            this.btnViewCars.TabIndex = 5;
            this.btnViewCars.Text = "View Cars";
            this.btnViewCars.UseVisualStyleBackColor = true;
            this.btnViewCars.Click += new System.EventHandler(this.btnViewCars_Click);
            // 
            // txtMainSearch
            // 
            this.txtMainSearch.Location = new System.Drawing.Point(47, 191);
            this.txtMainSearch.Name = "txtMainSearch";
            this.txtMainSearch.Size = new System.Drawing.Size(346, 20);
            this.txtMainSearch.TabIndex = 6;
            // 
            // dtFromDate
            // 
            this.dtFromDate.Location = new System.Drawing.Point(417, 191);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(120, 20);
            this.dtFromDate.TabIndex = 7;
            // 
            // dtToDate
            // 
            this.dtToDate.Location = new System.Drawing.Point(552, 191);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(120, 20);
            this.dtToDate.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(737, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 19);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grvSearchResult
            // 
            this.grvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSearchResult.Location = new System.Drawing.Point(46, 236);
            this.grvSearchResult.Name = "grvSearchResult";
            this.grvSearchResult.Size = new System.Drawing.Size(815, 262);
            this.grvSearchResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.grvSearchResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.txtMainSearch);
            this.Controls.Add(this.btnViewCars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem carClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCarTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCarTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCarTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerACustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carDamageAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCustomersRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairCostAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAReservationToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewCars;
        private System.Windows.Forms.TextBox txtMainSearch;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grvSearchResult;
    }
}

