﻿namespace Inventory_Management
{
    partial class ModifyProductForm
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
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ModifyProduct_PartsAssociated_GridView = new System.Windows.Forms.DataGridView();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Parts_Associated_Label = new System.Windows.Forms.Label();
            this.Candidate_Parts_Label = new System.Windows.Forms.Label();
            this.ModifyProduct_CandidateParts_GridView = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProduct_PartsAssociated_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProduct_CandidateParts_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.AutoSize = true;
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductLabel.Location = new System.Drawing.Point(40, 9);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(142, 25);
            this.ModifyProductLabel.TabIndex = 53;
            this.ModifyProductLabel.Text = "Modify Product";
            this.ModifyProductLabel.Click += new System.EventHandler(this.ModifyPartLabel_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(629, 411);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 74;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(723, 411);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 73;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyProduct_PartsAssociated_GridView
            // 
            this.ModifyProduct_PartsAssociated_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModifyProduct_PartsAssociated_GridView.Location = new System.Drawing.Point(394, 248);
            this.ModifyProduct_PartsAssociated_GridView.Name = "ModifyProduct_PartsAssociated_GridView";
            this.ModifyProduct_PartsAssociated_GridView.Size = new System.Drawing.Size(404, 128);
            this.ModifyProduct_PartsAssociated_GridView.TabIndex = 72;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(75, 262);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(113, 20);
            this.MaxTextBox.TabIndex = 71;
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(245, 262);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinTextBox.TabIndex = 70;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(100, 223);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 69;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(100, 187);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.InventoryTextBox.TabIndex = 68;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(100, 150);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 67;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(100, 115);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 66;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(42, 265);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(27, 13);
            this.Max.TabIndex = 65;
            this.Max.Text = "Max";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(42, 226);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 64;
            this.Price.Text = "Price";
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Location = new System.Drawing.Point(40, 190);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(51, 13);
            this.Inventory.TabIndex = 63;
            this.Inventory.Text = "Inventory";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(40, 153);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 62;
            this.NameLabel.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(40, 118);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 61;
            this.ID.Text = "ID";
            // 
            // Parts_Associated_Label
            // 
            this.Parts_Associated_Label.AutoSize = true;
            this.Parts_Associated_Label.Location = new System.Drawing.Point(394, 229);
            this.Parts_Associated_Label.Name = "Parts_Associated_Label";
            this.Parts_Associated_Label.Size = new System.Drawing.Size(167, 13);
            this.Parts_Associated_Label.TabIndex = 60;
            this.Parts_Associated_Label.Text = "Parts Associated with this Product";
            // 
            // Candidate_Parts_Label
            // 
            this.Candidate_Parts_Label.AutoSize = true;
            this.Candidate_Parts_Label.Location = new System.Drawing.Point(394, 47);
            this.Candidate_Parts_Label.Name = "Candidate_Parts_Label";
            this.Candidate_Parts_Label.Size = new System.Drawing.Size(96, 13);
            this.Candidate_Parts_Label.TabIndex = 59;
            this.Candidate_Parts_Label.Text = "All Candidate Parts";
            // 
            // ModifyProduct_CandidateParts_GridView
            // 
            this.ModifyProduct_CandidateParts_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModifyProduct_CandidateParts_GridView.Location = new System.Drawing.Point(394, 66);
            this.ModifyProduct_CandidateParts_GridView.Name = "ModifyProduct_CandidateParts_GridView";
            this.ModifyProduct_CandidateParts_GridView.Size = new System.Drawing.Size(404, 128);
            this.ModifyProduct_CandidateParts_GridView.TabIndex = 58;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(723, 200);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 57;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(487, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 56;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(568, 19);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(230, 20);
            this.SearchTextBox.TabIndex = 55;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(723, 382);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 54;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ModifyProduct_PartsAssociated_GridView);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Parts_Associated_Label);
            this.Controls.Add(this.Candidate_Parts_Label);
            this.Controls.Add(this.ModifyProduct_CandidateParts_GridView);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ModifyProductLabel);
            this.Name = "ModifyProductForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProduct_PartsAssociated_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProduct_CandidateParts_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyProductLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DataGridView ModifyProduct_PartsAssociated_GridView;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Parts_Associated_Label;
        private System.Windows.Forms.Label Candidate_Parts_Label;
        private System.Windows.Forms.DataGridView ModifyProduct_CandidateParts_GridView;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button DeleteBtn;
    }
}