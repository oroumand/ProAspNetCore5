using Moq;
using Refactoring.Logic.V02;
using System;
using System.Collections.Generic;
using Xunit;

namespace Refactoring.LogicTest.V02
{
    public class AuditManagerTests
    {
        [Fact]
        public void A_new_file_is_created_when_the_current_file_overflows()
        {
            var fileSystemMock = new Mock<IFileManager>();
            fileSystemMock
            .Setup(x => x.GetFiles("audits"))
            .Returns(new List<string>
            {
                @"audits\audit1.txt",
                @"audits\audit2.txt"
            });

            fileSystemMock
            .Setup(x => x.ReadAllLines(@"audits\audit_2.txt"))
            .Returns(new List<string>
            {
                "Customer01; 2021-07-06T16:30:00",
                "Customer02; 2019-07-06T16:40:00",
                "Customer01; 2019-07-06T17:00:00"
            });

            var sut = new AuditManager(3, "audits", fileSystemMock.Object);
            sut.AddLog("Customer03", DateTime.Parse("2021-07-06T18:00:00"));
            fileSystemMock.Verify(x => x.WriteAllText(@"audits\audit3.txt", "Customer03; 2021-07-06T18:00:00"));
        }
    }
}
