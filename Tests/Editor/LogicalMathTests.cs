using NUnit.Framework;
using UnityForProgrammers;

public static class LogicalMathTests {
	
	
	[Test]
	public static void IntegerSameSign() {
		(int, bool)[] comparables = new (int, bool)[5] {(int.MinValue, true), (-1, true), (0, false), (1, false), (int.MaxValue, false)};
		
		for (int i = 0; i < comparables.Length; i++) {
			for (int j = 0; j < comparables.Length; j++) {
				var pureXNOR = !(comparables[i].Item2 ^ comparables[j].Item2);
				Assert.AreEqual(comparables[i].Item1.SameSign(comparables[j].Item1), pureXNOR);
			}
		}
	}
}