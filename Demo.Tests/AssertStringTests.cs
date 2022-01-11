using Xunit;

namespace Demo.Tests
{
    public class AssertStringTests
    {
        [Fact]
        public void StringTools_UnionNames_ReturnsNameCompleted()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nameCompleted = sut.UnionNames(name: "Natalia", surname: "Souza");

            //Assert
            Assert.Equal(expected: "Natalia Souza", actual: nameCompleted);
        }

        [Fact]
        public void StringTools_UnionNames_MustIgnoreCase()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nameCompleted = sut.UnionNames(name: "Natalia", surname: "Souza");

            //Assert
            Assert.Equal(expected: "Natalia Souza", actual: nameCompleted, ignoreCase: true);
        }

        [Fact]
        public void StringTools_UnionNames_MustContainNamePart()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nameCompleted = sut.UnionNames(name: "Natalia", surname: "Souza");

            //Assert
            Assert.Contains(expectedSubstring: "tali", actualString: nameCompleted);
        }

        [Fact]
        public void StringTools_UnionNames_StartsWith()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nameCompleted = sut.UnionNames(name: "Natalia", surname: "Souza");

            //Assert
            Assert.StartsWith(expectedStartString: "Nat", actualString: nameCompleted);
        }

        [Fact]
        public void StringTools_UnionNames_EndsWith()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nameCompleted = sut.UnionNames(name: "Natalia", surname: "Souza");

            //Assert
            Assert.EndsWith(expectedEndString: "uza", actualString: nameCompleted);
        }

        [Fact]
        public void StringTools_UnionNames_ValidateRegularExpression()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nameCompleted = sut.UnionNames(name: "Natalia", surname: "Souza");

            //Assert
            Assert.Matches(expectedRegexPattern: "[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]", actualString: nameCompleted);
        }
    }
}
