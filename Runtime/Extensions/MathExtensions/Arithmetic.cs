using System.Runtime.CompilerServices;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		/// <summary>
		/// Calculates the modulo of the dividend (lhs) and divisor (rhs).
		/// The result has the same sign as the divisor (rhs).
		/// </summary>
		/// <param name="lhs">The dividend.</param>
		/// <param name="rhs">The divisor.</param>
		/// <returns>The modulo of the dividend and divisor.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Mod(this int lhs, int rhs) => (lhs % rhs + rhs) % rhs;
		
		/// <summary>
		/// Calculates the modulo of the dividend (lhs) and divisor (rhs).
		/// The result has the same sign as the divisor (rhs).
		/// </summary>
		/// <param name="lhs">The dividend.</param>
		/// <param name="rhs">The divisor.</param>
		/// <returns>The modulo of the dividend and divisor.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Mod(this float lhs, float rhs) => (lhs % rhs + rhs) % rhs;
		
		/// <summary>
		/// Calculates the square of a given value.
		/// </summary>
		/// <param name="val">The value to calculate the square of.</param>
		/// <returns>The square of the given value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqr(this float val) => val * val;
		
		/// <summary>
		/// Calculates the square of a given value.
		/// </summary>
		/// <param name="val">The value to calculate the square of.</param>
		/// <returns>The square of the given value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sqr(this int val) => val * val;

	#if UFP_PKG_MATHEMATICS
		/// <summary>
		/// Calculates the square root of a given value.
		/// </summary>
		/// <param name="val">The value to calculate the square root of.</param>
		/// <returns>The square root of the given value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqrt(this float val) => math.sqrt(val);

		/// <summary>
		/// Calculates the square root of a given value.
		/// </summary>
		/// <param name="val">The value to calculate the square root of.</param>
		/// <returns>The square root of the given value.</returns>
		/// <remarks>Despite being called on an integer, this method returns a float.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqrt(this int val) => math.sqrt(val);
		
		/// <summary>
		/// Raises a given value to the power of another value.
		/// </summary>
		/// <param name="val">The value to raise to a power.</param>
		/// <param name="power">The power to raise the value to.</param>
		/// <returns>The value raised to the given power.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Pow(this float val, float power) => math.pow(val, power);
		
		/// <summary>
		/// Raises a given value to the power of another value.
		/// </summary>
		/// <param name="val">The value to raise to a power.</param>
		/// <param name="power">The power to raise the value to.</param>
		/// <returns>The value raised to the given power.</returns>
		/// <remarks>Despite being called on an integer, this method returns a float.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Pow(this int val, float power) => math.pow(val, power);
		
		/// <summary>
		/// Calculates e raised to the power of a given value.
		/// </summary>
		/// <param name="val">The value to raise e to the power of.</param>
		/// <returns>e raised to the power of the given value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exp(this float val) => math.exp(val);
		
		/// <summary>
		/// Calculates e raised to the power of a given value.
		/// </summary>
		/// <param name="val">The value to raise e to the power of.</param>
		/// <returns>e raised to the power of the given value.</returns>
		/// <remarks>Despite being called on an integer, this method returns a float.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exp(this int val) => math.exp(val);
	#else
		/// <summary>
		/// Calculates the square root of a given value.
		/// </summary>
		/// <param name="val">The value to calculate the square root of.</param>
		/// <returns>The square root of the given value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqrt(this float val) => (float)Math.Sqrt(val);

		/// <summary>
		/// Calculates the square root of a given value.
		/// </summary>
		/// <param name="val">The value to calculate the square root of.</param>
		/// <returns>The square root of the given value.</returns>
		/// <remarks>Despite being called on an integer, this method returns a float.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqrt(this int val) => (float)Math.Sqrt(val);
		
		/// <summary>
		/// Raises a given value to the power of another value.
		/// </summary>
		/// <param name="val">The value to raise to a power.</param>
		/// <param name="power">The power to raise the value to.</param>
		/// <returns>The value raised to the given power.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Pow(this float val, float power) => (float)Math.Pow(val, power);
		
		/// <summary>
		/// Raises a given value to the power of another value.
		/// </summary>
		/// <param name="val">The value to raise to a power.</param>
		/// <param name="power">The power to raise the value to.</param>
		/// <returns>The value raised to the given power.</returns>
		/// <remarks>Despite being called on an integer, this method returns a float.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Pow(this int val, float power) => (float)Math.Pow(val, power);
		
		/// <summary>
		/// Calculates e raised to the power of a given value.
		/// </summary>
		/// <param name="val">The value to raise e to the power of.</param>
		/// <returns>e raised to the power of the given value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exp(this float val) => (float)Math.Exp(val);
		
		/// <summary>
		/// Calculates e raised to the power of a given value.
		/// </summary>
		/// <param name="val">The value to raise e to the power of.</param>
		/// <returns>e raised to the power of the given value.</returns>
		/// <remarks>Despite being called on an integer, this method returns a float.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exp(this int val) => (float)Math.Exp(val);
	#endif
	}
}