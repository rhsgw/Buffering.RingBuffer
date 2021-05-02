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
		[Theory]
		[InlineData(1)]
		[InlineData(255)]
		[InlineData(int.MaxValue)]
		public void 作成時のMarginは容量と同じ(int value)
		{
			var buffer = new RingBuffer<int>(value);
			Assert.Equal(value, buffer.Margin);
		}
		[Theory]
		[InlineData(0)]
		[InlineData(-1)]
		[InlineData(int.MinValue)]
		public void 作成時0以下の容量が指定されたらArgumentOutOfRangeException(int value)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new RingBuffer<int>(value));
		}
	}
}
