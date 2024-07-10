using NUnit.Framework;

namespace UnityForProgrammers.Tests {
	public class StringExtensionsTests {
		[TestCase("A possible 3 - way tie", "APossible3WayTie")]
		[TestCase("A POSSIBLE 3 - WAY TIE", "APossible3WayTie")]
		[TestCase("a possible 3 - way tie", "APossible3WayTie")]
		[TestCase("A Possible 3 - Way Tie", "APossible3WayTie")]
		[TestCase("APossible3-WayTie",      "APossible3WayTie")]
		[TestCase("aPossible3-WayTie",      "APossible3WayTie")]
		[TestCase("a_possible_3_-_way_tie", "APossible3WayTie")]
		[TestCase("A_Possible_3_-_Way_Tie", "APossible3WayTie")]
		[TestCase("A_POSSIBLE_3_-_WAY_TIE", "APossible3WayTie")]
		[TestCase("a-possible-3---way-tie", "APossible3WayTie")]
		[TestCase("A-Possible-3---Way-Tie", "APossible3WayTie")]
		[TestCase("A-POSSIBLE-3---WAY-TIE", "APossible3WayTie")]
		public void ToPascalCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToPascalCase());
		}

		[TestCase("A possible 3 - way tie", "aPossible3WayTie")]
		[TestCase("A POSSIBLE 3 - WAY TIE", "aPossible3WayTie")]
		[TestCase("a possible 3 - way tie", "aPossible3WayTie")]
		[TestCase("A Possible 3 - Way Tie", "aPossible3WayTie")]
		[TestCase("APossible3-WayTie",      "aPossible3WayTie")]
		[TestCase("aPossible3-WayTie",      "aPossible3WayTie")]
		[TestCase("a_possible_3_-_way_tie", "aPossible3WayTie")]
		[TestCase("A_Possible_3_-_Way_Tie", "aPossible3WayTie")]
		[TestCase("A_POSSIBLE_3_-_WAY_TIE", "aPossible3WayTie")]
		[TestCase("a-possible-3---way-tie", "aPossible3WayTie")]
		[TestCase("A-Possible-3---Way-Tie", "aPossible3WayTie")]
		[TestCase("A-POSSIBLE-3---WAY-TIE", "aPossible3WayTie")]
		public void ToCamelCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToCamelCase());
		}

		[TestCase("A possible 3 - way tie", "a_possible_3_way_tie")]
		[TestCase("A POSSIBLE 3 - WAY TIE", "a_possible_3_way_tie")]
		[TestCase("a possible 3 - way tie", "a_possible_3_way_tie")]
		[TestCase("A Possible 3 - Way Tie", "a_possible_3_way_tie")]
		[TestCase("APossible3-WayTie",      "a_possible_3_way_tie")]
		[TestCase("aPossible3-WayTie",      "a_possible_3_way_tie")]
		[TestCase("a_possible_3_-_way_tie", "a_possible_3_way_tie")]
		[TestCase("A_Possible_3_-_Way_Tie", "a_possible_3_way_tie")]
		[TestCase("A_POSSIBLE_3_-_WAY_TIE", "a_possible_3_way_tie")]
		[TestCase("a-possible-3---way-tie", "a_possible_3_way_tie")]
		[TestCase("A-Possible-3---Way-Tie", "a_possible_3_way_tie")]
		[TestCase("A-POSSIBLE-3---WAY-TIE", "a_possible_3_way_tie")]
		public void ToSnakeCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToSnakeCase());
		}

		[TestCase("A possible 3 - way tie", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("A POSSIBLE 3 - WAY TIE", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("a possible 3 - way tie", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("A Possible 3 - Way Tie", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("APossible3-WayTie",      "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("aPossible3-WayTie",      "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("a_possible_3_-_way_tie", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("A_Possible_3_-_Way_Tie", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("A_POSSIBLE_3_-_WAY_TIE", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("a-possible-3---way-tie", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("A-Possible-3---Way-Tie", "A_POSSIBLE_3_WAY_TIE")]
		[TestCase("A-POSSIBLE-3---WAY-TIE", "A_POSSIBLE_3_WAY_TIE")]
		public void ToScreamingSnakeCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToScreamingSnakeCase());
		}

		[TestCase("A possible 3 - way tie", "a-possible-3-way-tie")]
		[TestCase("A POSSIBLE 3 - WAY TIE", "a-possible-3-way-tie")]
		[TestCase("a possible 3 - way tie", "a-possible-3-way-tie")]
		[TestCase("A Possible 3 - Way Tie", "a-possible-3-way-tie")]
		[TestCase("APossible3-WayTie",      "a-possible-3-way-tie")]
		[TestCase("aPossible3-WayTie",      "a-possible-3-way-tie")]
		[TestCase("a_possible_3_-_way_tie", "a-possible-3-way-tie")]
		[TestCase("A_Possible_3_-_Way_Tie", "a-possible-3-way-tie")]
		[TestCase("A_POSSIBLE_3_-_WAY_TIE", "a-possible-3-way-tie")]
		[TestCase("a-possible-3---way-tie", "a-possible-3-way-tie")]
		[TestCase("A-Possible-3---Way-Tie", "a-possible-3-way-tie")]
		[TestCase("A-POSSIBLE-3---WAY-TIE", "a-possible-3-way-tie")]
		public void ToKebabCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToKebabCase());
		}

		[TestCase("A possible 3 - way tie", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("A POSSIBLE 3 - WAY TIE", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("a possible 3 - way tie", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("A Possible 3 - Way Tie", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("APossible3-WayTie",      "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("aPossible3-WayTie",      "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("a_possible_3_-_way_tie", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("A_Possible_3_-_Way_Tie", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("A_POSSIBLE_3_-_WAY_TIE", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("a-possible-3---way-tie", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("A-Possible-3---Way-Tie", "A-POSSIBLE-3-WAY-TIE")]
		[TestCase("A-POSSIBLE-3---WAY-TIE", "A-POSSIBLE-3-WAY-TIE")]
		public void ToScreamingKebabCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToScreamingKebabCase());
		}
	}
}