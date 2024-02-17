using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		/// <summary>Converts a FOV value in degrees into a slope.</summary>
		/// <param name="fov">The FOV value in degrees.</param>
		/// <returns>The slope of half the FOV.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float FOVToSlope(this float fov) => (fov.Radians() / 2f).Tan();
		
		/// <summary>Converts a slope into a FOV value in degrees.</summary>
		/// <param name="slope">The slope of half the FOV.</param>
		/// <returns>The FOV value in degrees.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SlopeToFOV(this float slope) => slope.Atan().Degrees() * 2f;
		
	#if UFP_PKG_MATHEMATICS
		/// <summary>
		/// Converts an angle from radians to degrees.
		/// </summary>
		/// <param name="radians">The angle in radians.</param>
		/// <returns>The angle in degrees.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Degrees(this float radians) => math.degrees(radians);
		
		/// <summary>
		/// Converts an angle from degrees to radians.
		/// </summary>
		/// <param name="degrees">The angle in degrees.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Radians(this float degrees) => math.radians(degrees);
		
		/// <summary>
		/// Returns the y-coordinate of a point 'a' radians around a circle of radius 1.
		/// </summary>
		/// <param name="a">The angle in radians.</param>
		/// <returns>The sine of the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sin(this float a) => math.sin(a);
		
		/// <summary>
		/// In the range [-1, 1], returns the angle at which a circle of radius 1 intersects the given y-coordinate.
		/// </summary>
		/// <param name="y">The value to get the arcsine of.</param>
		/// <returns>The angle in radians, in a range of [-ETA, ETA].</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Asin(this float y) => math.asin(y);
		
		/// <summary>
		/// Returns the x-coordinate of a point 'a' radians around a circle of radius 1.
		/// </summary>
		/// <param name="a">The angle in radians.</param>
		/// <returns>The cosine of the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Cos(this float a) => math.cos(a);
		
		/// <summary>
		/// In the range [-1, 1], returns the angle at which the given x-coordinate produced on a circle of radius 1.
		/// </summary>
		/// <param name="x">The value to get the arccosine of.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Acos(this float a) => math.acos(a);
		
		/// <summary>
		/// Converts an angle to a slope.
		/// </summary>
		/// <param name="a">The angle in radians.</param>
		/// <returns>The slope of the angle.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Tan(this float a) => math.tan(a);
		
		/// <summary>
		/// Converts a slope to an angle.
		/// </summary>
		/// <param name="a">The slope.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan(this float a) => math.atan(a);
		
		/// <summary>
		/// Returns the angle of a vector in radians.
		/// </summary>
		/// <param name="this">The vector to get the angle of.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan2(this Vector2 @this) => math.atan2(@this.y, @this.x);
		
		/// <summary>
		/// Returns the angle of a vector in radians.
		/// </summary>
		/// <param name="this">The vector to get the angle of.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan2(this float2 @this) => math.atan2(@this.y, @this.x);
	#else
		/// <summary>
		/// Converts an angle from radians to degrees.
		/// </summary>
		/// <param name="radians">The angle in radians.</param>
		/// <returns>The angle in degrees.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Degrees(this float radians) => radians * Mathf.Rad2Deg;
		
		/// <summary>
		/// Converts an angle from degrees to radians.
		/// </summary>
		/// <param name="degrees">The angle in degrees.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Radians(this float degrees) => degrees * Mathf.Deg2Rad;
		
		/// <summary>
		/// Returns the y-coordinate of a point 'a' radians around a circle of radius 1.
		/// </summary>
		/// <param name="a">The angle in radians.</param>
		/// <returns>The sine of the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sin(this float a) => (float)Math.Sin(a);
		
		/// <summary>
		/// In the range [-1, 1], returns the angle at which a circle of radius 1 intersects the given y-coordinate.
		/// </summary>
		/// <param name="y">The value to get the arcsine of.</param>
		/// <returns>The angle in radians, in a range of [-ETA, ETA].</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Asin(this float a) => (float)Math.Asin(a);
		
		/// <summary>
		/// Returns the x-coordinate of a point 'a' radians around a circle of radius 1.
		/// </summary>
		/// <param name="a">The angle in radians.</param>
		/// <returns>The cosine of the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Cos(this float a) => (float)Math.Cos(a);
		
		/// <summary>
		/// In the range [-1, 1], returns the angle at which the given x-coordinate produced on a circle of radius 1.
		/// </summary>
		/// <param name="x">The value to get the arccosine of.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Acos(this float a) => (float)Math.Acos(a);
		
		/// <summary>
		/// Converts an angle to a slope.
		/// </summary>
		/// <param name="a">The angle in radians.</param>
		/// <returns>The slope of the angle.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Tan(this float a) => (float)Math.Tan(a);
		
		/// <summary>
		/// Converts a slope to an angle.
		/// </summary>
		/// <param name="a">The slope.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan(this float a) => (float)Math.Atan(a);
		
		/// <summary>
		/// Returns the angle of a vector in radians.
		/// </summary>
		/// <param name="this">The vector to get the angle of.</param>
		/// <returns>The angle in radians.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan2(this Vector2 vec) => (float)Math.Atan2(vec.y, vec.x);
	#endif
	}
}