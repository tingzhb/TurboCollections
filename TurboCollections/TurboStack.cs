using System;
using System.Collections.Generic;

namespace TurboCollections {
	public class TurboStack<T> {
		public int Count => items.Length;
		private T[] items = Array.Empty<T>();

		public void Push(T item) {
			T[] newArray = new T[Count + 1];
			for (int i = 0; i < Count; i++) {
				newArray[i] = items[i];
			}
			newArray[Count] = item;
			items = newArray;
		}
		public T Peek() {
			return items[Count - 1];
		}
		public T Pop() {
			var ret = items[Count - 1];
			T[] newArray = new T[Count - 1];
			for (int i = 0; i < Count - 1; i++) {
				newArray[i] = items[i];
			}
			items = newArray;
			return ret;
		}
		public void Clear() {
			items = Array.Empty<T>();
		}
	}
}
