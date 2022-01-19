using System;
using System.Collections.Generic;

namespace TurboCollections {
	public class TurboStack<T> {
		public int Count { get; private set; }
		private T[] items = Array.Empty<T>();

		public void Push(T item) {
			EnsureSize(Count + 1);
			items[Count++] = item;
		}
		
		/// <summary>
		/// This method ensures that the array is at least 'size' big.
		/// </summary>
		/// <param name="size">The size that your array should have</param>
		void EnsureSize(int size) {
			// If the array is large enough return
			if (items.Length > size)
				return;
			// Double the array size, or set it to given size if doubling is not enough.
			int newSize = Math.Max(size, items.Length * 2);

			T[] newArray = new T[newSize];
			for (int i = 0; i < Count; i++) {
				newArray[i] = items[i];
			}
			items = newArray;
		}
		public T Peek() {
			return items[Count - 1];
		}
		public T Pop() {
			var ret = items[Count - 1];
			items[Count - 1] = default;
			Count--;
			return ret;
		}
		public void Clear() {
			for (int i = 0; i < Count; i++) {
				items[i] = default;
			}
			Count = 0;		
		}
	}
}
