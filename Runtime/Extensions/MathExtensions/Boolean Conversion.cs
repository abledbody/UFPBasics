using System.Runtime.CompilerServices;

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ToBool(this float val) => val >= 0.5f;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ToBool(this int val) => val != 0;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ToBool(this byte val) => val != 0;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ToFloat(this bool val) => val ? 1f : 0f;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ToInt(this bool val) => val ? 1 : 0;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ToByte(this bool val) => val ? (byte)1 : (byte)0;
	}
}