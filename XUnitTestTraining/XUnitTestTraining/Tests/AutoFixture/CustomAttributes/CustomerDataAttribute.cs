using AutoFixture;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XUnitTestTraining.DTO;

namespace XUnitTestTraining.Tests.AutoFixture.CustomAttributes
{
    public class CustomerDataAttribute : AutoDataAttribute
    {
        public CustomerDataAttribute() : base(() =>
        {
            Fixture fixture = new Fixture
            {
                RepeatCount = 5
            };
            fixture.Register(() => fixture.CreateMany<CustomerDTO>().ToList());
            return fixture;
        })
        { }
    }
}
