using Engine.Model;

using SAO.Exception;

namespace Engine.Controllers
{
    public static class CustomerController
    {
        public static void SaveToDatabase(Customer customer)
        {
            customer.Validate();

            if(customer.IsValid)
            {
                // Code to save to the database
            }
            else
            {
                throw new DataValidationException();
            }
        }
    }
}
