using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace UnityForProgrammers {
	/// <summary>Extensions to make working with C# easier.</summary>
	public static class SystemExtensions {
		/// <summary>
		/// Iterates over an IEnumerable and performs an action on each item.
		/// </summary>
		/// <typeparam name="T">The type of the IEnumerable.</typeparam>
		/// <param name="enumerable">The IEnumerable to iterate over.</param>
		/// <param name="action">The action to perform on each item.</param>
		/// <returns>The original IEnumerable.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
			foreach (var item in enumerable) {
				action(item);
				yield return item;
			}
		}
		
	#region String Extensions
		/// <summary>
		/// Indicates whether the specified string is <c>null</c> or an empty string ("").
		/// </summary>
		/// <param name="this">The string to test.</param>
		/// <returns><c>true</c> if the value parameter is <c>null</c> or an empty string (""); otherwise, <c>false.</c></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNullOrEmpty(this string @this) => string.IsNullOrEmpty(@this);
		
		/// <summary>
		/// Replaces entire strings with another string.
		/// </summary>
		/// <param name="this">The original string.</param>
		/// <param name="from">The string to replace.</param>
		/// <param name="to">The string to replace with.</param>
		/// <returns><c>to</c> if <c>this</c> is equal to <c>from</c>; otherwise, <c>this</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string Convert(this string @this, string from, string to) =>
			@this == from ? to : @this;
		
		/// <summary>
		/// Attempts to remove a pattern from a string.
		/// </summary>
		/// <param name="this">The original string.</param>
		/// <param name="pattern">The pattern to remove.</param>
		/// <param name="result">The original string, but with the pattern removed.</param>
		/// <returns><c>true</c> if anything remains after the pattern is removed; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryIsolate(this string @this, string pattern, out string result) {
			result = Regex.Replace(@this, pattern, "");
			return !result.IsNullOrEmpty();
		}
		
		/// <summary>
		/// Attempts to remove a pattern from a string.
		/// </summary>
		/// <param name="this">The original string.</param>
		/// <param name="pattern">The pattern to remove.</param>
		/// <param name="result">The original string, but with the pattern removed.</param>
		/// <returns><c>true</c> if anything was removed; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryRemove(this string @this, string pattern, out string result) {
			result = Regex.Replace(@this, pattern, "");
			return result != @this;
		}
	#endregion String Extensions
		
		/// <summary>
		/// Picks a random item from an ordered enumerable.
		/// </summary>
		/// <typeparam name="T">The type of the ordered enumerable.</typeparam>
		/// <param name="this">The ordered enumerable to pick from.</param>
		/// <returns>A random item from the ordered enumerable.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ChooseRandom<T>(this IOrderedEnumerable<T> @this) => @this.ElementAt(UnityEngine.Random.Range(0, @this.Count()));
		
		/// <summary>
		/// Picks a random item from an ordered enumerable.
		/// </summary>
		/// <typeparam name="T">The type of the ordered enumerable.</typeparam>
		/// <param name="this">The ordered enumerable to pick from.</param>
		/// <param name="rng">The random number generator to use.</param>
		/// <returns>A random item from the ordered enumerable.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ChooseRandom<T>(this IOrderedEnumerable<T> @this, Random rng) => @this.ElementAt(rng.Next(@this.Count()));
		
		/// <summary>
		/// Given a collection which contains values, and a function which returns a collection of keys for each value, creates a dictionary which maps each key to its corresponding value.
		/// </summary>
		/// <typeparam name="TKey">The type of the keys.</typeparam>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="this">A collection of values.</param>
		/// <param name="keySelector">A function which returns a collection of keys for each value.</param>
		/// <returns>A dictionary mapping several keys to each value in the original collection.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Dictionary<TKey, TValue> ManyToOne<TKey, TValue>(this IEnumerable<TValue> @this, Func<TValue, IEnumerable<TKey>> keySelector) {
			Dictionary<TKey, TValue> dictionary = new();
			foreach (var collection in @this) {
				foreach (var key in keySelector(collection)) {
					dictionary.Add(key, collection);
				}
			}
			return dictionary;
		}
	}
}