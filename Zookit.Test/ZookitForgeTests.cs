using NUnit.Framework;
using System;
using Zookit;

namespace Zookit.Test
{
	[TestFixture ()]
	public class when_working_with_zookeeper
	{
		[Test()]
		public void should_read_value ()
		{
			var zookitForge = new ZookitForge ();
			Assert.AreEqual (zookitForge.ReadValue("the_key"), true);
		}

		[Test()]
		public void should_write_value()
		{
			var zookitForge = new ZookitForge ();
			Assert.AreEqual (zookitForge.WriteValue("the_key", "the_value"), true);
		}
	}
}

