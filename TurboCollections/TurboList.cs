using System;
using System.Collections;
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
		return items[index];
	}
	public T Set(int index, T value) {
		return items[index] = value;
	}
	public void Clear() {
		// items = Array.Empty<T>();
		for (int i = 0; i < Count; i++) {
			items[i] = default;
		}
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
	
}
}
