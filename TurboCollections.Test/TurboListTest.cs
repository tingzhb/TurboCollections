using NUnit.Framework;

namespace TurboCollections.Test
{

	public class TurboListTest {
		[Test]
		public void NewListIsEmpty() {
			var list = new TurboList<int>();
			Assert.Zero(list.Count);
		}
		[Test]
		public void AddingAnElementIncreaseCountToOne() {
			var list = new TurboList<int>();
			list.Add(5);
			Assert.AreEqual(1, list.Count);
		}
	}
}
