using System;
using System.Threading.Tasks;
using Moq;
using Xunit;
using xUnitAutoFixture.Abstractions;
using xUnitAutoFixture.Models;
using xUnitAutoFixture.UnitTests.Helpers;

namespace xUnitAutoFixture.UnitTests
{
    public class UserManagerTests
    {
        [Theory, GenerateDefaultTestData]
        public async Task AddUser_GivenValidUser_ExecutesWithoutException(User validUser, IUserRepository fakeUserRepository)
        {
            // Arrange
            UserManager sut = new UserManager(fakeUserRepository);

            // Act
            Exception shouldBeNull = await Record.ExceptionAsync(() => sut.AddUser(validUser));

            // Assert
            Assert.Null(shouldBeNull);
        }

        [Fact]
        public void CanRunXUnitTests()
        {
            Assert.True(true);
        }
    }
}
