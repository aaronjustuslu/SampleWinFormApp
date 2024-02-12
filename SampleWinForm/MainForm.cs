using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;
using System.Xml.Linq;
using System.Windows.Forms;

namespace SampleWinForm;

public partial class MainForm : Form
{
    //Update SQL Connection String Here
    SqlConnection conn = new SqlConnection(@"Data Source=STORMTROOPER\SQLEXPRESS;Initial Catalog=SAMPLE;Integrated Security=True");
    SqlCommand cmd;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        UpdateGridView();
    }

    private void UpdateGridView()
    {
        try
        {
            if (conn != null && conn.State == ConnectionState.Closed)
                conn.Open();

            String query = "SELECT * FROM USERS";
            SqlCommand cmdForGridView = new SqlCommand(query, conn);
            SqlDataReader reader = cmdForGridView.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView.DataSource = table;
            dataGridView.Columns["Id"].Visible = false;
        }
        catch
        {
            MessageBox.Show("Error");
        }
        finally
        {
            conn.Close();
        }
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        conn.Open();

        String name, email, birthday, color, isMarried, submitDate;

        name = nameText.Text;
        email = emailText.Text;
        birthday = birthdayDatePicker.Value.ToShortDateString();

        if (yellowRadioButton.Checked)
            color = "Yellow";
        else if (greenRadioButton.Checked)
           color = "Green";
        else if (purpleRadioButton.Checked)
            color = "Purple";
        else
            color = "null";

        isMarried = yesCheckBox.Checked.ToString();
        submitDate = DateTime.Now.ToString();

        try
        {
            cmd = new SqlCommand("INSERT INTO Users (Name, Email, Birthday, Color, Married, SubmitDate) VALUES ('" + name + "', '" + email + "', '" + birthday + "', '" + color + "', '" + isMarried + "', '" + submitDate + "')", conn);
            cmd.ExecuteNonQuery();
        }
        catch
        {
            MessageBox.Show("Error");
        }
        finally
        {
            conn.Close();
        }

        UpdateGridView();
    }

    private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridView.SelectedRows.Count != 0)
        {
            conn.Open();
            DataGridViewRow row = this.dataGridView.SelectedRows[0];
            var val = row.Cells["Id"].Value;

            try
            {
                cmd = new SqlCommand("DELETE FROM Users WHERE Id = " + val.ToString(), conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record deleted from database.");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

            UpdateGridView();
        }
    }
}