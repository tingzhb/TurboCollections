using System;
using System.Collections;

namespace TurboCollections {
public class TurboList<T> {
	public int Count => items.Length;
	private T[] items = Array.Empty<T>();
	public void Add(T item) {
		// Resize Array
		T[] newArray = new T[Count + 1];
		for (int i = 0; i < Count; i++) {
			newArray[i] = items[i];
		}
		// Assign new element
		newArray[Count] = item;
		items = newArray;
	}
	public T Get(int index) {
		return items[index];
	}
}
}
