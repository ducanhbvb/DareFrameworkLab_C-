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
    public partial class FrmGrid_Select_Option : Form
    {
        DataTable dtTable = new DataTable("Employee");

        private DataTable SeedData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeName");
            dt.Columns.Add("MobileNo");
            dt.Columns.Add("PresentAddress");
            dt.Columns.Add("Qualitication");
            dt.Columns.Add("EmailAddress");
            DataRow row = dt.NewRow();
            row.SetField("EmployeeName", "01");
            row.SetField("MobileNo", "Nguyễn");
            row.SetField("PresentAddress", "Văn");
            row.SetField("Qualitication", "A");
            row.SetField("EmailAddress", "Nội dung ABCD");
            dt.Rows.Add(row);
            for (int i = 0; i < 5; i++)
            {
                dt.Rows.Add(randomRow(dt));
            }
            return dt;

        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private DataRow randomRow(DataTable td)
        {

            DataRow row = td.NewRow();
            row.SetField("EmployeeName", RandomNumber(1, 10));
            row.SetField("MobileNo", RandomString(2));
            row.SetField("PresentAddress", RandomString(3));
            row.SetField("Qualitication", RandomString(4));
            row.SetField("EmailAddress", RandomString(5));
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
        public FrmGrid_Select_Option()
        {
            InitializeComponent();
            dtTable = SeedData();
           // InitializeSelect();
            AddRows();
        }
        private void InitializeSelect()
        {

        }
        private void AddRows()
        {
            DataRow row = null;
            row = dtTable.NewRow();

            int iCntCol = 0;

            for (iCntCol = 1; iCntCol <= 10; iCntCol++)
            {
                row = dtTable.NewRow();     // ADD BLANK ROWS TO THE DATATABLE.
                dtTable.Rows.Add(row);
            }

            // ADD DATATABLE TO GRID. (WITH THE BLANK ROWS)
            grid_Master.DataSource = dtTable;

            //ADD SOME COLOR TO THE GRID.
            grid_Master.GridColor = Color.FromArgb(211, 222, 229);
            grid_Master.BackgroundColor = Color.Wheat;

            grid_Master.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_Master.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            grid_Master.RowsDefaultCellStyle.SelectionForeColor = Color.White;
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                // ON ENTER KEY, GO TO THE NEXT CELL. 
                // WHEN THE CURSOR REACHES THE LAST COLUMN, CARRY IT ON TO THE NEXT ROW.

                if (ActiveControl.Name == "grid_Master")
                {
                    // CHECK IF ITS THE LAST COLUMN
                    if (grid_Master.CurrentCell.ColumnIndex == grid_Master.ColumnCount - 1)
                    {
                        // GO TO THE FIRST COLUMN, NEXT ROW.
                        grid_Master.CurrentCell =
                            grid_Master.Rows[grid_Master.CurrentCell.RowIndex + 1]
                                .Cells[0];
                    }
                    else
                    {
                        // NEXT COLUMN.
                        grid_Master.CurrentCell =
                            grid_Master.Rows[grid_Master.CurrentRow.Index]
                            .Cells[grid_Master.CurrentCell.ColumnIndex + 1];
                    }

                    return true;
                }
                else if (ActiveControl is DataGridViewTextBoxEditingControl)
                {
                    // SHOW THE COMBOBOX WHEN FOCUS IS ON A CELL CORRESPONDING TO THE "QUALIFICATION" COLUMN.
                    if (grid_Master.Columns[grid_Master.CurrentCell.ColumnIndex].Name == "PresentAddress")
                    {
                        grid_Master.CurrentCell =
                            grid_Master.Rows[grid_Master.CurrentRow.Index]
                                .Cells[grid_Master.CurrentCell.ColumnIndex + 1];

                        // SHOW COMBOBOX.
                        Show_Combobox(grid_Master.CurrentRow.Index,
                            grid_Master.CurrentCell.ColumnIndex);

                        SendKeys.Send("{F4}");      // DROP DOWN THE LIST.
                        return true;
                    }
                    else
                    {
                        // CHECK IF ITS THE LAST COLUMN.
                        if (grid_Master.CurrentCell.ColumnIndex == grid_Master.ColumnCount - 1)
                        {
                            // GO TO THE FIRST COLUMN, NEXT ROW.
                            grid_Master.CurrentCell =
                                grid_Master.Rows[grid_Master.CurrentCell.RowIndex + 1]
                                    .Cells[0];
                        }
                        else
                        {
                            // NEXT COLUMN.
                            grid_Master.CurrentCell = grid_Master.Rows[grid_Master.CurrentRow.Index] .Cells[grid_Master.CurrentCell.ColumnIndex + 1];
                        }
                        return true;
                    }
                }
                else if (ActiveControl.Name == "ComboBox1")
                {
                    // HIDE THE COMBOBOX AND ASSIGN COMBO'S VALUE TO THE CELL.
                    ComboBox1.Visible = false;

                    grid_Master.Focus();

                    // ONCE THE COMBO IS SET AS INVISIBLE, SET FOCUS BACK TO THE GRID. 
                    // (IMPORTANT)
                    grid_Master[grid_Master.CurrentCell.ColumnIndex,grid_Master.CurrentRow.Index].Value = ComboBox1.Text;
                    grid_Master.CurrentCell = grid_Master.Rows[grid_Master.CurrentRow.Index].Cells[grid_Master.CurrentCell.ColumnIndex + 1];
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
                return true;
            }
            else if (keyData == Keys.Escape)            // PRESS ESCAPE TO HIDE THE COMBOBOX.
            {
                if (ActiveControl.Name == "ComboBox1")
                {
                    ComboBox1.Text = "";
                    ComboBox1.Visible = false;

                    grid_Master.CurrentCell =
                        grid_Master.Rows[grid_Master.CurrentCell.RowIndex].Cells[grid_Master.CurrentCell.ColumnIndex];
                    grid_Master.Focus();
                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void Show_Combobox(int iRowIndex, int iColumnIndex)
        {
            // DESCRIPTION: SHOW THE COMBO BOX IN THE SELECTED CELL OF THE GRID.
            // PARAMETERS: iRowIndex - THE ROW ID OF THE GRID.
            //             iColumnIndex - THE COLUMN ID OF THE GRID.

            int x = 0;
            int y = 0;
            int Width = 0;
            int height = 0;

            // GET THE ACTIVE CELL'S DIMENTIONS TO BIND THE COMBOBOX WITH IT.
            Rectangle rect = default(Rectangle);
            rect = grid_Master.GetCellDisplayRectangle(iColumnIndex, iRowIndex, false);
            x = rect.X + grid_Master.Left;
            y = rect.Y + grid_Master.Top;

            Width = rect.Width;
            height = rect.Height;

            ComboBox1.SetBounds(x, y, Width, height);
            ComboBox1.Visible = true;
            ComboBox1.Focus();
        }

    }
}
