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

        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }

        [TestMethod]
        public void Test_that_a_Box_is_created()
        {
            // Arrange
            Dispatch dispatch = new Dispatch();
            Box box;

            //Act
            box = new Box(dispatch, 1, Helper.alea.Next(5, 10), Helper.SmartiesColors[Helper.alea.Next(0, 4)]);

            //Assert
            Assert.AreEqual(box, dispatch.Boxes.First());
        }

        [TestMethod]
        public void Test_that_a_Box_is_Removed()
        {
            // Arrange
            Dispatch dispatch = new Dispatch();
            Box box = new Box(dispatch, 1, Helper.alea.Next(5, 10), Helper.SmartiesColors[Helper.alea.Next(0, 4)]); ;

            //Act
            dispatch.RemoveBox(box);

            //Assert
            Assert.AreEqual(0, dispatch.Boxes.Count);
        }
    }
}