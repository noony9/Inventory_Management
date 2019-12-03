namespace Inventory_Management
{
    partial class ModifyPartForm
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
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.MachineIDTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.PriceCostTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.Label();
            this.MachineID = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.PriceCost = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartLabel.Location = new System.Drawing.Point(40, 9);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(110, 25);
            this.ModifyPartLabel.TabIndex = 36;
            this.ModifyPartLabel.Text = "Modify Part";
            this.ModifyPartLabel.Click += new System.EventHandler(this.label49_Click);
            // 
            // MachineIDTextBox
            // 
            this.MachineIDTextBox.Location = new System.Drawing.Point(207, 277);
            this.MachineIDTextBox.Name = "MachineIDTextBox";
            this.MachineIDTextBox.Size = new System.Drawing.Size(151, 20);
            this.MachineIDTextBox.TabIndex = 52;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(207, 234);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(113, 20);
            this.MaxTextBox.TabIndex = 51;
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(377, 234);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinTextBox.TabIndex = 50;
            // 
            // PriceCostTextBox
            // 
            this.PriceCostTextBox.Location = new System.Drawing.Point(207, 193);
            this.PriceCostTextBox.Name = "PriceCostTextBox";
            this.PriceCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceCostTextBox.TabIndex = 49;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(207, 159);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.InventoryTextBox.TabIndex = 48;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(207, 125);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 47;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(207, 90);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 46;
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(347, 237);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(24, 13);
            this.Min.TabIndex = 45;
            this.Min.Text = "Min";
            // 
            // MachineID
            // 
            this.MachineID.AutoSize = true;
            this.MachineID.Location = new System.Drawing.Point(120, 280);
            this.MachineID.Name = "MachineID";
            this.MachineID.Size = new System.Drawing.Size(62, 13);
            this.MachineID.TabIndex = 44;
            this.MachineID.Text = "Machine ID";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(174, 237);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(27, 13);
            this.Max.TabIndex = 43;
            this.Max.Text = "Max";
            // 
            // PriceCost
            // 
            this.PriceCost.AutoSize = true;
            this.PriceCost.Location = new System.Drawing.Point(138, 196);
            this.PriceCost.Name = "PriceCost";
            this.PriceCost.Size = new System.Drawing.Size(63, 13);
            this.PriceCost.TabIndex = 42;
            this.PriceCost.Text = "Price / Cost";
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Location = new System.Drawing.Point(150, 162);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(51, 13);
            this.Inventory.TabIndex = 41;
            this.Inventory.Text = "Inventory";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(166, 128);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 40;
            this.Name.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(183, 93);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 39;
            this.ID.Text = "ID";
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(258, 27);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 38;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(169, 27);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadio.TabIndex = 37;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 426);
            this.Controls.Add(this.MachineIDTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.PriceCostTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.MachineID);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.PriceCost);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.ModifyPartLabel);
            this.Name = "ModifyPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyPartLabel;
        private System.Windows.Forms.TextBox MachineIDTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox PriceCostTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label MachineID;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label PriceCost;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.RadioButton InHouseRadio;
    }
}