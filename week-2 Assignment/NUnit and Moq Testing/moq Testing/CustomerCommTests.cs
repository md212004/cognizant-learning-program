using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCommLib.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        [Test]
        public void SendMailToCustomer_ShouldReturnTrue_WhenMailIsSentSuccessfully()
        {
            // Arrange
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender
                .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            var customerComm = new CustomerComm(mockMailSender.Object);

            // Act
            var result = customerComm.SendMailToCustomer();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
