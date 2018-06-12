using System.Windows.Forms;

using Engine.Controllers;
using Engine.Model;
using SAO.Exception;

namespace Workbench
{
    public partial class Workbench : Form
    {
        private Customer _customer { get; set; }

        public Workbench()
        {
            InitializeComponent();

            _customer = new Customer();

            txtName.BindTextPropertyTo(_customer, "Name");
            txtAddress.BindTextPropertyTo(_customer, "Address");
            txtCity.BindTextPropertyTo(_customer, "City");
            txtStateCode.BindTextPropertyTo(_customer, "StateCode");
            txtZIPCode.BindTextPropertyTo(_customer, "ZIPCode");
            txtAge.BindTextPropertyTo(_customer, "Age");
            txtPassword.BindTextPropertyTo(_customer, "Password");
            txtConfirmPassword.BindTextPropertyTo(_customer, "ConfirmPassword");
            txtValue1.BindTextPropertyTo(_customer, "Value1");
            txtValue2.BindTextPropertyTo(_customer, "Value2");
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                CustomerController.SaveToDatabase(_customer);
            }
            catch(SAODataValidationException)
            {
                MessageBox.Show(_customer.ValidationErrors.ListToString());
            }
        }
    }
}
