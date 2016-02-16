using NUnit.Framework;
using System;
using Zookit;

namespace Zookit.Tests
{
	[TestFixture ()]
	public class Zookit
	{
		[Test()]
		public void TestCase ()
		{
			var zookit = new ZookitObjectThingy ();
			var results = zookit.JustTrue ();
			Assert.AreEqual (results, true);
		}
	}
}
