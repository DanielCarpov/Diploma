using System;
using Xunit;
using System.IO;
using Diploma.Models;
using System.Collections.Generic;
using Diploma.DataProcessing;
using NSubstitute;

namespace Diploma.Tests.UnitTests
{
    public class MainMenuTests
    {
        private readonly IConsoleWrapper consoleWrapper;
        private readonly IConstants constants;
        private readonly IStudentDataProcessor loader;

        [Fact]
        public void MainMenuBuilder()
        {
            this.consoleWrapper = Substitute.For<IConsoleWrapper>();
            var constants = Substitute.For<IConstants>();
            var suboader = Substitute.For<IStudentDataProcessor>();
        }

    }
}
