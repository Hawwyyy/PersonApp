using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
            txtName.KeyPress += new KeyPressEventHandler(AlphanumericKeyPress);
            txtAddress.KeyPress += new KeyPressEventHandler(AlphanumericKeyPress);
            txtAge.KeyPress += new KeyPressEventHandler(NumericKeyPress);
            txtStudentID.KeyPress += new KeyPressEventHandler(NumericKeyPress);
        }

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Person person = new Person(txtName.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text);
                lstDetails.Items.Add(person.GetInformation());
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please fill in the name field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in the address field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateStudentID()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || !int.TryParse(txtStudentID.Text, out _))
            {
                MessageBox.Show("Please enter a valid student ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AlphanumericKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only alphanumeric characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumericKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numeric characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void btnCreateStudent_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs() && ValidateStudentID())
            {
                Student student = new Student(txtName.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text, txtStudentID.Text);
                lstDetails.Items.Add(student.GetStudentInformation());
            }
        }
    }
}
