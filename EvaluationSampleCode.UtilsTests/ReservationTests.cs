namespace EvaluationSampleCode.UtilsTests
{
    [TestClass]
    public sealed class ReservationTests
    {
        // Test pour CanBeCancelledBy

        [TestMethod]
        public void CanBeCancelledBy_UserIsCreator_ShouldReturnsTrue()
        {
            User John = new User { IsAdmin = false};
            Reservation reservation = new Reservation(John);

            bool result = reservation.CanBeCancelledBy(John);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotCreator_ShouldReturnsFalse()
        {
            User John = new User { IsAdmin = false};
            User Bob = new User { IsAdmin = false};
            Reservation reservation = new Reservation(John);

            bool result = reservation.CanBeCancelledBy(Bob);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ShouldReturnsTrue()
        {
            User John = new User { IsAdmin = false};
            User admin = new User { IsAdmin = true};
            Reservation reservation = new Reservation(John);

            bool result = reservation.CanBeCancelledBy(admin);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AdminIsCreator_ShouldReturnsTrue()
        {
            User adminJohn = new User { IsAdmin = true};
            Reservation reservation = new Reservation(adminJohn);

            bool result = reservation.CanBeCancelledBy(adminJohn);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_DifferentAdminUser_ShouldReturnsTrue()
        {
            User John = new User { IsAdmin = false};
            User admin1 = new User { IsAdmin = true};
            User admin2 = new User { IsAdmin = true};
            Reservation reservation = new Reservation(John);

            bool result = reservation.CanBeCancelledBy(admin1);
            bool result2 = reservation.CanBeCancelledBy(admin2);

            Assert.IsTrue(result);
            Assert.IsTrue(result2);
        }

        //Test Constructor
        [TestMethod]
        public void Reservation_SetsCorrectMadeBy()
        {
            
            User alice = new User { IsAdmin = false };
            
            Reservation reservation = new Reservation(alice);
            
            Assert.AreEqual(alice, reservation.MadeBy);
        }







    }
}