using OOPractice;
using Xunit;

namespace OOPracticeTest
{
    public class CarTest1
    {
        [Fact]
        public void Should_Car_Show_Name_And_Speed()
        {
            //given
            string name = "Cool Car";
            string speed = "30 km/h";
            Car car = new Car(name, speed);
            string expected = "Cool Car: speed up 30 km/h";
            //when
            string actual = car.SpeedUp();
            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Truck_Show_Name_And_Speed()
        {
            //given
            string name = "Big Truck";
            string speed = "10 km/h";
            Truck truck = new Truck(name, speed);
            string expected = "Big Truck: speed up 10 km/h";
            //when
            string actual = truck.SpeedUp();
            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Diver_Drive_Truck_Show_Name_And_Speed()
        {
            //given
            string name = "Big Truck";
            string speed = "10 km/h";
            Truck truck = new Truck(name, speed);
            Driver diver = new Driver(truck);
            string expected = "Big Truck: speed up 10 km/h";
            //when
            string actual = diver.Drive();
            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Diver_Drive_Car_Show_Name_And_Speed()
        {
            //given
            string name = "Cool Car";
            string speed = "30 km/h";
            Car car = new Car(name, speed);
            Driver diver = new Driver(car);
            string expected = "Cool Car: speed up 30 km/h";
            //when
            string actual = diver.Drive();
            //then
            Assert.Equal(expected, actual);
        }
    }
}
