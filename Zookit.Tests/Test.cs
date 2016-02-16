using NUnit.Framework;
using System;

namespace Zookit.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
			Assert.AreEqual (true, true);
		}
	}

	[TestFixture ()]
	public class Zookit
	{
		[Test()]
		public void TestCase ()
		{
			Assert.AreNotEqual (true, false);
		}
	}
}

