using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffering
{
	public class RingBuffer<T>
	{
		private int capacity;

		public RingBuffer(int capacity)
		{
			if (capacity < 1) throw new ArgumentOutOfRangeException(nameof(capacity));
			this.capacity = capacity;
		}

		public int LengthToRead => 0;
		public int Margin => capacity;
	}
}
