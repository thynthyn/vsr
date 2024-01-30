using System.Data.SqlClient;

namespace VSRPR
{
    public partial class AuthorizationForm : Form
    {
        ErrorProvider error = new ErrorProvider();
        DataBases dataBases = new DataBases();

        public AuthorizationForm()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataBases.OpenConnection();
            Authorizate();
            dataBases.CloseConnection();
        }


        private void Authorizate()
        {
           
            error.Clear();

            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            string login = textBox1.Text;
            string query = "select id from Sotrudnik where KodSotrudnik = @login";
            SqlCommand cmd = new SqlCommand(query, dataBases.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@login", login.Trim());
            var result = cmd.ExecuteScalar();
            if(result == null )
            {
                error.SetError(textBox1, "Неверный код!");
                return;
            }
            
            SotrudnikForm sotrudnikForm = new SotrudnikForm(); 
            sotrudnikForm.Show();
            this.Hide();
        }
    }
}
