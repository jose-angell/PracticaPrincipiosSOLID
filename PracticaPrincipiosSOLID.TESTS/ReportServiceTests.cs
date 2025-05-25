using Moq;
using PracticaPrincipiosSOLID.Reports;

namespace PracticaPrincipiosSOLID.TESTS
{
    public class ReportServiceTests
    {
        [Fact]
        public void RunReport_ShouldGenerateSaveAndSend_WhenDataIsValid()
        {
            // Arrange
            var mockGenerator = new Mock<IReportGenerator>();
            var mockSaver = new Mock<IReportSaver>();
            var mockSender = new Mock<IReportSender>();

            var data = new List<string> { "Item1", "Item2" };
            var expectedContent = "Generated Report";

            mockGenerator.Setup(g => g.Generate(data)).Returns(expectedContent);

            var reportService = new ReportService(
                mockGenerator.Object,
                mockSaver.Object,
                mockSender.Object
            );

            // Act
            reportService.RunReport(data);

            // Assert
            mockGenerator.Verify(g => g.Generate(data), Times.Once);
            mockSaver.Verify(s => s.Save(expectedContent), Times.Once);
            mockSender.Verify(s => s.Send(expectedContent), Times.Once);
        }
        [Fact]
        public void RunReport_WithEmptyData_DoesNotCallDependencies()
        {
            //Arrange
            var mockGenerator = new Mock<IReportGenerator>();
            var mockSaver = new Mock<IReportSaver>();
            var mockSender = new Mock<IReportSender>();

            var reportService = new ReportService(
                mockGenerator.Object,
                mockSaver.Object,
                mockSender.Object
            );
            //Act
            reportService.RunReport(new List<string>()); //lista vacia;

            //Assert 
            mockGenerator.Verify(g => g.Generate(It.IsAny<List<string>>()), Times.Never);
            mockSaver.Verify(g => g.Save(It.IsAny<string>()), Times.Never);
            mockSender.Verify(g => g.Send(It.IsAny<string>()), Times.Never);
        }
    }
}