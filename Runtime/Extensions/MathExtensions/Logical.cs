using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float val, float min, float max) => val >= min && val <= max;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool SameSign(this float lhs, float rhs) => lhs * rhs >= 0;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool SameSign(this int lhs, int rhs) => lhs * rhs >= 0;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this Vector2 val, Vector2 target, float range) => (val - target).SqrMagnitude() <= range.Sqr();
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this Vector3 val, Vector3 target, float range) => (val - target).SqrMagnitude() <= range.Sqr();
	
	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float2 val, float2 target, float range) => (val - target).SqrMagnitude() <= range.Sqr();
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool InRange(this float3 val, float3 target, float range) => (val - target).SqrMagnitude() <= range.Sqr();
	#else
		// For now, nothing in this category uses Mathf or System.Math. If you need to use them, you can add them here.
	#endif
	}
}