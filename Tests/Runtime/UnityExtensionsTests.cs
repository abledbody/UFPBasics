using NUnit.Framework;
using UnityEngine;

public static class UnityExtensionTests {
	[Test]
	public static void LinkTest() {
		var gameObject = new GameObject();
		var fakeMonoAdded = gameObject.AddComponent<FakeMonoB>();
		var fakeMono = gameObject.AddComponent<FakeMonoA>();
		Assert.IsNotNull(fakeMonoAdded);
		Assert.IsNotNull(fakeMono);
		Assert.IsNotNull(fakeMono.reference);
		Assert.AreEqual(fakeMonoAdded, fakeMono.reference);
		Assert.AreEqual(42, fakeMonoAdded.field);
	}
}