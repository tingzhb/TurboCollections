using System;
using System.Collections.Generic;

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
		if (index > Count) {
			throw new Exception("Cannot GET a non-existent item!");
		}
		return items[index];
	}
	public void Set(int index, T value) {
		if (index > Count) {
			throw new Exception("Cannot SET a non-existent item!");
		}
		items[index] = value;
	}
	public void Clear() {
		items = Array.Empty<T>();
	}
	public void RemoveAt(int index) {
		for (int i = index; i < Count; i++) {
			items[index] = items[index + 1];
		}
		T[] newArray = new T[Count - 1];
		for (int i = 0; i < Count - 1; i++) {
			newArray[i] = items[i];
		}
		items = newArray;
	}
	// public bool Contains(T item) {
	// 	for (int i = 0; i < Count; i++) {
	// 		if (items[i] == item) {
	// 			return true;
	// 		}
	// 	}
	// 	return false;
	// }
	public void AddRange(IEnumerable<T> items) {
		
	}
}
}
