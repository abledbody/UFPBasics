using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float LerpUnclamped(this float t, float a, float b) => a + (b - a) * t;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 LerpUnclamped(this float t, Vector2 a, Vector2 b) => a + (b - a) * t;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 LerpUnclamped(this float t, Vector3 a, Vector3 b) => a + (b - a) * t;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 LerpUnclamped(this float t, Vector4 a, Vector4 b) => a + (b - a) * t;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Lerp(this float t, float a, float b) => t.Saturate().LerpUnclamped(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Lerp(this float t, Vector2 a, Vector2 b) => t.Saturate().LerpUnclamped(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Lerp(this float t, Vector3 a, Vector3 b) => t.Saturate().LerpUnclamped(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Lerp(this float t, Vector4 a, Vector4 b) => t.Saturate().LerpUnclamped(a, b);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float InverseLerpUnclamped(this float x, float a, float b) => (x - a) / (b - a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float InverseLerp(this float x, float a, float b) => x.InverseLerpUnclamped(a, b).Saturate();
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Normalize(this float t, float a, float b) => t.InverseLerpUnclamped(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Remap(this float val, float fromLimit1, float fromLimit2, float toLimit1, float toLimit2) =>
			val.InverseLerpUnclamped(fromLimit1, fromLimit2).LerpUnclamped(toLimit1, toLimit2);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MoveTowards(this float val, float target, float maxDelta) => val + (target - val).Clamp(-maxDelta, maxDelta);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MoveTowards(this Vector2 val, Vector2 target, float maxDelta) => val + (target - val).ClampMagnitude(maxDelta);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MoveTowards(this Vector3 val, Vector3 target, float maxDelta) => val + (target - val).ClampMagnitude(maxDelta);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MoveTowards(this Vector4 val, Vector4 target, float maxDelta) => val + (target - val).ClampMagnitude(maxDelta);
		
	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 LerpUnclamped(this float t, float2 a, float2 b) => math.lerp(a, b, t);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 LerpUnclamped(this float t, float3 a, float3 b) => math.lerp(a, b, t);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 LerpUnclamped(this float t, float4 a, float4 b) => math.lerp(a, b, t);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Lerp(this float t, float2 a, float2 b) => t.Saturate().LerpUnclamped(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Lerp(this float t, float3 a, float3 b) => t.Saturate().LerpUnclamped(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Lerp(this float t, float4 a, float4 b) => t.Saturate().LerpUnclamped(a, b);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 MoveTowards(this float2 val, float2 target, float maxDelta) => val + (target - val).ClampMagnitude(maxDelta);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 MoveTowards(this float3 val, float3 target, float maxDelta) => val + (target - val).ClampMagnitude(maxDelta);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 MoveTowards(this float4 val, float4 target, float maxDelta) => val + (target - val).ClampMagnitude(maxDelta);
	#else
		// For now, nothing in this category uses Mathf or System.Math. If you need to use them, you can add them here.
	#endif
	}
}