using SalaryCapData.Data.Models;

using Xunit;

namespace SalaryCapGames.Tests
{
    public class FranchiseTests
    {
        [Fact]
        public void CanChangeFranchiseName()
        {
            // Arrange
            var f = new Franchise { Name = "TestFranchise" };

            // Act
            f.Name = "New Name";

            // Assert
            Assert.Equal( "New Name", f.Name );
        }

        [Fact]
        public void CanChangeNickname()
        {
            // Arrange
            var f = new Franchise { AbbreviatedName = "ShortName" };

            // Act
            f.AbbreviatedName = "New Shorty";

            // Assert
            Assert.Equal( "New Shorty", f.AbbreviatedName );
        }

        [Fact]
        public void CanChangeLeagues()
        {
            // Arrange
            var f = new Franchise { LeagueId = 1 };

            // Act
            f.LeagueId = 2;

            // Assert
            Assert.Equal( 2, f.LeagueId );
        }

        [Fact]
        public void CanUpdateFranchiseValue()
        {
            // Arrange
            var f = new Franchise { Value = 75.25M };

            // Act
            f.Value = 50.0M;

            // Assert
            Assert.Equal( 50.0M, f.Value );
        }

        [Fact]
        public void CanUpdateFranchisePoints()
        {
            // Arrange
            var f = new Franchise { Points = 12253 };

            // Act
            f.Points = 10000;

            // Assert
            Assert.Equal( 10000, f.Points );
        }

        [Fact]
        public void CanUpdateNumberOfTrades()
        {
            // Arrange
            var f = new Franchise { NumberOfTrades = 8 };

            // Act
            f.NumberOfTrades = 0;

            // Assert
            Assert.Equal( 0, f.NumberOfTrades );
        }
    }
}
