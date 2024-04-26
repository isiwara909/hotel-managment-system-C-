using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel_managment_system
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();

            datagridview1();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ROVB596;Initial Catalog=hotel_managment;Integrated Security=True");

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void addtogrid()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Manage_reservation ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                datagridview1();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }

            finally
            {
                con.Close();
            }
        }


        public void addtogrid1()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Manage_room ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                datagridview1();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }

            finally
            {
                con.Close();
            }
        }

        public void addtogrid2()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("select *from Manage_client", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                datagridview1();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erorr" + ex);
            }
            finally
            {
                con.Close();
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                int reserved_id = Int32.Parse(txtrid.Text);
                int client_id = Int32.Parse(txtcid.Text);
                string room_type = rtcombo.Text;
                string room_no = rncombo.Text;
                string date_in = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                string date_out = dateTimePicker2.Value.ToString("MM/dd/yyyy");
                string sqlstring = "INSERT INTO manage_reservation VALUES('" + reserved_id + "','" + client_id + "','" + room_type + "','" + room_no + "','" + date_in + "','" + date_out + "')";
                SqlCommand cmd = new SqlCommand(sqlstring, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added Successfully", "SMD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addtogrid();
                datagridview1();
                con.Close();



            }


            catch { }


            finally { }


        }

        private void mnsave_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();
                int reserved_id = Int32.Parse(txtrid.Text);
                int client_id = Int32.Parse(txtcid.Text);
                string room_type = rtcombo.Text;
                string room_no = rncombo.Text;
                string date_in = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                string date_out = dateTimePicker2.Value.ToString("MM/dd/yyyy");
                string sqlstring = "INSERT INTO manage_reservation VALUES('" + reserved_id + "','" + client_id + "','" + room_type + "','" + room_no + "','" + date_in + "','" + date_out + "')";
                SqlCommand cmd = new SqlCommand(sqlstring, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added Successfully", "SMD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addtogrid();
                datagridview1();
                con.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtrid.Text = "";
            txtcid.Text = "";
            rtcombo.Text = "";
            rncombo.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }
        /*datagridview manage reservation */

        public void datagridview1()
        {
            dataGridView1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                int number = Int16.Parse(textBox6.Text);
                string type = comboBox1.Text;
                int phone = Int32.Parse(textBox8.Text);
                string reservation;
                if (radioButton1.Checked)
                {
                    reservation = "yes";

                }
                else
                {
                    reservation = "No";
                }
                string sqlstring = "INSERT INTO Manage_room VALUES('" + number + "','" + type + "','" + phone + "','" + reservation + "')";
                SqlCommand cmd = new SqlCommand(sqlstring, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added Successfully", "SMD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addtogrid1();
                datagridview1();
                con.Close();

            }


            catch { }
        }

    


        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            comboBox1.Text = "";
            textBox8.Text = "";
            radioButton1.Text = "";
            radioButton2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int id = Int16.Parse(textBox1.Text);
                string fname = textBox2.Text;
                string lname = textBox3.Text;
                int phone = Int16.Parse(textBox4.Text);
                string email = textBox5.Text;
                string sqlstring = "INSERT INTO Manage_client VALUES('" + id + "','" + fname + "','" + lname + "','" + phone + "','" + email + "')";
                SqlCommand cmd = new SqlCommand(sqlstring, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added Successfully", "SMD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addtogrid2();
                datagridview1();
                con.Close();


            }
            catch (Exception ex)
            {


                MessageBox.Show("Error!!" + ex);

            }
            finally
            {


            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int id = Int16.Parse(textBox1.Text);
                string fname = textBox2.Text;
                string lname = textBox3.Text;
                int phone = Int16.Parse(textBox4.Text);
                string email = textBox5.Text;
                string sqlstring = "INSERT INTO Manage_client VALUES('" + id + "','" + fname + "','" + lname + "','" + phone + "','" + email + "')";
                SqlCommand cmd = new SqlCommand(sqlstring, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added Successfully", "SMD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addtogrid2();
                datagridview1();
                con.Close();


            }
            catch (Exception ex)
            {


                MessageBox.Show("Error!!" + ex);

            }
            finally
            {


            }

            /*private void button8_Click(object sender, EventArgs e)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Manage_client WhERE Email = '" + textBox7.Text + "'", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        textBox1.Text = r[1].ToString();
                        textBox2.Text = r[2].ToString();
                        textBox3.Text = r[3].ToString();
                        textBox4.Text = r[4].ToString();
                        textBox5.Text = r[5].ToString();



                    }

                }
                catch
                {
                    MessageBox.Show("error");
                }
            }
        }*/

            /* private void button9_Click(object sender, EventArgs e)
             {
                 try
                 {
                     con.Open();
                     SqlCommand cmd = new SqlCommand("Select * from  Manage_reservation where Email = '" + textBox9.Text + "'", con);
                     SqlDataReader r = cmd.ExecuteReader();

                     if (r.Read())
                     {
                         txtrid.Text = r[1].ToString();
                         txtcid.Text = r[2].ToString();
                         rtcombo.Text = r[3].ToString();
                         rncombo.Text = r[4].ToString();
                         dateTimePicker1.Text = r[5].ToString();
                         dateTimePicker2.Text = r[6].ToString();
                     }
                 }
                 catch
                 {
                     MessageBox.Show("Error!!");

                 }

                 finally
                 {


                 }
     }*/
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ROVB596;Initial Catalog=hotel_managment;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from  Manage_reservation where [Reserved Id] = '" + textBox9.Text + "'", con);
                SqlDataReader r = cmd.ExecuteReader();

                string dt1, dt2;

                if (r.Read())
                {
                    txtrid.Text = r[0].ToString();
                    txtcid.Text = r[1].ToString();
                    rtcombo.Text = r[2].ToString();
                    rncombo.Text = r[3].ToString();
                    dt1 = r[4].ToString();
                    dt2 = r[5].ToString();
                    dateTimePicker1.Text = dt1;
                    
                    //= 
                    //dateTimePicker1.Value.ToShortDateString(r[5].ToString());// = r[5].ToString();
                    dateTimePicker2.Text = dt2;
                }
            }
            catch
            {
                MessageBox.Show("Error!!");

            }

            finally
            {

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                con.Open();
                int id = Int16.Parse(txtrid.Text);
                string clientid = txtcid.Text;
                string roomtype = rtcombo.Text;
                int roomno = Int16.Parse(rncombo.Text);
                string datein = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                string dateout = dateTimePicker2.Value.ToString("MM/dd/yyyy");


                SqlCommand cmd = new SqlCommand("Update Manage_reservation SET Reserved Id = '" + id + "',Client ID  = '" + clientid + "', Room Type = '" + roomtype + "', Room No = '" + roomno + "', Date In = '" + datein + "',Date out = '"+dateout+"'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details has been Updated");
                


            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {

            }
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * From Manage_reservation", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlDataAdapter ad = new SqlDataAdapter("Select * From Manage_room", con);
                DataTable dtt = new DataTable();
                ad.Fill(dtt);
                dataGridView2.DataSource = dtt;

                SqlDataAdapter adps = new SqlDataAdapter("Select * From Manage_client", con);
                DataTable d = new DataTable();
                adps.Fill(d);
                dataGridView2.DataSource = d;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int id = int.Parse(textBox1.Text);
                string fname = textBox2.Text;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }       
}