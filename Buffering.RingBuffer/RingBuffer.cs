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
			this.capacity = capacity;
		}

		public int LengthToRead => 0;
	}
}
