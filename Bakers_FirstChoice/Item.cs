using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Bakers_FirstChoice
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Configuration;

    public partial class Item : Form
    {
        private string userName;
        private string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader sdr;

        public Item()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1100, 768);
            this.MaximumSize = new Size(1100, 768);
        }

        private void Item_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_username.Text = Login.user_name;
                BindListView();
                timer_tool.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_tool_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                lbl_timer.Text = dt.ToString("dd/MM/yyyy hh:mm:ss tt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindListView()
        {
            try
            {
                listview_item.Items.Clear();

                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "select * from tbl_item order by item_name ASC";
                    using (cmd = new SqlCommand(query, con))
                    {
                        using (sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                ListViewItem item = new ListViewItem(sdr["item_name"].ToString());
                                item.Tag = sdr["item_id"];
                                listview_item.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GetSelectedItemId()
        {
            try
            {
                if (listview_item.SelectedItems.Count > 0)
                {
                    return Convert.ToInt32(listview_item.SelectedItems[0].Tag);
                }
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void listview_item_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string item_name = listview_item.SelectedItems[0].SubItems[0].Text;
                txt_item_name.Text = item_name.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_item_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Char ch = e.KeyChar;
                if (!(Char.IsLetter(ch) || Char.IsWhiteSpace(ch) || ch == '\b'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string item_name = txt_item_name.Text.Trim();
                if (string.IsNullOrEmpty(item_name))
                {
                    errorProvider_item.SetError(this.txt_item_name, "Please Enter the Item !!");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string selectQuery = "select count(*) from tbl_item where item_name=@item_name";
                    using (cmd = new SqlCommand(selectQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show(item_name + " Item Name Already Exists", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                string insertQuery = "insert into tbl_item values(@item_name)";
                using (con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Item Name Added !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_item_name.Text = "";
                            BindListView();
                        }
                        else
                        {
                            MessageBox.Show("Item Name Not Added !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (listview_item.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string item_name = txt_item_name.Text.Trim();
                if (string.IsNullOrEmpty(item_name))
                {
                    errorProvider_item.SetError(this.txt_item_name, "Please Enter the Item !!");
                    return;
                }

                int item_id = GetSelectedItemId();
                if (item_id == -1)
                {
                    MessageBox.Show("Error getting item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string update_item = "update tbl_item set item_name=@new_item_name where item_id=@item_id";
                    using (cmd = new SqlCommand(update_item, con))
                    {
                        cmd.Parameters.AddWithValue("@new_item_name", item_name);
                        cmd.Parameters.AddWithValue("@item_id", item_id);

                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Item name updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindListView();
                            txt_item_name.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to update item name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListView
            if (listview_item.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the item_id of the selected item
            int item_id = GetSelectedItemId();

            if (item_id == -1)
            {
                MessageBox.Show("Error getting item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ask for confirmation before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (con = new SqlConnection(cs))
                    {
                        con.Open();
                        string delete_item = "DELETE FROM tbl_item WHERE item_id = @item_id";
                        using (cmd = new SqlCommand(delete_item, con))
                        {
                            cmd.Parameters.AddWithValue("@item_id", item_id);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_item_name.Text = "";
                                BindListView(); // Refresh the ListView
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete item. It may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_privious_Click(object sender, EventArgs e)
        {
            try
            {
                Grocery g = new Grocery();
                this.Hide();
                g.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Grocery g = new Grocery();
                this.Hide();
                g.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
