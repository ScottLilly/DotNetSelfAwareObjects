using Shouldly;
using TestSAO.SampleModels;
using Xunit;

namespace TestSAO
{
    public class TestSampleModelCustomer
    {
        [Fact]
        public void Test_InitialValidationAfterConstruction()
        {
            Customer customer = new Customer();

            customer.Validate();

            customer.IsValid.ShouldBeFalse();
            customer.ValidationErrors.Count.ShouldBe(9);
            customer.ValidationErrors.ShouldContain("Address is required");
            customer.ValidationErrors.ShouldContain("Address cannot be less than 5 characters long");
            customer.ValidationErrors.ShouldContain("City cannot be less than 2 characters long");
            customer.ValidationErrors.ShouldContain("State must be two characters");
            customer.ValidationErrors.ShouldContain("ZIP Code must be formatted like '99999' or '99999-9999'");
            customer.ValidationErrors.ShouldContain("Age must be between 1 and 150");
            customer.ValidationErrors.ShouldContain("Password must have a value");
            customer.ValidationErrors.ShouldContain("Confirmation password must have a value");
            customer.ValidationErrors.ShouldContain("Confirmation password must match Password");
        }

        [Fact]
        public void Test_ValidCustomer()
        {
            Customer customer = new Customer();

            customer.Address = "1234 Main Street";
            customer.City = "Houston";
            customer.StateCode = "TX";
            customer.ZIPCode = "77000";
            customer.Age = 21;
            customer.Password = "asd123";
            customer.ConfirmPassword = "asd123";

            customer.Validate();

            customer.IsValid.ShouldBeTrue();
            customer.ValidationErrors.Count.ShouldBe(0);
        }
    }
}