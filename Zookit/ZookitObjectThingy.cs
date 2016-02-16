using System;

namespace Zookit
{
	public class ZookitObjectThingy
	{
		private bool JustSayingTrue = false;

		public ZookitObjectThingy ()
		{
			JustSayingTrue = true;
		}

		public bool JustTrue()
		{
			return JustSayingTrue;
		}
	}
}