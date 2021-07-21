
namespace VehicleInventory
{
    partial class VehicleInventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewVehicle = new System.Windows.Forms.TabPage();
            this.tabInventoryList = new System.Windows.Forms.TabPage();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.lbLicense = new System.Windows.Forms.Label();
            this.lbVIN = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabNewVehicle.SuspendLayout();
            this.tabInventoryList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabNewVehicle);
            this.tabControl1.Controls.Add(this.tabInventoryList);
            this.tabControl1.Location = new System.Drawing.Point(46, 33);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNewVehicle
            // 
            this.tabNewVehicle.Controls.Add(this.btAdd);
            this.tabNewVehicle.Controls.Add(this.tbVIN);
            this.tabNewVehicle.Controls.Add(this.tbLicense);
            this.tabNewVehicle.Controls.Add(this.lbType);
            this.tabNewVehicle.Controls.Add(this.lbVIN);
            this.tabNewVehicle.Controls.Add(this.lbLicense);
            this.tabNewVehicle.Controls.Add(this.tbResults);
            this.tabNewVehicle.Controls.Add(this.cbType);
            this.tabNewVehicle.Location = new System.Drawing.Point(4, 4);
            this.tabNewVehicle.Name = "tabNewVehicle";
            this.tabNewVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewVehicle.Size = new System.Drawing.Size(416, 320);
            this.tabNewVehicle.TabIndex = 0;
            this.tabNewVehicle.Text = "New Vehicle Form";
            this.tabNewVehicle.UseVisualStyleBackColor = true;
            // 
            // tabInventoryList
            // 
            this.tabInventoryList.Controls.Add(this.tbSummary);
            this.tabInventoryList.Controls.Add(this.lbInventory);
            this.tabInventoryList.Location = new System.Drawing.Point(4, 4);
            this.tabInventoryList.Name = "tabInventoryList";
            this.tabInventoryList.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventoryList.Size = new System.Drawing.Size(416, 320);
            this.tabInventoryList.TabIndex = 1;
            this.tabInventoryList.Text = "Inventory List";
            this.tabInventoryList.UseVisualStyleBackColor = true;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Sedan",
            "Truck"});
            this.cbType.Location = new System.Drawing.Point(96, 113);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(151, 28);
            this.cbType.TabIndex = 0;
            this.cbType.Text = "Sedan";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.ItemHeight = 20;
            this.lbInventory.Location = new System.Drawing.Point(44, 76);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(150, 104);
            this.lbInventory.TabIndex = 0;
            this.lbInventory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbInventory_MouseDoubleClick);
            // 
            // tbSummary
            // 
            this.tbSummary.Location = new System.Drawing.Point(47, 227);
            this.tbSummary.Multiline = true;
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.ReadOnly = true;
            this.tbSummary.Size = new System.Drawing.Size(125, 34);
            this.tbSummary.TabIndex = 1;
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(62, 202);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(252, 73);
            this.tbResults.TabIndex = 1;
            // 
            // lbLicense
            // 
            this.lbLicense.AutoSize = true;
            this.lbLicense.Location = new System.Drawing.Point(29, 28);
            this.lbLicense.Name = "lbLicense";
            this.lbLicense.Size = new System.Drawing.Size(57, 20);
            this.lbLicense.TabIndex = 2;
            this.lbLicense.Text = "License";
            // 
            // lbVIN
            // 
            this.lbVIN.AutoSize = true;
            this.lbVIN.Location = new System.Drawing.Point(29, 71);
            this.lbVIN.Name = "lbVIN";
            this.lbVIN.Size = new System.Drawing.Size(33, 20);
            this.lbVIN.TabIndex = 3;
            this.lbVIN.Text = "VIN";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(29, 116);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(40, 20);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "Type";
            this.lbType.Click += new System.EventHandler(this.lbType_Click);
            // 
            // tbLicense
            // 
            this.tbLicense.Location = new System.Drawing.Point(96, 28);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(125, 27);
            this.tbLicense.TabIndex = 5;
            this.tbLicense.TextChanged += new System.EventHandler(this.tbLicense_TextChanged);
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(96, 64);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(125, 27);
            this.tbVIN.TabIndex = 6;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(127, 147);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 29);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // VehicleInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "VehicleInventoryForm";
            this.Text = "VehicleInventoryForm";
            this.tabControl1.ResumeLayout(false);
            this.tabNewVehicle.ResumeLayout(false);
            this.tabNewVehicle.PerformLayout();
            this.tabInventoryList.ResumeLayout(false);
            this.tabInventoryList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNewVehicle;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TabPage tabInventoryList;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.ListBox lbInventory;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbVIN;
        private System.Windows.Forms.Label lbLicense;
        private System.Windows.Forms.Button btAdd;
    }
}

