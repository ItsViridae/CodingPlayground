using Caesar_Cipher;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class CryptographTests
        {
            [TestCase("should%do%nothing", 0, "should do nothing")]
            [TestCase("tijgu%cz%pof", 1, "shift by one")]
            [TestCase("zvqqyr%bs%gur%cnpx", 13, "middle of the pack")]
            [TestCase("sghr%nmd%hr%ax%svdmsx%ehud", 25, "this one is by twenty five")]
            [TestCase("this%one%should%not%change", 26, "this one should not change")]
            [TestCase("uif%mjtu%tipvme%mppq%bhbjo", 27, "the list should loop again")]
            public void DecryptMessage(string encryptedMessage, int key, string decryptedMessage)
            {
                var cryptograph = new Cryptograph();
                var result = cryptograph.DecryptMessage(encryptedMessage, key);
                Assert.AreEqual(decryptedMessage, result);
            }

            [TestCase("should%do%nothing", 0, "should do nothing")]
            [TestCase("tijgu%cz%pof", 1, "shift by one")]
            [TestCase("zvqqyr%bs%gur%cnpx", 13, "middle of the pack")]
            [TestCase("sghr%nmd%hr%ax%svdmsx%ehud", 25, "this one is by twenty five")]
            [TestCase("this%one%should%not%change", 26, "this one should not change")]
            [TestCase("uif%mjtu%tipvme%mppq%bhbjo", 27, "the list should loop again")]
            public void EncryptMessage(string encryptedMessage, int key, string decryptedMessage)
            {
                var cryptograph = new Cryptograph();
                var result = cryptograph.Encrypt(encryptedMessage, key);
                Assert.AreEqual(encryptedMessage, result);
            }
        }
    }
}