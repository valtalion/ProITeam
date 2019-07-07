using AutoCheckSrv;
using NUnit.Framework;

namespace Tests
{
	public class NalogTest
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestMyInn()
		{
			FLChecker c = new FLChecker();
			var res = c.CheckTaxpayer("027809629704");

			//false -не является самозанятым
			Assert.AreEqual(false, res);
		}
	}
}