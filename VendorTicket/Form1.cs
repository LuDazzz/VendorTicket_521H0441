using System.Data;
using System.Data.SqlClient;

namespace VendorTicket
{
    public partial class Form1 : Form
    {
        public static int price;

        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        SqlDataReader read;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbDes.SelectedIndex == -1 || cbVei.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose both destination and veihicle!");
                return;
            }
            else
            {
                calPrice();
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        void addComboDes()
        {
            string s = "select Diadiem from destinations";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            cbDes.DataSource= tb;
            cbDes.DisplayMember = "Diadiem";
            cbDes.ValueMember = "Diadiem";
        }
        void addComboVei()
        {
            string s = "select TenPT from veihicle";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            cbVei.DataSource = tb;
            cbVei.DisplayMember = "TenPT";
            cbVei.ValueMember = "TenPT";
        }
        void calPrice()
        {
            string s1 = "select Khoangcach from destinations where Diadiem = '" + cbDes.SelectedValue + "'";
            cm = new SqlCommand(s1, cn);
            read =  cm.ExecuteReader();
            int des = 0, mon = 0;
            if (read.Read())
            {
                des = int.Parse(read[0].ToString());
            }
            string s2 = "select Tientren1km from veihicle where TenPT = '" + cbVei.SelectedValue + "'";
            cm = new SqlCommand(s2, cn);
            read.Close();
            read = cm.ExecuteReader();
            if (read.Read())
            {
                mon = int.Parse(read[0].ToString());
            }
            price = mon * des;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("initial catalog = TicketVendor; data source = LUDAZZZ; integrated security = true");
            cn.Open();
            addComboDes();
            addComboVei();
        }
    }
}