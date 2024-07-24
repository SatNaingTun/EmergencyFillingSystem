namespace EmergencyFillingSystemClient
{
    partial class EntryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LitOMoney = new System.Windows.Forms.Label();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.vehicletxt = new System.Windows.Forms.TextBox();
            this.fuelprice = new System.Windows.Forms.TextBox();
            this.totallitre = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblFuelPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergencyDataSet = new EmergencyFillingSystemClient.EmergencyDataSet();
            this.tblFuelPriceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emergencyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.TextBox();
            this.tbl_FuelPriceTableAdapter = new EmergencyFillingSystemClient.EmergencyDataSetTableAdapters.Tbl_FuelPriceTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saletype = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuelPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuelPriceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fuel Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fuel Price";
            // 
            // LitOMoney
            // 
            this.LitOMoney.AutoSize = true;
            this.LitOMoney.Location = new System.Drawing.Point(22, 175);
            this.LitOMoney.Name = "LitOMoney";
            this.LitOMoney.Size = new System.Drawing.Size(54, 13);
            this.LitOMoney.TabIndex = 0;
            this.LitOMoney.Text = "Total Litre";
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Location = new System.Drawing.Point(22, 237);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(40, 13);
            this.Resultlbl.TabIndex = 0;
            this.Resultlbl.Text = " Result";
            // 
            // vehicletxt
            // 
            this.vehicletxt.Location = new System.Drawing.Point(126, 44);
            this.vehicletxt.Name = "vehicletxt";
            this.vehicletxt.Size = new System.Drawing.Size(100, 20);
            this.vehicletxt.TabIndex = 1;
            // 
            // fuelprice
            // 
            this.fuelprice.Enabled = false;
            this.fuelprice.Location = new System.Drawing.Point(126, 138);
            this.fuelprice.Name = "fuelprice";
            this.fuelprice.Size = new System.Drawing.Size(100, 20);
            this.fuelprice.TabIndex = 3;
            this.fuelprice.TabStop = false;
            // 
            // totallitre
            // 
            this.totallitre.Location = new System.Drawing.Point(126, 168);
            this.totallitre.Name = "totallitre";
            this.totallitre.Size = new System.Drawing.Size(100, 20);
            this.totallitre.TabIndex = 4;
            this.totallitre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totallitre_KeyDown);
            // 
            // TxtResult
            // 
            this.TxtResult.Enabled = false;
            this.TxtResult.Location = new System.Drawing.Point(126, 230);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(100, 20);
            this.TxtResult.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFuelPriceBindingSource, "Fuel_Type", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblFuelPriceBindingSource, "Fuel_Type", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblFuelPriceBindingSource, "Fuel_Type", true));
            this.comboBox1.DataSource = this.tblFuelPriceBindingSource1;
            this.comboBox1.DisplayMember = "Fuel_Type";
            this.comboBox1.Location = new System.Drawing.Point(126, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Fuel_Type";
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // tblFuelPriceBindingSource
            // 
            this.tblFuelPriceBindingSource.DataMember = "Tbl_FuelPrice";
            this.tblFuelPriceBindingSource.DataSource = this.emergencyDataSet;
            // 
            // emergencyDataSet
            // 
            this.emergencyDataSet.DataSetName = "EmergencyDataSet";
            this.emergencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFuelPriceBindingSource1
            // 
            this.tblFuelPriceBindingSource1.DataMember = "Tbl_FuelPrice";
            this.tblFuelPriceBindingSource1.DataSource = this.emergencyDataSetBindingSource;
            // 
            // emergencyDataSetBindingSource
            // 
            this.emergencyDataSetBindingSource.DataSource = this.emergencyDataSet;
            this.emergencyDataSetBindingSource.Position = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(83, 267);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discount";
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(126, 198);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(100, 20);
            this.Discount.TabIndex = 5;
            this.Discount.Text = "0";
            this.Discount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totallitre_KeyDown);
            // 
            // tbl_FuelPriceTableAdapter
            // 
            this.tbl_FuelPriceTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "User Name";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(156, 13);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(51, 13);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "unknown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "SaleType";
            // 
            // saletype
            // 
            this.saletype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.saletype.FormattingEnabled = true;
            this.saletype.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.saletype.Location = new System.Drawing.Point(126, 110);
            this.saletype.Name = "saletype";
            this.saletype.Size = new System.Drawing.Size(100, 21);
            this.saletype.TabIndex = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.saletype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.totallitre);
            this.Controls.Add(this.fuelprice);
            this.Controls.Add(this.vehicletxt);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.LitOMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntryForm";
            this.Text = "Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryForm_FormClosing);
            this.Load += new System.EventHandler(this.EntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFuelPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuelPriceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LitOMoney;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.TextBox vehicletxt;
        private System.Windows.Forms.TextBox fuelprice;
        private System.Windows.Forms.TextBox totallitre;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.ComboBox comboBox1;
        
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.BindingSource emergencyDataSetBindingSource;
        private EmergencyDataSet emergencyDataSet;
        private System.Windows.Forms.BindingSource tblFuelPriceBindingSource;
        private EmergencyDataSetTableAdapters.Tbl_FuelPriceTableAdapter tbl_FuelPriceTableAdapter;
        private System.Windows.Forms.BindingSource tblFuelPriceBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox saletype;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}

