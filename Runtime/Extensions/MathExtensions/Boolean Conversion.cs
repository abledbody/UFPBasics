using System.Runtime.CompilerServices;

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		/// <summary>
		/// Converts a float value to a boolean value.
		/// </summary>
		/// <param name="val">The float value to convert.</param>
		/// <returns>True if the float value is greater than or equal to 0.5, otherwise false.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ToBool(this float val) => val >= 0.5f;

		/// <summary>
		/// Converts an integer value to a boolean value.
		/// </summary>
		/// <param name="val">The integer value to convert.</param>
		/// <returns>True if the integer value is not equal to 0, otherwise false.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ToBool(this int val) => val != 0;

		/// <summary>
		/// Converts a byte value to a boolean value.
		/// </summary>
		/// <param name="val">The byte value to convert.</param>
		/// <returns>True if the byte value is not equal to 0, otherwise false.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ToBool(this byte val) => val != 0;

		/// <summary>
		/// Converts a boolean value to a float value.
		/// </summary>
		/// <param name="val">The boolean value to convert.</param>
		/// <returns>1.0f if the boolean value is true, otherwise 0.0f.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ToFloat(this bool val) => val ? 1f : 0f;

		/// <summary>
		/// Converts a boolean value to an integer value.
		/// </summary>
		/// <param name="val">The boolean value to convert.</param>
		/// <returns>1 if the boolean value is true, otherwise 0.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ToInt(this bool val) => val ? 1 : 0;

		/// <summary>
		/// Converts a boolean value to a byte value.
		/// </summary>
		/// <param name="val">The boolean value to convert.</param>
		/// <returns>1 if the boolean value is true, otherwise 0.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ToByte(this bool val) => val ? (byte)1 : (byte)0;
	}
}