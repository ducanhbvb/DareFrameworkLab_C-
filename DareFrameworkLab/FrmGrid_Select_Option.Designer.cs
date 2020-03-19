namespace DareFrameworkLab
{
    partial class FrmGrid_Select_Option
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
            this.pne_Grid_Select_Option = new BlueOcean.Framework.CMControls.CMPanelEx();
            this.tbl_Main = new BlueOcean.Framework.CMControls.CMTableLayoutPanel();
            this.pne_Down = new System.Windows.Forms.Panel();
            this.pne_Top = new System.Windows.Forms.Panel();
            this.pne_Grid = new System.Windows.Forms.Panel();
            this.grid_Master = new System.Windows.Forms.DataGridView();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreSentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualitication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pne_Grid_Select_Option.ClientArea.SuspendLayout();
            this.pne_Grid_Select_Option.SuspendLayout();
            this.tbl_Main.SuspendLayout();
            this.pne_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Master)).BeginInit();
            this.SuspendLayout();
            // 
            // pne_Grid_Select_Option
            // 
            this.pne_Grid_Select_Option.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            // 
            // pne_Grid_Select_Option.ClientArea
            // 
            this.pne_Grid_Select_Option.ClientArea.Controls.Add(this.tbl_Main);
            this.pne_Grid_Select_Option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pne_Grid_Select_Option.Location = new System.Drawing.Point(0, 0);
            this.pne_Grid_Select_Option.Name = "pne_Grid_Select_Option";
            this.pne_Grid_Select_Option.Size = new System.Drawing.Size(584, 361);
            this.pne_Grid_Select_Option.TabIndex = 0;
            // 
            // tbl_Main
            // 
            this.tbl_Main.ColumnCount = 1;
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Main.Controls.Add(this.pne_Down, 0, 2);
            this.tbl_Main.Controls.Add(this.pne_Top, 0, 0);
            this.tbl_Main.Controls.Add(this.pne_Grid, 0, 1);
            this.tbl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Main.Location = new System.Drawing.Point(0, 0);
            this.tbl_Main.Name = "tbl_Main";
            this.tbl_Main.RowCount = 3;
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbl_Main.Size = new System.Drawing.Size(584, 361);
            this.tbl_Main.TabIndex = 0;
            // 
            // pne_Down
            // 
            this.pne_Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pne_Down.Location = new System.Drawing.Point(3, 329);
            this.pne_Down.Name = "pne_Down";
            this.pne_Down.Size = new System.Drawing.Size(578, 29);
            this.pne_Down.TabIndex = 2;
            // 
            // pne_Top
            // 
            this.pne_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pne_Top.Location = new System.Drawing.Point(3, 3);
            this.pne_Top.Name = "pne_Top";
            this.pne_Top.Size = new System.Drawing.Size(578, 29);
            this.pne_Top.TabIndex = 0;
            // 
            // pne_Grid
            // 
            this.pne_Grid.Controls.Add(this.ComboBox1);
            this.pne_Grid.Controls.Add(this.grid_Master);
            this.pne_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pne_Grid.Location = new System.Drawing.Point(3, 38);
            this.pne_Grid.Name = "pne_Grid";
            this.pne_Grid.Size = new System.Drawing.Size(578, 285);
            this.pne_Grid.TabIndex = 1;
            // 
            // grid_Master
            // 
            this.grid_Master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Master.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeName,
            this.MobileNo,
            this.PreSentAddress,
            this.Qualitication,
            this.EmailAddress});
            this.grid_Master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Master.Location = new System.Drawing.Point(0, 0);
            this.grid_Master.Name = "grid_Master";
            this.grid_Master.Size = new System.Drawing.Size(578, 285);
            this.grid_Master.TabIndex = 0;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(383, 22);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(97, 21);
            this.ComboBox1.TabIndex = 0;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            // 
            // PreSentAddress
            // 
            this.PreSentAddress.DataPropertyName = "PreSentAddress";
            this.PreSentAddress.HeaderText = "PreSentAddress";
            this.PreSentAddress.Name = "PreSentAddress";
            // 
            // Qualitication
            // 
            this.Qualitication.DataPropertyName = "Qualitication";
            this.Qualitication.HeaderText = "Qualitication";
            this.Qualitication.Name = "Qualitication";
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Width = 95;
            // 
            // FrmGrid_Select_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pne_Grid_Select_Option);
            this.Name = "FrmGrid_Select_Option";
            this.Text = "Grid_Select_Option";
            this.pne_Grid_Select_Option.ClientArea.ResumeLayout(false);
            this.pne_Grid_Select_Option.ResumeLayout(false);
            this.tbl_Main.ResumeLayout(false);
            this.pne_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BlueOcean.Framework.CMControls.CMPanelEx pne_Grid_Select_Option;
        private BlueOcean.Framework.CMControls.CMTableLayoutPanel tbl_Main;
        private System.Windows.Forms.Panel pne_Down;
        private System.Windows.Forms.Panel pne_Top;
        private System.Windows.Forms.Panel pne_Grid;
        private System.Windows.Forms.DataGridView grid_Master;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreSentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualitication;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
    }
}