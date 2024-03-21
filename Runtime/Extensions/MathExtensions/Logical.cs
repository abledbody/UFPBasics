using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
	#region SameSign
		/// <summary>
		/// Returns false if lhs and rhs have opposite signs, otherwise true.
		/// </summary>
		/// <param name="lhs">The first value to check.</param>
		/// <param name="rhs">The second value to check.</param>
		/// <returns>Whether or not lhs and rhs have the same sign.</returns>
		/// <remarks>Values of 0 are always considered to have the same sign as the other value.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool SameSign(this float lhs, float rhs) => lhs * rhs >= 0;
		
		/// <summary>
		/// Returns false if lhs and rhs have opposite signs, otherwise true.
		/// </summary>
		/// <param name="lhs">The first value to check.</param>
		/// <param name="rhs">The second value to check.</param>
		/// <returns>Whether or not lhs and rhs have the same sign.</returns>
		/// <remarks>Values of 0 are always considered to have the same sign as the other value.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		// NOTE: Using XOR in this operation is only possible with integers.
		// When XORing two valid floats, it is possible to create an absurd result which cannot be meaningfully compared to zero.
		// Additionally, the use of XOR is done cautiously, with a full understanding of how C# handles integers.
		// Don't do tricks like this unless you're sure you understand the implications.
		public static bool SameSign(this int lhs, int rhs) => (lhs ^ rhs) >= 0;
	#endregion
		
	#region InRange
		/// <summary>
		/// Determines if a value is within a specified range.
		/// </summary>
		/// <param name="val">The value to check.</param>
		/// <param name="min">The minimum value of the range.</param>
		/// <param name="max">The maximum value of the range.</param>
		/// <returns>Whether or not val lies between min and max.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float val, float min, float max) => val >= min && val <= max;
		
		/// <summary>
		/// Determines if two points are within a specified range of each other.
		/// </summary>
		/// <param name="val">The first point to check.</param>
		/// <param name="target">The second point to check.</param>
		/// <param name="range">The maximum distance between the two points.</param>
		/// <returns>Whether or not the two points are within range of each other.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this Vector2 val, Vector2 target, float range) => (val - target).InRange(range);
		
		/// <summary>
		/// Determines if two points are within a specified range of each other.
		/// </summary>
		/// <param name="val">The first point to check.</param>
		/// <param name="target">The second point to check.</param>
		/// <param name="range">The maximum distance between the two points.</param>
		/// <returns>Whether or not the two points are within range of each other.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this Vector3 val, Vector3 target, float range) => (val - target).InRange(range);
		
		/// <summary>
		/// Determines if two points are within a specified range of each other.
		/// </summary>
		/// <param name="val">The first point to check.</param>
		/// <param name="target">The second point to check.</param>
		/// <param name="range">The maximum distance between the two points.</param>
		/// <returns>Whether or not the two points are within range of each other.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this Vector4 val, Vector4 target, float range) => (val - target).InRange(range);
		
		/// <summary>
		/// Determines if the length of a vector is within a specified range.
		/// </summary>
		/// <param name="val">The vector to check.</param>
		/// <param name="range">The distance to compare against.</param>
		/// <returns>Whether the length of the vector is shorter than or equal to the range.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this Vector2 val, float range) => val.SqrMagnitude() <= range.Sqr();
		
		/// <summary>
		/// Determines if the length of a vector is within a specified range.
		/// </summary>
		/// <param name="val">The vector to check.</param>
		/// <param name="range">The distance to compare against.</param>
		/// <returns>Whether the length of the vector is shorter than or equal to the range.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this Vector3 val, float range) => val.SqrMagnitude() <= range.Sqr();
		
		/// <summary>
		/// Determines if the length of a vector is within a specified range.
		/// </summary>
		/// <param name="val">The vector to check.</param>
		/// <param name="range">The distance to compare against.</param>
		/// <returns>Whether the length of the vector is shorter than or equal to the range.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this Vector4 val, float range) => val.SqrMagnitude() <= range.Sqr();
	#endregion
	
	#if UFP_PKG_MATHEMATICS
	
	#region InRange
		/// <summary>
		/// Determines if two points are within a specified range of each other.
		/// </summary>
		/// <param name="val">The first point to check.</param>
		/// <param name="target">The second point to check.</param>
		/// <param name="range">The maximum distance between the two points.</param>
		/// <returns>Whether or not the two points are within range of each other.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float2 val, float2 target, float range) => (val - target).InRange(range);
		
		/// <summary>
		/// Determines if two points are within a specified range of each other.
		/// </summary>
		/// <param name="val">The first point to check.</param>
		/// <param name="target">The second point to check.</param>
		/// <param name="range">The maximum distance between the two points.</param>
		/// <returns>Whether or not the two points are within range of each other.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float3 val, float3 target, float range) => (val - target).InRange(range);
		
		/// <summary>
		/// Determines if two points are within a specified range of each other.
		/// </summary>
		/// <param name="val">The first point to check.</param>
		/// <param name="target">The second point to check.</param>
		/// <param name="range">The maximum distance between the two points.</param>
		/// <returns>Whether or not the two points are within range of each other.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float4 val, float4 target, float range) => (val - target).InRange(range);
		
		/// <summary>
		/// Determines if the length of a vector is within a specified range.
		/// </summary>
		/// <param name="val">The vector to check.</param>
		/// <param name="range">The distance to compare against.</param>
		/// <returns>Whether the length of the vector is shorter than or equal to the range.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float2 val, float range) => val.SqrMagnitude() <= range.Sqr();
		
		/// <summary>
		/// Determines if the length of a vector is within a specified range.
		/// </summary>
		/// <param name="val">The vector to check.</param>
		/// <param name="range">The distance to compare against.</param>
		/// <returns>Whether the length of the vector is shorter than or equal to the range.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float3 val, float range) => val.SqrMagnitude() <= range.Sqr();
		
		/// <summary>
		/// Determines if the length of a vector is within a specified range.
		/// </summary>
		/// <param name="val">The vector to check.</param>
		/// <param name="range">The distance to compare against.</param>
		/// <returns>Whether the length of the vector is shorter than or equal to the range.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float4 val, float range) => val.SqrMagnitude() <= range.Sqr();
	#endregion
	
	#else
		// For now, nothing in this category uses Mathf or System.Math. If you need to use them, you can add them here.
	#endif
	}
}