using NUnit.Framework;

namespace UnityForProgrammers.Tests {
	public class StringExtensionsTests {
		[TestCase("Hello 1 world", "Hello1World")]
		[TestCase("HELLO 1 WORLD", "Hello1World")]
		[TestCase("hello 1 world", "Hello1World")]
		[TestCase("Hello 1 World", "Hello1World")]
		[TestCase("Hello1World", "Hello1World")]
		[TestCase("hello1World", "Hello1World")]
		[TestCase("HelloWorld", "HelloWorld")]
		[TestCase("helloWorld", "HelloWorld")]
		[TestCase("XDist", "XDist")]
		[TestCase("hello_1_world", "Hello1World")]
		[TestCase("Hello_1_World", "Hello1World")]
		[TestCase("HELLO_1_WORLD", "Hello1World")]
		[TestCase("hello-1-world", "Hello1World")]
		[TestCase("Hello-1-World", "Hello1World")]
		[TestCase("HELLO-1-WORLD", "Hello1World")]
		[TestCase("Alice - Bob", "AliceBob")]
		public void ToPascalCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToPascalCase());
		}

		[TestCase("Hello 1 world", "hello1World")]
		[TestCase("HELLO 1 WORLD", "hello1World")]
		[TestCase("hello 1 world", "hello1World")]
		[TestCase("Hello 1 World", "hello1World")]
		[TestCase("Hello1World", "hello1World")]
		[TestCase("hello1World", "hello1World")]
		[TestCase("HelloWorld", "helloWorld")]
		[TestCase("helloWorld", "helloWorld")]
		[TestCase("XDist", "xDist")]
		[TestCase("hello_1_world", "hello1World")]
		[TestCase("Hello_1_World", "hello1World")]
		[TestCase("HELLO_1_WORLD", "hello1World")]
		[TestCase("hello-1-world", "hello1World")]
		[TestCase("Hello-1-World", "hello1World")]
		[TestCase("HELLO-1-WORLD", "hello1World")]
		[TestCase("Alice - Bob", "aliceBob")]
		public void ToCamelCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToCamelCase());
		}

		[TestCase("Hello 1 world", "hello_1_world")]
		[TestCase("HELLO 1 WORLD", "hello_1_world")]
		[TestCase("hello 1 world", "hello_1_world")]
		[TestCase("Hello 1 World", "hello_1_world")]
		[TestCase("Hello1World", "hello_1_world")]
		[TestCase("hello1World", "hello_1_world")]
		[TestCase("HelloWorld", "hello_world")]
		[TestCase("helloWorld", "hello_world")]
		[TestCase("XDist", "x_dist")]
		[TestCase("hello_1_world", "hello_1_world")]
		[TestCase("Hello_1_World", "hello_1_world")]
		[TestCase("HELLO_1_WORLD", "hello_1_world")]
		[TestCase("hello-1-world", "hello_1_world")]
		[TestCase("Hello-1-World", "hello_1_world")]
		[TestCase("HELLO-1-WORLD", "hello_1_world")]
		[TestCase("Alice - Bob", "alice_bob")]
		public void ToSnakeCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToSnakeCase());
		}

		[TestCase("Hello 1 world", "HELLO_1_WORLD")]
		[TestCase("HELLO 1 WORLD", "HELLO_1_WORLD")]
		[TestCase("hello 1 world", "HELLO_1_WORLD")]
		[TestCase("Hello 1 World", "HELLO_1_WORLD")]
		[TestCase("Hello1World", "HELLO_1_WORLD")]
		[TestCase("hello1World", "HELLO_1_WORLD")]
		[TestCase("HelloWorld", "HELLO_WORLD")]
		[TestCase("helloWorld", "HELLO_WORLD")]
		[TestCase("XDist", "X_DIST")]
		[TestCase("hello_1_world", "HELLO_1_WORLD")]
		[TestCase("Hello_1_World", "HELLO_1_WORLD")]
		[TestCase("HELLO_1_WORLD", "HELLO_1_WORLD")]
		[TestCase("hello-1-world", "HELLO_1_WORLD")]
		[TestCase("Hello-1-World", "HELLO_1_WORLD")]
		[TestCase("HELLO-1-WORLD", "HELLO_1_WORLD")]
		[TestCase("Alice - Bob", "ALICE_BOB")]
		public void ToScreamingSnakeCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToScreamingSnakeCase());
		}

		[TestCase("Hello 1 world", "hello-1-world")]
		[TestCase("HELLO 1 WORLD", "hello-1-world")]
		[TestCase("hello 1 world", "hello-1-world")]
		[TestCase("Hello 1 World", "hello-1-world")]
		[TestCase("Hello1World", "hello-1-world")]
		[TestCase("hello1World", "hello-1-world")]
		[TestCase("HelloWorld", "hello-world")]
		[TestCase("helloWorld", "hello-world")]
		[TestCase("XDist", "x-dist")]
		[TestCase("hello_1_world", "hello-1-world")]
		[TestCase("Hello_1_World", "hello-1-world")]
		[TestCase("HELLO_1_WORLD", "hello-1-world")]
		[TestCase("hello-1-world", "hello-1-world")]
		[TestCase("Hello-1-World", "hello-1-world")]
		[TestCase("HELLO-1-WORLD", "hello-1-world")]
		[TestCase("Alice - Bob", "alice-bob")]
		public void ToKebabCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToKebabCase());
		}

		[TestCase("Hello 1 world", "HELLO-1-WORLD")]
		[TestCase("HELLO 1 WORLD", "HELLO-1-WORLD")]
		[TestCase("hello 1 world", "HELLO-1-WORLD")]
		[TestCase("Hello 1 World", "HELLO-1-WORLD")]
		[TestCase("Hello1World", "HELLO-1-WORLD")]
		[TestCase("hello1World", "HELLO-1-WORLD")]
		[TestCase("HelloWorld", "HELLO-WORLD")]
		[TestCase("helloWorld", "HELLO-WORLD")]
		[TestCase("XDist", "X-DIST")]
		[TestCase("hello_1_world", "HELLO-1-WORLD")]
		[TestCase("Hello_1_World", "HELLO-1-WORLD")]
		[TestCase("HELLO_1_WORLD", "HELLO-1-WORLD")]
		[TestCase("hello-1-world", "HELLO-1-WORLD")]
		[TestCase("Hello-1-World", "HELLO-1-WORLD")]
		[TestCase("HELLO-1-WORLD", "HELLO-1-WORLD")]
		[TestCase("Alice - Bob", "ALICE-BOB")]
		public void ToScreamingKebabCase_ShouldConvertCorrectly(string input, string expected) {
			Assert.AreEqual(expected, input.ToScreamingKebabCase());
		}
	}
}