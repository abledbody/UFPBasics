using NUnit.Framework;
using UnityEngine;
using UnityForProgrammers;

public static class UnityExtensionTests {
	[Test]
	public static void LinkTest() {
		var gameObject = new GameObject();
		var fakeMonoAdded = gameObject.AddComponent<FakeMono>();
		gameObject.Link(out FakeMono fakeMonoLinked);
		Assert.IsNotNull(fakeMonoAdded);
		Assert.IsNotNull(fakeMonoLinked);
		Assert.AreEqual(fakeMonoAdded, fakeMonoLinked);
	}
}