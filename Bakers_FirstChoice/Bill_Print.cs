using Bakers_FirstChoice.Report;
using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bakers_FirstChoice
{
    public partial class Bill_Print : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter sda;

        public Bill_Print()
        {
            InitializeComponent();
        }

        private void Bill_Print_Load(object sender, EventArgs e)
        {
            // Report initialization
            Report_Print();
        }

        void Report_Print()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {

                    con.Open(); // Ensure the connection is open

                        
                    string cust_phone = "5443564675756745676"; // Replace with the actual value you need

                    string select_bill_print = "SELECT * FROM tbl_bill_print WHERE cust_phone = @Phone";
                    using (sda = new SqlDataAdapter(select_bill_print, con))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@Phone", cust_phone);

                        DataSet1 ds = new DataSet1();
                        sda.Fill(ds, "DataTable_Invoice");

                        // Check if the dataset is filled
                        if (ds.Tables["DataTable_Invoice"].Rows.Count > 0)
                        {
                            // Set the report data source
                            ReportDataSource dataSource = new ReportDataSource("DataSet_Report", ds.Tables[0]);

                            // Clear existing data sources
                            reportViewer1.LocalReport.DataSources.Clear();


                            // Add the new data source
                            reportViewer1.LocalReport.DataSources.Add(dataSource);


                             

                            // Refresh the report
                            reportViewer1.LocalReport.Refresh();
                            reportViewer1.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("No data found for the specified phone number.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_bill_print_Click(object sender, EventArgs e)
        {
            
        }
    }
}
