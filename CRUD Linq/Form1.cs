using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Linq
{

    public partial class Form1 : Form
    {

        StudentDBDataContext db;

        public Form1()
        {
            InitializeComponent();
        }


        private void Display()
        {
            db = new StudentDBDataContext();
            dataGridView1.DataSource = db.Students;
        }

        private void ClearTextBoxes()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    TextBox txt = ctr as TextBox;
                    txt.Clear();
                }
            }
            NAMEtextBox.Focus();
        }

        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            if (NAMEtextBox.Text == "" || GENDERtextBox.Text == "" || AGEtextBox.Text == "" || STANDARDtextBox.Text == "")
            {
                MessageBox.Show("All Fields are Required!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db = new StudentDBDataContext();
                Student std = new Student();
                std.Name = NAMEtextBox.Text;
                std.Gender = GENDERtextBox.Text;
                std.Age = int.Parse(AGEtextBox.Text);
                std.Standard = int.Parse(STANDARDtextBox.Text);

                db.Students.InsertOnSubmit(std);
                db.SubmitChanges();

                MessageBox.Show("Data has been inserted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes();
                Display();
            }
        }

        private void UPDATEbutton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                db = new StudentDBDataContext();
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                Student std = db.Students.FirstOrDefault(s => s.Id == id);

                std.Name = NAMEtextBox.Text;
                std.Gender = GENDERtextBox.Text;
                std.Age = int.Parse(AGEtextBox.Text);
                std.Standard = int.Parse(STANDARDtextBox.Text);

                db.SubmitChanges();

                MessageBox.Show("Data has been Successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes();
                Display();
            }
            else
                MessageBox.Show("Please Select a Row from the Table!!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            NAMEtextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            GENDERtextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AGEtextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            STANDARDtextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DELETEbutton_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult Confirm = MessageBox.Show("Are You Sure to delete Data??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    db = new StudentDBDataContext();
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    Student std = db.Students.FirstOrDefault(s => s.Id == id);
                    db.Students.DeleteOnSubmit(std);
                    db.SubmitChanges();

                    MessageBox.Show("Data has been Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearTextBoxes();
                    Display();
                }
            }
            else
                MessageBox.Show("Please Select a Row from the Table!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
