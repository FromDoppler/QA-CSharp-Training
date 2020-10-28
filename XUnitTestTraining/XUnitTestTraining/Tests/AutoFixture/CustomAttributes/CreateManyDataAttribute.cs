using AutoFixture;
using AutoFixture.Xunit2;

namespace XUnitTestTraining.Tests.AutoFixture.CustomAttributes
{
    public class CreateManyDataAttribute : AutoDataAttribute
    {
        public CreateManyDataAttribute() : base(() =>
        {
            Fixture fixture = new Fixture
            {
                RepeatCount = 10
            };
            return fixture;
        }) { }
    }
}
