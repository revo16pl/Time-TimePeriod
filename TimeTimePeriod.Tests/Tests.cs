using TimeTimePeriod.Lib;
using Xunit;

namespace TimeTimePeriod.Tests
{
    public class Tests
    {
        #region Time structure unit tests

        [Fact]
        public void Time_ShouldReturnTrue_Operator_Equals()
        {
            //Arrange
            var expected = true;
            //Act
            Time timeOne = new Time(0,0,0);
            Time timeTwo = new Time(0,0,0);
            var actual = (timeOne == timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Time_ShouldReturnFalse_Operator_DiffenceEquals()
        {
            //Arrange
            var expected = false;
            //Act
            Time timeOne = new Time(0, 0, 0);
            Time timeTwo = new Time(0, 0, 0);
            var actual = (timeOne != timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Time_ShouldReturnTrue_Operator_Less()
        {
            //Arrange
            var expected = true;
            //Act
            Time timeOne = new Time(0, 0, 0);
            Time timeTwo = new Time(1, 1, 1);
            var actual = (timeOne < timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Time_ShouldReturnFalse_Operator_Greater()
        {
            //Arrange
            var expected = false;
            //Act
            Time timeOne = new Time(0, 0, 0);
            Time timeTwo = new Time(1, 1, 1);
            var actual = (timeOne > timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Time_ShouldReturnTrue_Operator_GreaterOrEqual()
        {
            //Arrange
            var expected = true;
            //Act
            Time timeOne = new Time(0, 0, 0);
            Time timeTwo = new Time(1, 1, 1);
            Time timeThree = new Time(1, 1, 1);
            var actual = (timeTwo >= timeOne && timeThree >= timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Time_ShouldReturnTrue_Operator_LessrOrEqual()
        {
            //Arrange
            var expected = true;
            //Act
            Time timeOne = new Time(0, 0, 0);
            Time timeTwo = new Time(1, 1, 1);
            Time timeThree = new Time(1, 1, 1);
            var actual = (timeOne <= timeTwo && timeThree <= timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Time_ShouldReturnTrue_Operator_Minus()
        {
            //Arrange
            var expected = true;
            //Act
            Time timeOne = new Time(2, 2, 2);
            Time timeTwo = new Time(1, 1, 1);
            Time timeThree = new Time(1, 1, 1);
            var actual = (timeThree == (timeOne - timeTwo));
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Time_ShouldReturnTrue_Operator_Plus()
        {
            //Arrange
            var expected = true;
            //Act
            Time timeOne = new Time(1, 1, 1);
            Time timeTwo = new Time(1, 1, 1);
            Time timeThree = new Time(2, 2, 2);
            var actual = (timeThree == (timeOne + timeTwo));
            //Assert
            Assert.Equal(expected, actual);
        }
    

        [Fact]
        public void Time_ShouldReturnTrue_ToString()
        {
            //Arrange
            var expected = true;
            //Act
            Time time = new Time(0, 0, 0);
            var actual = ("00:00:00" == time.ToString());
            //Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region TimePeriod structure unit tests

        [Fact]
        public void TimePeriod_ShouldReturnTrue_Operator_Equals()
        {
            //Arrange
            var expected = true;
            //Act
            TimePeriod timeOne = new TimePeriod(0, 0, 0);
            TimePeriod timeTwo = new TimePeriod(0, 0, 0);
            var actual = (timeOne == timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimePeriod_ShouldReturnFalse_Operator_DiffenceEquals()
        {
            //Arrange
            var expected = false;
            //Act
            TimePeriod timeOne = new TimePeriod(0, 0, 0);
            TimePeriod timeTwo = new TimePeriod(0, 0, 0);
            var actual = (timeOne != timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimePeriod_ShouldReturnTrue_Operator_Less()
        {
            //Arrange
            var expected = true;
            //Act
            TimePeriod timeOne = new TimePeriod(0, 0, 0);
            TimePeriod timeTwo = new TimePeriod(1, 1, 1);
            var actual = (timeOne < timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimePeriod_ShouldReturnFalse_Operator_Greater()
        {
            //Arrange
            var expected = false;
            //Act
            TimePeriod timeOne = new TimePeriod(0, 0, 0);
            TimePeriod timeTwo = new TimePeriod(1, 1, 1);
            var actual = (timeOne > timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimePeriod_ShouldReturnTrue_Operator_GreaterOrEqual()
        {
            //Arrange
            var expected = true;
            //Act
            TimePeriod timeOne = new TimePeriod(0, 0, 0);
            TimePeriod timeTwo = new TimePeriod(1, 1, 1);
            TimePeriod timeThree = new TimePeriod(1, 1, 1);
            var actual = (timeTwo >= timeOne && timeThree >= timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimePeriod_ShouldReturnTrue_Operator_LessrOrEqual()
        {
            //Arrange
            var expected = true;
            //Act
            TimePeriod timeOne = new TimePeriod(0, 0, 0);
            TimePeriod timeTwo = new TimePeriod(1, 1, 1);
            TimePeriod timeThree = new TimePeriod(1, 1, 1);
            var actual = (timeOne <= timeTwo && timeThree <= timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimePeriod_ShouldReturnTrue_Operator_Plus()
        {
            //Arrange
            var expected = true;
            //Act
            TimePeriod timeOne = new TimePeriod(1, 1, 1);
            TimePeriod timeTwo = new TimePeriod(1, 1, 1);
            TimePeriod timeThree = new TimePeriod(2, 2, 2);
            var actual = (timeThree == (timeOne + timeTwo));
            //Assert
            Assert.Equal(expected, actual);
        }
 

        [Fact]
        public void TimePeriod_ShouldReturnTrue_ToString()
        {
            //Arrange
            var expected = true;
            //Act
            TimePeriod time = new TimePeriod(123, 0, 0);
            var actual = ("123:00:00" == time.ToString());
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimePeriod_ShouldReturnTrue_Static_Plus()
        {
            //Arrange
            var expected = new TimePeriod(2, 2, 2);
            //Act
            TimePeriod timeOne = new TimePeriod(1, 1, 1);
            TimePeriod timeTwo = new TimePeriod(1, 1, 1);


            var actual = TimePeriod.Plus(timeOne, timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TimePeriod_ShouldReturnTrue_Plus()
        {
            //Arrange
            var expected = new TimePeriod(2, 2, 2);
            //Act
            TimePeriod timeOne = new TimePeriod(1, 1, 1);
            TimePeriod timeTwo = new TimePeriod(1, 1, 1);


            var actual = timeOne.Plus(timeTwo);
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
