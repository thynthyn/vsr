using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SF2022User_NN_Lib;

namespace VSRPR
{
    public partial class SotrudnikForm : Form
    {

        DataBases dataBases = new DataBases();
        public static DataTable dt = new DataTable();


        public SotrudnikForm()
        {
            InitializeComponent();
            dataBases.OpenConnection();
            TipComboBox.SelectedIndex = 0;
            StatusComboBox.SelectedIndex = 0;

            TipComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            StatusComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            FiltersFill();
            TableFill();

        }

        private void View_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            RequestForm requestForm = new RequestForm();
            requestForm.ShowDialog();
            Upp();
        }

        private void Upp()
        {

        }

        private void TableFill()
        {


            string query = "select * from tt";
            SqlCommand cmd = new SqlCommand(query, dataBases.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            
            adapter.Fill(dt);
            if (TipComboBox.SelectedIndex != 0 && dt.Rows.Count > 0)
            {
                try
                {
                    dt = dt.AsEnumerable().Where(r => r.Field<string>("Группа") == TipComboBox.Text).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            if (StatusComboBox.SelectedIndex != 0 && dt.Rows.Count > 0)
            {
                try
                {
                    dt = dt.AsEnumerable().Where(r => r.Field<string>("Status") == StatusComboBox.Text).CopyToDataTable();
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }



            dataGridView1.DataSource = dt;




        }

        private void FiltersFill()
        {


        }

        private void SotrudnikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableFill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*TimeSpan[] startTimes = { new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), new TimeSpan(15, 0, 0), new TimeSpan(15, 30, 0), new TimeSpan(16, 50, 0) };
            int[] durations = { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new TimeSpan(08, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);
            int consultationTime = 30;
            string[] peridots = Calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);
            PodrazdelComboBox.Items.AddRange(peridots);*/
            
            

        }
    }
}
