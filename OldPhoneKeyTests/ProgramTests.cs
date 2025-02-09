using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhoneKeypad.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void OldPhonePad_WhenGivenValidKeys_ReturnsCorrectOutput()
        {
            string input = "33#";
            string expectedOutput = "E";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void OldPhonePad_WhenStarKeyIsPressed_ReturnsCorrectOutput()
        {
            string input = "227*#";
            string expectedOutput = "B";
            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void OldPhonePad_WhenSpaceKeyIsUsed_ReturnsCorrectOutput()
        {
            string input = "4433555 555666#";
            string expectedOutput = "HELLO";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void OldPhonePad_WhenSpaceAndStarKeyAreUsed_ReturnsCorrectOutput()
        {
            string input = "8 88777444666*664#";
            string expectedOutput = "TURING";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void OldPhonePad_WhenSingleInputExceedsCount_ReturnsCorrectOutput()
        {
            string input = "77777#";
            string expectedOutput = "P";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
