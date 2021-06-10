using Moq;
using Refactoring.Logic.V03;
using System;
using System.Collections.Generic;
using Xunit;

namespace Refactoring.LogicTest.V03
{
    public class AuditManagerTests
    {
        [Fact]
        public void A_new_file_is_created_when_the_current_file_overflows()
        {

            var sut = new AuditManager(3);
            var files = new List<FileContent>
            {
                new FileContent("audit_1.txt",new List<string>()),
                new FileContent("audit_2.txt",new List<string>
                {
                                "Customer01; 2021-07-06T16:30:00",
                                "Customer02; 2019-07-06T16:40:00",
                                "Customer01; 2019-07-06T17:00:00"
                })
            };
            var result = sut.AddLog("Customer03", DateTime.Parse("2021-07-06T18:00:00"), files);
            Assert.Equal("audit3.txt", result.FileName);
            Assert.Equal("Customer03; 2021-07-06T18:00:00", result.NewContent);
        }
    }
}
