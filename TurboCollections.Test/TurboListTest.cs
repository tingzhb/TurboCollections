using System;
using System.Dynamic;
using NUnit.Framework;

namespace TurboCollections.Test {
	public class TurboListTest {
		[Test]
		public void NewListIsEmpty() {
			var list = new TurboList<int>();
			Assert.Zero(list.Count);
		}
		[TestCase(5), TestCase(7)]
		public void AddingMultipleElementIncreaseCountToOne(int numberOfElements) {
			var list = new TurboList<int>();
			for (int i = 0; i < numberOfElements; i++)
				list.Add(5);
			Assert.AreEqual(numberOfElements, list.Count);
		}
		[Test]
		public void AnAddedElementCanBeGotten() {
			var list = new TurboList<int>();
			list.Add(1337);
			Assert.AreEqual(1337, list.Get(0));
		}
		[Test]
		public void MultipleAddedElementsCanBeGotten() {
			var (numbers, list) = CreateTestData();
			for (int i = 0; i < numbers.Length; i++) {
				Assert.AreEqual(numbers[i], list.Get(i));
			}
		}
		(int[] numbers, TurboList<int>) CreateTestData() {
			int[] numbers = {8, 7, 0, 6, 1, 0, 8, 3, 3, 2};
			var list = new TurboList<int>();
			foreach (var number in numbers) {
				list.Add(number);
			}
			return (numbers, list);
		}
		[Test]
		public void AnItemCanbeReplaced() {
			var list = new TurboList<int>();
			list.Add(5);
			list.Add(9);
			list.Set(1, 2);
			Assert.AreEqual(2, list.Get(1));
		}
		[Test]
		public void CanNotBeExtendedBySetting() {
			const int setIndex = 100;
			var (_, list) = CreateTestData();
			Assert.Throws<IndexOutOfRangeException>(() => list.Set(setIndex, 666));
		}
		[Test]
		public void IsEmptyAfterClearing() {
			var (_, list) = CreateTestData();
			list.Clear();
			Assert.Zero(list.Count);
		}
		[Test]
		public void ItemIsAddedAtIndexZeroAfterClearing() {
			var (_, list) = CreateTestData();
			list.Clear();
			list.Add(5);
			Assert.AreEqual(1, list.Count);
			Assert.AreEqual(5, list.Get(0));
		}
		[Test]
		public void ItemsAreClearedWhenClearing() {
			// Given
			var (numbers, list) = CreateTestData();
			// When
			list.Clear();
			// Then
			for (int i = 0; i < numbers.Length; i++) {
				Assert.Zero(list.Get(i));
			}
		}
		[Test]
		public void CountIsReducedWhenRemovingAt() {
			var (numbers, list) = CreateTestData();
			list.RemoveAt(2);
			Assert.AreEqual(numbers.Length - 1, list.Count);
		}
		[Test]
		public void ItemsAreMovedForwardWhenRemovingAt() {
			var (numbers, list) = CreateTestData();
			list.RemoveAt(2);
			for (int i = 2; i < numbers.Length - 1; i++) {
				Assert.AreEqual(numbers[i + 1], list.Get(i), $"Wrong item at index {i}");
			}
		}
		[Test]
		public void ItemCanBeRemoved() {
			var list = new TurboList<int>();
			list.Add(8);
			list.Add(7);
			list.Add(0);
			list.Add(6);
			list.Add(1);
			list.RemoveAt(2);
			Assert.AreEqual(6, list.Get(2));
			// Assert.Zero(list.Get(4));
		}
	}
}
