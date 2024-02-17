using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
	#region LerpUnclamped
		/// <summary>
		/// Linearly interpolates between two values without clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float LerpUnclamped(this float t, float a, float b) => a + (b - a) * t;
		
		/// <summary>
		/// Linearly interpolates between two values without clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 LerpUnclamped(this float t, Vector2 a, Vector2 b) => a + (b - a) * t;
		
		/// <summary>
		/// Linearly interpolates between two values without clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 LerpUnclamped(this float t, Vector3 a, Vector3 b) => a + (b - a) * t;
		
		/// <summary>
		/// Linearly interpolates between two values without clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 LerpUnclamped(this float t, Vector4 a, Vector4 b) => a + (b - a) * t;
	#endregion
		
	#region Lerp
		/// <summary>
		/// Linearly interpolates between two values, clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Lerp(this float t, float a, float b) => t.Saturate().LerpUnclamped(a, b);
		
		/// <summary>
		/// Linearly interpolates between two values, clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Lerp(this float t, Vector2 a, Vector2 b) => t.Saturate().LerpUnclamped(a, b);
		
		/// <summary>
		/// Linearly interpolates between two values, clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Lerp(this float t, Vector3 a, Vector3 b) => t.Saturate().LerpUnclamped(a, b);
		
		/// <summary>
		/// Linearly interpolates between two values, clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Lerp(this float t, Vector4 a, Vector4 b) => t.Saturate().LerpUnclamped(a, b);
	#endregion
		
		/// <summary>
		/// Finds the linear parameter t that produces the interpolant value within the range [a, b].
		/// </summary>
		/// <param name="this">The value to get the interpolant for.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linear parameter t that produces the interpolant value within the range [a, b].</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float InverseLerpUnclamped(this float @this, float a, float b) => (@this - a) / (b - a);
		
		/// <summary>
		/// Finds the linear parameter t that produces the interpolant value within the range [a, b], where t is clamped between 0 and 1.
		/// </summary>
		/// <param name="this">The value to get the interpolant for.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linear parameter t that produces the interpolant value within the range [a, b].</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float InverseLerp(this float @this, float a, float b) => @this.InverseLerpUnclamped(a, b).Saturate();
		
		/// <summary>
		/// Normalizes a value to the range [0, 1].
		/// </summary>
		/// <param name="t"></param>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Normalize(this float t, float a, float b) => t.InverseLerpUnclamped(a, b);
		
		/// <summary>
		/// Remaps a value from one range to another.
		/// </summary>
		/// <param name="this">The value to remap.</param>
		/// <param name="fromLower">The lower bound of the original range.</param>
		/// <param name="fromUpper">The upper bound of the original range.</param>
		/// <param name="toLower">The lower bound of the target range.</param>
		/// <param name="toUpper">The upper bound of the target range.</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Remap(this float @this, float fromLower, float fromUpper, float toLower, float toUpper) =>
			@this.InverseLerpUnclamped(fromLower, fromUpper).LerpUnclamped(toLower, toUpper);
		
	#region MoveTowards
		/// <summary>
		/// Moves a value towards a target value in increments of maxDelta. Will never overshoot the target.
		/// </summary>
		/// <param name="this">The value to move.</param>
		/// <param name="target">The target value to move towards.</param>
		/// <param name="maxDelta">The maximum change in value.</param>
		/// <returns>The value after moving towards the target value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MoveTowards(this float @this, float target, float maxDelta) => @this + (target - @this).Clamp(-maxDelta, maxDelta);
		
		/// <summary>
		/// Moves a value towards a target value in increments of maxDelta. Will never overshoot the target.
		/// </summary>
		/// <param name="this">The value to move.</param>
		/// <param name="target">The target value to move towards.</param>
		/// <param name="maxDelta">The maximum change in value.</param>
		/// <returns>The value after moving towards the target value.</returns>
		/// <remarks>The distance of each step is in euclidean space. This is not a piecewise function.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MoveTowards(this Vector2 @this, Vector2 target, float maxDelta) => @this + (target - @this).CapMagnitude(maxDelta);
		
		/// <summary>
		/// Moves a value towards a target value in increments of maxDelta. Will never overshoot the target.
		/// </summary>
		/// <param name="this">The value to move.</param>
		/// <param name="target">The target value to move towards.</param>
		/// <param name="maxDelta">The maximum change in value.</param>
		/// <returns>The value after moving towards the target value.</returns>
		/// <remarks>The distance of each step is in euclidean space. This is not a piecewise function.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MoveTowards(this Vector3 @this, Vector3 target, float maxDelta) => @this + (target - @this).CapMagnitude(maxDelta);
		
		/// <summary>
		/// Moves a value towards a target value in increments of maxDelta. Will never overshoot the target.
		/// </summary>
		/// <param name="this">The value to move.</param>
		/// <param name="target">The target value to move towards.</param>
		/// <param name="maxDelta">The maximum change in value.</param>
		/// <returns>The value after moving towards the target value.</returns>
		/// <remarks>The distance of each step is in euclidean space. This is not a piecewise function.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MoveTowards(this Vector4 @this, Vector4 target, float maxDelta) => @this + (target - @this).CapMagnitude(maxDelta);
	#endregion
		
	#if UFP_PKG_MATHEMATICS
	
	#region LerpUnclamped
		/// <summary>
		/// Linearly interpolates between two values without clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 LerpUnclamped(this float t, float2 a, float2 b) => math.lerp(a, b, t);
		
		/// <summary>
		/// Linearly interpolates between two values without clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 LerpUnclamped(this float t, float3 a, float3 b) => math.lerp(a, b, t);
		
		/// <summary>
		/// Linearly interpolates between two values without clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 LerpUnclamped(this float t, float4 a, float4 b) => math.lerp(a, b, t);
	#endregion
	
	#region Lerp
		/// <summary>
		/// Linearly interpolates between two values, clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Lerp(this float t, float2 a, float2 b) => t.Saturate().LerpUnclamped(a, b);
		
		/// <summary>
		/// Linearly interpolates between two values, clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Lerp(this float t, float3 a, float3 b) => t.Saturate().LerpUnclamped(a, b);
		
		/// <summary>
		/// Linearly interpolates between two values, clamping the interpolant between 0 and 1.
		/// </summary>
		/// <param name="t">The interpolant determining how far from a to b the result will be.</param>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <returns>The linearly interpolated value between a and b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Lerp(this float t, float4 a, float4 b) => t.Saturate().LerpUnclamped(a, b);
	#endregion
	
	#region MoveTowards	
		/// <summary>
		/// Moves a value towards a target value in increments of maxDelta. Will never overshoot the target.
		/// </summary>
		/// <param name="this">The value to move.</param>
		/// <param name="target">The target value to move towards.</param>
		/// <param name="maxDelta">The maximum change in value.</param>
		/// <returns>The value after moving towards the target value.</returns>
		/// <remarks>The distance of each step is in euclidean space. This is not a piecewise function.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 MoveTowards(this float2 val, float2 target, float maxDelta) => val + (target - val).CapMagnitude(maxDelta);
		
		/// <summary>
		/// Moves a value towards a target value in increments of maxDelta. Will never overshoot the target.
		/// </summary>
		/// <param name="this">The value to move.</param>
		/// <param name="target">The target value to move towards.</param>
		/// <param name="maxDelta">The maximum change in value.</param>
		/// <returns>The value after moving towards the target value.</returns>
		/// <remarks>The distance of each step is in euclidean space. This is not a piecewise function.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 MoveTowards(this float3 val, float3 target, float maxDelta) => val + (target - val).CapMagnitude(maxDelta);
		
		/// <summary>
		/// Moves a value towards a target value in increments of maxDelta. Will never overshoot the target.
		/// </summary>
		/// <param name="this">The value to move.</param>
		/// <param name="target">The target value to move towards.</param>
		/// <param name="maxDelta">The maximum change in value.</param>
		/// <returns>The value after moving towards the target value.</returns>
		/// <remarks>The distance of each step is in euclidean space. This is not a piecewise function.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 MoveTowards(this float4 val, float4 target, float maxDelta) => val + (target - val).CapMagnitude(maxDelta);
	#endregion
	#else
		// For now, nothing in this category uses Mathf or System.Math. If you need to use them, you can add them here.
	#endif
	}
}