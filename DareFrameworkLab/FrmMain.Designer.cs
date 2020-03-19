namespace DareFrameworkLab
{
    partial class FrmMain
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
            this.pne_Main = new BlueOcean.Framework.CMControls.CMPanelEx();
            this.btn_Grid_MergeColum = new BlueOcean.Framework.CMControls.CMComButtonEx();
            this.btn_Grid_Select_Option = new BlueOcean.Framework.CMControls.CMComButton();
            this.pne_Main.ClientArea.SuspendLayout();
            this.pne_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pne_Main
            // 
            this.pne_Main.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            // 
            // pne_Main.ClientArea
            // 
            this.pne_Main.ClientArea.Controls.Add(this.btn_Grid_Select_Option);
            this.pne_Main.ClientArea.Controls.Add(this.btn_Grid_MergeColum);
            this.pne_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pne_Main.Location = new System.Drawing.Point(0, 0);
            this.pne_Main.Name = "pne_Main";
            this.pne_Main.Size = new System.Drawing.Size(284, 261);
            this.pne_Main.TabIndex = 0;
            // 
            // btn_Grid_MergeColum
            // 
            this.btn_Grid_MergeColum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Grid_MergeColum.Location = new System.Drawing.Point(12, 12);
            this.btn_Grid_MergeColum.Name = "btn_Grid_MergeColum";
            this.btn_Grid_MergeColum.Size = new System.Drawing.Size(116, 23);
            this.btn_Grid_MergeColum.TabIndex = 0;
            this.btn_Grid_MergeColum.Text = "Grid_Mergecolum";
            this.btn_Grid_MergeColum.Click += new System.EventHandler(this.btn_Grid_MergeColum_Click);
            // 
            // btn_Grid_Select_Option
            // 
            this.btn_Grid_Select_Option.BackColor = System.Drawing.Color.Transparent;
            this.btn_Grid_Select_Option.ColumnText = "";
            this.btn_Grid_Select_Option.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Grid_Select_Option.ForeBurshColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btn_Grid_Select_Option.Location = new System.Drawing.Point(12, 42);
            this.btn_Grid_Select_Option.Name = "btn_Grid_Select_Option";
            this.btn_Grid_Select_Option.Size = new System.Drawing.Size(116, 23);
            this.btn_Grid_Select_Option.TabIndex = 1;
            this.btn_Grid_Select_Option.Text = "Grid_Select_Option";
            this.btn_Grid_Select_Option.Click += new System.EventHandler(this.btn_Grid_Select_Option_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pne_Main);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.pne_Main.ClientArea.ResumeLayout(false);
            this.pne_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BlueOcean.Framework.CMControls.CMPanelEx pne_Main;
        private BlueOcean.Framework.CMControls.CMComButtonEx btn_Grid_MergeColum;
        private BlueOcean.Framework.CMControls.CMComButton btn_Grid_Select_Option;
    }
}

