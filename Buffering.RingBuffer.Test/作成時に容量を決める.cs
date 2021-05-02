using System;
using Xunit;

namespace Buffering.RingBuffer.Test
{
	public class 作成時に容量を決める
	{
		[Fact]
		public void 作成時のLengthToReadは0()
		{
			var buffer = new RingBuffer<int>(5);
			Assert.Equal(0, buffer.LengthToRead);
		}
	}
}
