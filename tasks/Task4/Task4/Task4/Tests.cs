using NUnit.Framework;


namespace Task4
{
    [TestFixture]
    class Tests
    {

        [Test]
        public void TestAndroid()
        {
            Android A1 = new Android(123);
            Assert.Greater(A1.GETSerialN, 0);
            Assert.IsFalse(A1.GETSerialN == 456);
        }
        [Test]
        public void TestAndroid2() {
            Android A1 = new Android(123);
            Assert.Greater(A1.GETSerialN, 0);
            Assert.IsTrue(A1.GETSerialN == 123);
        }
        [Test]
        public void TestAndroidWelcome()
        {
            Android A1 = new Android(123, "blabla");
            Assert.IsNotEmpty(A1.LogoP);
            Assert.False(A1.LogoP == "");
        }
        [Test]
        public void TestIPhone()
        {
            IPhone IP1 = new IPhone(4567, "AppleUser", "Apple forever");
            Assert.IsNotNull(IP1.IPhoneN);
        }
        [Test]
        public void TestWelcomeonDispla()
        {
            IPhone IP1 = new IPhone(567, "AppleUser", "Apple forever");
            IPhone IP2 = IP1;
            Assert.IsInstanceOf(typeof(IPhone),IP1);
            Assert.AreSame(IP1,IP2);
        }
        [Test]
        public void TestNickName()
        {
            IPhone IP1 = new IPhone(567, "AppleUser", "Apple forever");
            Assert.IsNotEmpty(IP1.NickN);
        }
       
        [Test]
        public void EmptyToString()
        {
            Android A1 = new Android(123, "blabla");
            Assert.IsNotEmpty(A1.ToString());
        }
        [Test]
        public void NotSameObject()
        {
            Android A1 = new Android(123, "blabla");
            Android A2 = new Android(123, "blabla");
            Assert.AreNotSame(A1, A2);
            Assert.AreNotEqual(A1 , A2);
        }
    }
}