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
    public partial class Product : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter sda;

        public Product()
        {
            InitializeComponent();
            try
            {
                BindListView();
                BindComboBoxItems();


                comboBox_items.SelectedIndexChanged += new EventHandler(comboBox_items_SelectedIndexChanged);

                //userName = name;
                //lbl_username.Text = userName;

                this.MinimumSize = new Size(1100, 768); // Example: Minimum size 800x600

                this.MaximumSize = new Size(1100, 768);  // Set the maximum size of the form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Product_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_username.Text = Login.user_name;
                //BindListView();
                //BindComboBoxItems();
                timer_tool.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bind Listview
        void BindListView()
        {
            try
            {
                listview_product.Items.Clear();

                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string select_query = "select * from tbl_product";
                    using (cmd = new SqlCommand(select_query, con))
                    {
                        using (sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                ListViewItem item = new ListViewItem(sdr["product_name"].ToString());
                                item.SubItems.Add(sdr["product_price"].ToString());
                                item.Tag = sdr["product_id"];
                                listview_product.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bind ComboBox
        void BindComboBoxItems()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string select_item = "select * from tbl_item";
                    using (cmd = new SqlCommand(select_item, con))
                    {
                        using (sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                comboBox_items.Items.Add(sdr["item_name"].ToString());
                                //comboBox_items.Items.Add(sdr.GetString(0)) // Accessing column by index is more efficient
                            }
                        } // Automatically closes the SqlDataReader when exiting the using block
                    } // Automatically disposes of the SqlCommand when exiting the using block
                } // A
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception :" + ex.Message);
            }
        }

        // Bind ComboBox


        private void comboBox_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listview_product.Items.Clear();

                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string select_item = "SELECT item_id FROM tbl_item WHERE item_name = @comboitem_selectedItem";

                    using (SqlCommand cmdItem = new SqlCommand(select_item, con))
                    {
                        string selectedItem = comboBox_items.SelectedItem.ToString();
                        cmdItem.Parameters.AddWithValue("@comboitem_selectedItem", selectedItem);

                        object id = cmdItem.ExecuteScalar();

                        if (id != null)
                        {
                            int item_id = Convert.ToInt32(id);
                            string select_product = "SELECT product_id, product_name, product_price FROM tbl_product WHERE item_id = @item_id";

                            using (SqlCommand cmdProduct = new SqlCommand(select_product, con))
                            {
                                cmdProduct.Parameters.AddWithValue("@item_id", item_id);

                                using (SqlDataReader sdr = cmdProduct.ExecuteReader())
                                {
                                    while (sdr.Read())
                                    {
                                        ListViewItem item = new ListViewItem(sdr["product_name"].ToString());
                                        item.SubItems.Add(sdr["product_price"].ToString());
                                        item.Tag = sdr["product_id"];  // Store product_id in the ListViewItem's Tag
                                        listview_product.Items.Add(item);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No item_id found for the selected item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txt_product_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Char ch = e.KeyChar;
                if (char.IsLetter(ch) || char.IsWhiteSpace(ch) || ch == '-' || ch == '\b')
                {
                    e.Handled = false; // Allow the character so dont handle
                }
                else
                {
                    e.Handled = true; // Prevent the character from being entered
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_product_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Char ch = e.KeyChar;
                if (char.IsDigit(ch) && ch != '.' || ch == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GetSelectedProductId()
        {
            if (listview_product.SelectedItems.Count > 0)
            {
                try
                {
                    return Convert.ToInt32(listview_product.SelectedItems[0].Tag); //Product_id

                }
                catch (FormatException ex)
                {
                    // Handle conversion error
                    Console.WriteLine("Error converting Tag to int: " + ex.Message);
                }
            }
            return -1;
        }

        public void ListViewProduct_Update()
        {
            try
            {
                listview_product.Items.Clear();

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Assuming comboBox_items.SelectedItem contains the item name
                    string select_product = "SELECT product_name, product_price FROM tbl_product " +
                                            "WHERE item_id IN (SELECT item_id FROM tbl_item WHERE item_name = @comboitem_selectedItem)";

                    using (cmd = new SqlCommand(select_product, con))
                    {
                        cmd.Parameters.AddWithValue("@comboitem_selectedItem", comboBox_items.SelectedItem);

                        using (sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                // Create ListViewItem and add sub-items
                                ListViewItem item = new ListViewItem(sdr["product_name"].ToString());
                                item.SubItems.Add(sdr["product_price"].ToString());
                                listview_product.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        // Insert Product
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string product_name = txt_product_name.Text.Trim();
                string product_price = txt_product_price.Text.Trim();

                if (string.IsNullOrEmpty(product_name))
                {
                    errorProvider_pname.SetError(this.txt_product_price, "Please Enter the Product Name !!");
                    return;
                }

                if (string.IsNullOrEmpty(product_name))
                {
                    errorProvider_pname.SetError(this.txt_product_price, "Please Enter the Product Price !!");
                    return;
                }

                // Check if the product name already exists
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string select_product = "select count(*) from tbl_product where product_name = @product_name";
                    using (cmd = new SqlCommand(select_product, con))
                    {
                        cmd.Parameters.AddWithValue("@product_name", product_name);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Product name already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                // If item_name does not exist, insert it
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string select_itemid = "select * from tbl_item where item_name=@comboitem_selectedItem";

                    using (cmd = new SqlCommand(select_itemid, con))
                    {
                        cmd.Parameters.AddWithValue("@comboitem_selectedItem", comboBox_items.SelectedItem);
                        object id = cmd.ExecuteScalar();

                        if (id != null)
                        {
                            int item_id = (int)id;
                            //string insert_product = "insert into tbl_product values product_name=@product_name,item_id=@item_id,product_price=@product_price";
                            string insert_product = "insert into tbl_product (product_name, item_id, product_price) values (@product_name, @item_id, @product_price)";

                            using (cmd = new SqlCommand(insert_product, con))
                            {
                                cmd.Parameters.AddWithValue("@item_id", item_id);
                                cmd.Parameters.AddWithValue("@product_name", product_name);
                                cmd.Parameters.AddWithValue("@product_price", product_price);

                                int a = cmd.ExecuteNonQuery();
                                if (a > 0)
                                {
                                    MessageBox.Show("Product Name Added !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_product_name.Text = "";
                                    txt_product_price.Text = "";
                                    ListViewProduct_Update();
                                }
                                else
                                {
                                    MessageBox.Show("Item Name Not Added !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
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

        // Update
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (listview_product.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string product_name = txt_product_name.Text.Trim();
                string product_price = txt_product_price.Text.Trim();

                if (string.IsNullOrEmpty(product_name) || string.IsNullOrEmpty(product_price))
                {
                    MessageBox.Show("Please enter product name and price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int product_id = GetSelectedProductId(); // Get the selected product ID

                //int product_id = 1030; // Get the selected product ID


                if (product_id == -1)
                {
                    MessageBox.Show("Error getting product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                DialogResult result = MessageBox.Show("Are you sure you want to Update this Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (con = new SqlConnection(cs))
                    {
                        con.Open();
                        string update_product_query = "update tbl_product SET product_name = @product_name, product_price = @product_price WHERE product_id = @product_id";

                        using (cmd = new SqlCommand(update_product_query, con))
                        {
                            cmd.Parameters.AddWithValue("@product_name", product_name);
                            cmd.Parameters.AddWithValue("@product_price", product_price);
                            cmd.Parameters.AddWithValue("@product_id", product_id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BindListView(); // Refresh the ListView
                                txt_product_name.Text = "";
                                txt_product_price.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to update product. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        // Delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string product_name = txt_product_name.Text.Trim();
                //string product_price = txt_product_price.Text.Trim();

                // Check if an item is selected in the ListView
                if (listview_product.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an Product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Get the product name of the selected item
                product_name = listview_product.SelectedItems[0].Text;


                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (con = new SqlConnection(cs))
                    {
                        con.Open();
                        string delete_product = "delete from tbl_product where product_name=@product_name";
                        using (cmd = new SqlCommand(delete_product, con))
                        {
                            cmd.Parameters.AddWithValue("@product_name", product_name);

                            int a = cmd.ExecuteNonQuery();

                            if (a > 0)
                            {
                                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_product_name.Text = "";
                                txt_product_price.Text = "";
                                BindListView(); // Refresh the ListView
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listview_product_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listview_product.SelectedItems.Count > 0)
                {
                    string product_name = listview_product.SelectedItems[0].SubItems[0].Text;
                    string product_price = listview_product.SelectedItems[0].SubItems[1].Text;
                    txt_product_name.Text = product_name.Trim();
                    txt_product_price.Text = product_price.Trim();
                }
                else
                {
                    MessageBox.Show("Please select a product from the list.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}




