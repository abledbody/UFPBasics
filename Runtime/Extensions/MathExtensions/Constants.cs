namespace UnityForProgrammers {
	/// <summary>
	/// A collection of mathematical constants and extensions. By importing UnityForProgrammers, these extensions will be available on their respective types.
	/// </summary>
	public static partial class MathExtensions {
		/// <summary>
		/// Represents the ratio of a circle's circumference to its radius. It is also the number of radians in a full rotation.
		/// </summary>
		public const float TAU = 6.28318530718f;

		/// <summary>
		/// Convenience constant for <c>TAU/2</c>.
		/// </summary>
		public const float PI = 3.14159265359f;

		/// <summary>
		/// Convenience constant for <c>TAU/4</c>.
		/// </summary>
		public const float ETA = 1.57079632679f;

		/// <summary>
		/// Represents golden ratio. It has the unique property that <c>PHI.Pow(-1) + 1 == PHI.Pow(2) - 1 == PHI</c>.
		/// </summary>
		public const float PHI = 1.61803398875f;

		/// <summary>
		/// Represents the base for natural logarithms. <c>e^x</c> is uniquely its own derivative, enabling calculations of continuous growth and decay.
		/// </summary>
		public const float E = 2.71828182846f;
	}
}