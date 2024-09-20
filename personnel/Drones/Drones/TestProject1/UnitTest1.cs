using Drones;

namespace TestProject1
{
    [TestClass]
    public class DroneTest
    {
        [TestMethod]
        public void Start_Charge_Eq_1000()
        {
            //arrange
            Drone drone;

            //act
            drone = new Drone(0, 0, "test");

            //assert
            Assert.AreEqual(Drone.FULLCHARGE, drone.Charge, "La charge doit etre egal a 1000");
        }
        [TestMethod]
        public void charge_check_after_update()
        {
            //arrange
            Drone drone = new Drone(0, 0, "bob");
            int LastCharge = drone.Charge;

            //actr
            drone.Update(1);

            //Assert
            Assert.IsTrue(LastCharge > drone.Charge, "La charge doit diminuer");
        }

        [TestMethod]
        public void Drone_LowBatteryMode_IsTrue_WhenCharge_IsLowerThan_20PercentOfFullCharge()
        {
            // Arrange
            Drone drone = new Drone(0, 0, "test");

            // Action
            drone.Charge = 201;
            drone.Update(1);

            // Assert
            Assert.IsTrue(drone.LowBattery, "le mode lowbattery ne s'active pas");
        }
    }
}