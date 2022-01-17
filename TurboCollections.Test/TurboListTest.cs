using NUnit.Framework;

namespace TurboCollections.Test
{

	public class TurboListTest {
		[Test]
		public void NewListIsEmpty() {
			var list = new TurboList<int>();
			Assert.Zero(list.Count);
		}
		[Test, TestCase(5), TestCase(7)]
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
	}
}
