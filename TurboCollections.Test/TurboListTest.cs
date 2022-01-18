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
		public void AnItemCanbeReplaced() {
			var list = new TurboList<int>();
			list.Add(5);
			list.Add(9);
			list.Set(1, 2);
			Assert.AreEqual(2, list.Get(1));
		}
		[Test]
		public void ListCanBeCleared() {
			var list = new TurboList<int>();
			list.Add(5);
			list.Add(9);
			list.Clear();
			// Assert.AreEqual(0, list.Get(1));
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
