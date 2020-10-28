using AutoFixture.Xunit2;
using System.Collections.Generic;
using Xunit;
using XUnitTestTraining.DTO;
using XUnitTestTraining.Tests.AutoFixture.CustomAttributes;

namespace XUnitTestTraining.Tests.AutoFixture
{
    /// <summary>
    /// https://github.com/AutoFixture/AutoFixture/wiki/Cheat-Sheet#autodata-theories
    /// https://github.com/AutoFixture/AutoFixture/wiki/Cheat-Sheet#inline-autodata-theories
    /// </summary>
    public class AutoDataExampleTests
    {

        [Theory, CreateManyData]
        public void CreateTwoListsWithRandomElements_FixtureTenElements_CountIsOk(List<string> fixtureStringList, List<int> fixtureIntList)
        {
            // RepeatCount = 10 in CreateManyDataAttribute
            var defaultElementsGenerated = 10;
            Assert.Equal(defaultElementsGenerated, fixtureStringList.Count);
            Assert.Equal(defaultElementsGenerated, fixtureIntList.Count);
        }

        [Theory, CustomerData]
        public void CreateOneListsWithRandomCustomers_FixtureFiveElements_NotEmptyFullName(List<CustomerDTO> fixtureCustomerList)
        {
            fixtureCustomerList.ForEach(customer => Assert.NotEmpty(customer.FullName));
        }

        [Theory, CustomerData]
        public void CreateOneListsWithRandomCustomers_FixtureFiveElements_CountIsOk(List<CustomerDTO> fixtureCustomerList)
        {
            Assert.Equal(5, fixtureCustomerList.Count);
        }

        [Theory, AutoData]
        public void CreateOneListWithRandomElements_AutoDataThreeElements_CountIsOk(List<int> fixtureIntList)
        {
            // RepeatCount = 3 by default
            Assert.Equal(3, fixtureIntList.Count);
        }

        [Theory]
        [InlineAutoData("Hi", " team!")]
        public void ValidateText_InlineAutoDataTwoParameters_MessageIsOk(string message1, string message2)
        {
            Assert.Equal("Hi team!", message1 + message2);
        }

        [Theory]
        [InlineAutoData("Hi!")]
        public void ValidateText_InlineAutoDataRunOutArguments_ArgumentsAreOk(string message1, string message2)
        {            
            Assert.Equal("Hi!", message1);
            Assert.StartsWith("message2", message2); // message2 random value should start with the parameter name
        }

    }
}
