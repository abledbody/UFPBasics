using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnityForProgrammers {
	public static class SystemExtensions {
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
			foreach (var item in enumerable) {
				action(item);
				yield return item;
			}
		}
		
		public static bool IsNullOrEmpty(this string @this) => string.IsNullOrEmpty(@this);
		
		public static string Convert(this string @this, string from, string to) =>
			@this == from ? to : @this;

		public static bool TryRemoveNonNumeric(this string @this, out string result) {
			result = Regex.Replace(@this, "[^0-9.]", "");
			return !result.IsNullOrEmpty();
		}

		public static bool TryRemoveNonAlphabetic(this string @this, out string result) {
			result = Regex.Replace(@this, "[^a-zA-Z]", "");
			return !result.IsNullOrEmpty();
			
		}

		public static bool TryRemoveNonAlphanumeric(this string @this, out string result) {
			result = Regex.Replace(@this, "[^a-zA-Z0-9]", "");
			return !result.IsNullOrEmpty();
		}

		public static T ChooseRandom<T>(this List<T> @this) => @this[UnityEngine.Random.Range(0, @this.Count)];
		public static T ChooseRandom<T>(this T[] @this) => @this[UnityEngine.Random.Range(0, @this.Length)];
		
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