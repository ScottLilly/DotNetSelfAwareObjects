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
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                CustomerController.SaveToDatabase(_customer);
            }
            catch(DataValidationException)
            {
                MessageBox.Show(_customer.ErrorMessages.ListToString());
            }
        }
    }
}
