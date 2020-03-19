using BlueOcean.Framework.BaseControls;
using Infragistics.Win;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DareFrameworkLab
{
    public partial class FrmGridviewMergeColumn : Form
    {
        public FrmGridviewMergeColumn()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void FrmGridviewMergeColumn_Load(object sender, EventArgs e)
        {
            SelectData();

        }
        private void InitializeGrid()
        {
            try
            {
                #region grid_Master
                this.grid_Master.AddColumn("ID", "Id", 75, Styles.Default, IsHAlign.Center, IsHidden.No, IsEdit.No, IsRequired.No, 6);
                this.grid_Master.AddColumn("GROUP_NAME", "FULL NAME", 100, Styles.Default, IsHAlign.Center, IsHidden.No);
                this.grid_Master.AddColumn("SURNAME", "Họ", 75, Styles.Default, IsHAlign.Left, IsHidden.No, IsEdit.No, IsRequired.No);
                this.grid_Master.AddColumn("MIDDLE_NAME", "TÊN ĐỆM", 75, Styles.Default, IsHAlign.Center, IsHidden.No, IsEdit.No, IsRequired.No, 6);
                this.grid_Master.AddColumn("NAME", "TÊN", 75, Styles.Default, IsHAlign.Center, IsHidden.No, IsEdit.No, IsRequired.No, 6);
                this.grid_Master.AddColumn("ETC", "Nội dung", 150, Styles.Default, IsHAlign.Left, IsHidden.No, IsEdit.No, IsRequired.No, 50);
                this.grid_Master.AddColumn("ETC1", "Nội dung1", 150, Styles.Default, IsHAlign.Left, IsHidden.No, IsEdit.No, IsRequired.No, 50);
                this.grid_Master.AddColumn("ETC2", "Nội dung2", 150, Styles.Default, IsHAlign.Left, IsHidden.No, IsEdit.No, IsRequired.No, 50);
                this.grid_Master.InitializeColumn(GridStyles.Search);
                this.grid_Master.EnabledRowSelectors = DefaultableBoolean.False;
                this.grid_Master.EnabledColumnSort = false;
                // 

                this.grid_Master.SetMergeHeader("ID", 0, 2, 2, 6);
                this.grid_Master.SetMergeHeader("GROUP_NAME",    2, 2, 6, 4, true);
                this.grid_Master.SetMergeHeader("SURNAME",       2, 6, 2, 2);
                this.grid_Master.SetMergeHeader("MIDDLE_NAME",   4, 6, 2, 2);
                this.grid_Master.SetMergeHeader("NAME",          6, 6, 2, 2);

                this.grid_Master.SetMergeHeader("ETC", 8, 2, 8, 2);

                this.grid_Master.SetMergeHeader("ETC1",   8, 4, 2, 2, true);
                this.grid_Master.SetMergeHeader("ETC2", 12, 4, 2, 2,true);

                this.grid_Master.SetMergeHeader( "ETC1_1", 8, 6, 2, 2);
                this.grid_Master.SetMergeHeader("ETC1_2", 10, 6, 2, 2);

                this.grid_Master.SetMergeHeader("ETC2_2", 12, 6, 2, 2);
                this.grid_Master.SetMergeHeader("ETC2_2", 14, 6, 2, 2);
                // KHAI BÁO

                //this.grid_Master.DisplayLayout.Bands[0].Columns["GROUP_NAME"].RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.LabelOnly;
                this.grid_Master.DisplayLayout.Bands[0].Columns["ETC"].RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.LabelOnly;
                //this.grid_Master.DisplayLayout.Bands[0].Columns["ETC1"].RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.LabelOnly;
                //this.grid_Master.DisplayLayout.Bands[0].Columns["ETC2"].RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.LabelOnly;

                //this.grid_Master.AddAutoSizeColumn("ETC", "ETC1", "ETC2");

                this.grid_Master.RaiseColumnWidthChanged();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SelectData()
        {
            this.grid_Master.FillDataSource = SeedData();
           // this.grid_Master.DataSource = SeedData(); HÀM NÀY SỬA DỤNG ĐỂ LẤY BẢN LÊN LƯỚI
        }

        private DataTable SeedData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("SURNAME");
            dt.Columns.Add("MIDDLE_NAME");
            dt.Columns.Add("NAME");
            dt.Columns.Add("ETC1_1");
            dt.Columns.Add("ETC1_2");
            dt.Columns.Add("ETC2_1");
            dt.Columns.Add("ETC2_2");
            DataRow row = dt.NewRow();
            row.SetField("ID", "01");
            row.SetField("SURNAME", "Nguyễn");
            row.SetField("MIDDLE_NAME", "Văn");
            row.SetField("NAME", "A");
            row.SetField("ETC1_1", "Nội dung ETC1.1");
            row.SetField("ETC1_2", "Nội dung ETC1.2");
            row.SetField("ETC2_1", "Nội dung ETC2.1");
            row.SetField("ETC2_2", "Nội dung ETC2.2");
            dt.Rows.Add(row);
            //for (int i = 0; i < 5; i++)
            //{
            //    dt.Rows.Add(randomRow(dt));
            //}
            return dt;

        }
        private DataRow randomRow(DataTable td)
        {

             DataRow row = td.NewRow();
            row.SetField("ID", RandomNumber(1,10));
            row.SetField("SURNAME", RandomString(2));
            row.SetField("MIDDLE_NAME", RandomString(3));
            row.SetField("NAME", RandomString(4));
            row.SetField("ETC2", RandomString(5));
              return row;
        }
        public string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            builder.Clear();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);

            }
            
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
