using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForTest
{
    public partial class Form1 : Form
    {
        DataTable myDataTable;

        public Form1()
        {
            InitializeComponent();
            
            //創建資料表
            myDataTable = CreateDataTable();

            //清空資料表
            myDataTable.Clear();
            //清除欄位被選取的事件
            dataGridView1.ClearSelection();

            dataGridView1.DataSource = myDataTable;
            
            //給定columns的Title
            dataGridView1.Columns["Name_data"].HeaderText = "名稱";
            dataGridView1.Columns["Age_data"].HeaderText = "年紀";
            dataGridView1.Columns["Gender_data"].HeaderText = "性別";

        }

        public DataTable CreateDataTable()
        {
            DataTable mDataTable = new DataTable();
            DataColumn mDataColumn;

            // 名稱
            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Name_data";
            mDataTable.Columns.Add(mDataColumn);

            // 年紀
            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.Int16");
            mDataColumn.ColumnName = "Age_data";
            mDataTable.Columns.Add(mDataColumn);

            // 性別
            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Gender_data";
            mDataTable.Columns.Add(mDataColumn);

            return mDataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 按下案件後的新增事件
            DataRow myDataRow = myDataTable.NewRow();

            myDataRow["Name_data"] = txtName.Text.Trim();
            myDataRow["Age_data"] = txtAge.Text.Trim();
            myDataRow["Gender_data"] = txtGender.Text.Trim();
            myDataTable.Rows.Add(myDataRow);
        }
    }
}
