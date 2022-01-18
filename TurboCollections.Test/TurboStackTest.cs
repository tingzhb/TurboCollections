using System.Collections.Generic;
using NUnit.Framework;

namespace TurboCollections.Test {
	public class TurboStackTest {
		[Test]
		public void NewStackIsEmpty() {
			var stack = new TurboStack<int>();
			Assert.Zero(stack.Count);
		}
		[Test]
		public void PushingOneItemIncreasesCount() {
			var stack = new TurboStack<int>();
			stack.Push(2);
			Assert.AreEqual(1, stack.Count);
		}
		[Test]
		public void PeekingReturnsTopItemWithoutRemovingIt() {
			var stack = new TurboStack<int>();
			stack.Push(8);
			stack.Push(7);
			stack.Push(0);
			stack.Push(6);
			Assert.AreEqual(6, stack.Peek());
		}
		[Test]
		public void PopReturnsAndRemovesCorrectItem() {
			var stack = new TurboStack<int>();
			stack.Push(8);
			stack.Push(7);
			stack.Push(1);
			stack.Push(6);
			Assert.AreEqual(6, stack.Pop());
			Assert.AreEqual(1, stack.Peek());
		}
		[Test]
		public void ListCanBeCleared() {
			var list = new TurboStack<int>();
			list.Push(5);
			list.Push(9);
			list.Clear();
			// Assert.AreEqual(0, list.Peek());
		}
	}
}
