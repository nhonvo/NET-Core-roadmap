namespace p4LinQTests
{
    public class GetEarliestAndLatestDatesTests
    {

        [Fact]
        public void GetEarliestAndLatestDates_ShouldThrowArgumentNullException_WhenParamIsNull()
        {
            // Arrange
            List<DateTime> param = null;

            // And And Assert
            Assert.Throws<ArgumentNullException>(() => Test.GetEarliestAndLatestDates(param));
        }

        [Fact]
        public void GetEarliestAndLatestDates_ShouldThrowArgumentException_WhenParamIsEmptyList()
        {
            // Arrange
            var param = new List<DateTime>();

            // And And Assert
            Assert.Throws<ArgumentException>(() => Test.GetEarliestAndLatestDates(param));
        }

        [Fact]
        public void GetEarliestAndLatestDates_ShouldReturnCorrectData_WhenParamHas1Item()
        {
            // Arrange
            var item = new DateTime(2023, 03, 13);
            var param = new List<DateTime>() { item };
            var expected = (item, item);

            // Act
            var actual = Test.GetEarliestAndLatestDates(param);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetEarliestAndLatestDates_ShouldReturnCorrectData_WhenParamHasMultipleItems()
        {
            // Arrange
            var today = DateTime.Now;
            var oneDayAgo = today.AddDays(-1);
            var twoDayAgo = today.AddDays(-2);
            var threeDayAgo = today.AddDays(-3);
            var fourDayAgo = today.AddDays(-4);
            var param = new List<DateTime>() { oneDayAgo, today, fourDayAgo, twoDayAgo, threeDayAgo };
            var expected = (fourDayAgo, today);

            // Act
            var actual = Test.GetEarliestAndLatestDates(param);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}