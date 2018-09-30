﻿using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace xUnitAutoFixture.UnitTests.Helpers
{
    public class GenerateDefaultTestData : AutoDataAttribute
    {
        public GenerateDefaultTestData() : base(GetDefaultFixture)
        {
        }

        public static IFixture GetDefaultFixture()
        {
            var autoMoqCustomization = new AutoMoqCustomization();

            return new Fixture()
                .Customize(autoMoqCustomization);
        }
    }
}
