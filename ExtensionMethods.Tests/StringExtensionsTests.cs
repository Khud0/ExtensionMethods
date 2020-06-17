using NUnit.Framework;
using Khud0.Extensions;
using System;

namespace ExtensionMethods.Tests
{
    public class StringExtensionTests
    {
        private string longMessage = "12345678901234567890123456789012345678901234567890";
        
        [Test]
        public void Shorten_PassInvalidInput_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(new TestDelegate(Shorten_PassInvalidInput));
        }
        private void Shorten_PassInvalidInput()
        {
            var shortMessage = longMessage.Shorten(-1);
            Console.WriteLine(shortMessage);
        }

        [Test]
        public void Shorten_LongMessageTo10Chars_Returns10Chars()
        {   
            var shortMessage = longMessage.Shorten(10);
            Assert.AreEqual(10, shortMessage.Length);
        }

        [Test]
        public void Shorten_ShortMessage_ReturnsShortMessage()
        {   
            string message = "12345";
            var shortMessage = message.Shorten(10);
            Assert.AreEqual(message, shortMessage);
        }
    }
}