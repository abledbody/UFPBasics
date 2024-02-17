using NUnit.Framework;
using UnityForProgrammers;

public static class RangeExtensionsTests {
	[Test]
	public static void IntRangeForeach() {
		var nums = new int[10];
		foreach (var i in 0..10)
			nums[i] = i+1;
		for (int i = 0; i < 10; i++)
			Assert.AreEqual(nums[i], i+1);
	}
	
	[Test]
	public static void IntForeach() {
		var nums = new int[10];
		foreach (var i in 10)
			nums[i] = i+2;
		for (int i = 0; i < 10; i++)
			Assert.AreEqual(nums[i], i+2);
	}
	
	[Test]
	public static void IntRangeReverseForeach() {
		var nums = new int[10];
		var j = 0;
		foreach (var i in 10..0) {
			nums[i] = j;
			j++;
		}
		for (int i = 0; i < 10; i++)
			Assert.AreEqual(nums[i], 9 - i);
	}
	
	[Test]
	public static void IntSingleForeach() {
		foreach (var i in 2..3)
			Assert.AreEqual(i, 2);
	}
}