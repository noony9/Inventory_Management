namespace Inventory_Management
{
    partial class AddPart
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
            this.InHousePart = new System.Windows.Forms.RadioButton();
            this.OutsourcedPart = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Label();
            this.PriceCost = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.MachineID = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SavePart = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InHousePart
            // 
            this.InHousePart.AutoSize = true;
            this.InHousePart.Location = new System.Drawing.Point(162, 29);
            this.InHousePart.Name = "InHousePart";
            this.InHousePart.Size = new System.Drawing.Size(68, 17);
            this.InHousePart.TabIndex = 1;
            this.InHousePart.TabStop = true;
            this.InHousePart.Text = "In-House";
            this.InHousePart.UseVisualStyleBackColor = true;
            // 
            // OutsourcedPart
            // 
            this.OutsourcedPart.AutoSize = true;
            this.OutsourcedPart.Location = new System.Drawing.Point(251, 29);
            this.OutsourcedPart.Name = "OutsourcedPart";
            this.OutsourcedPart.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedPart.TabIndex = 2;
            this.OutsourcedPart.TabStop = true;
            this.OutsourcedPart.Text = "Outsourced";
            this.OutsourcedPart.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(176, 95);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(159, 130);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 4;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Location = new System.Drawing.Point(143, 164);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(51, 13);
            this.Inventory.TabIndex = 5;
            this.Inventory.Text = "Inventory";
            this.Inventory.Click += new System.EventHandler(this.Label4_Click);
            // 
            // PriceCost
            // 
            this.PriceCost.AutoSize = true;
            this.PriceCost.Location = new System.Drawing.Point(131, 198);
            this.PriceCost.Name = "PriceCost";
            this.PriceCost.Size = new System.Drawing.Size(63, 13);
            this.PriceCost.TabIndex = 6;
            this.PriceCost.Text = "Price / Cost";
            this.PriceCost.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(167, 239);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(27, 13);
            this.Max.TabIndex = 7;
            this.Max.Text = "Max";
            // 
            // MachineID
            // 
            this.MachineID.AutoSize = true;
            this.MachineID.Location = new System.Drawing.Point(113, 282);
            this.MachineID.Name = "MachineID";
            this.MachineID.Size = new System.Drawing.Size(62, 13);
            this.MachineID.TabIndex = 8;
            this.MachineID.Text = "Machine ID";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(340, 239);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(24, 13);
            this.Min.TabIndex = 9;
            this.Min.Text = "Min";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(370, 236);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(200, 236);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(200, 279);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(151, 20);
            this.textBox7.TabIndex = 16;
            // 
            // SavePart
            // 
            this.SavePart.Location = new System.Drawing.Point(332, 361);
            this.SavePart.Name = "SavePart";
            this.SavePart.Size = new System.Drawing.Size(75, 23);
            this.SavePart.TabIndex = 17;
            this.SavePart.Text = "Save";
            this.SavePart.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(432, 361);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(39, 13);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(88, 25);
            this.label49.TabIndex = 19;
            this.label49.Text = "Add Part";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 424);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SavePart);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.MachineID);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.PriceCost);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.OutsourcedPart);
            this.Controls.Add(this.InHousePart);
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton InHousePart;
        private System.Windows.Forms.RadioButton OutsourcedPart;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Label PriceCost;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label MachineID;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button SavePart;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label49;
    }
}