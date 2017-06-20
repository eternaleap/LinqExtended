using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExtended
{
    public static class MainExtention
    {
        public static IEnumerable<TResult> Map<TResult, TSource>(this IEnumerable<TSource> collection, Func<TSource, TResult> selector)
        {
            return collection.Select(selector);
        }

        public static IEnumerable<TResult> Map<TResult, TSource>(this IEnumerable<TSource> collection, Func<TSource, int, TResult> selector)
        {
            return collection.Select(selector);
        }

        /// <summary>
        /// Filter
        /// </summary>
        /// <typeparam name="TSource">source</typeparam>
        /// <param name="collection">collection to filter</param>
        /// <param name="predicate">predicate</param>
        /// <returns>result</returns>
        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> collection, Func<TSource, bool> predicate)
        {
            return collection.Where(predicate);
        }

        /// <summary>
        /// Filter
        /// </summary>
        /// <typeparam name="TSource">source</typeparam>
        /// <param name="collection">collection to filter</param>
        /// <param name="predicate">predicate</param>
        /// <returns>result</returns>
        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> collection, Func<TSource, int, bool> predicate)
        {
            return collection.Where(predicate);
        }

        /// <summary>
        /// Checks that set contains all elements from subSet
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="set">super set</param>
        /// <param name="subSet">sub set</param>
        /// <returns>true, if set contains all elements from sub set</returns>
        public static bool Contains<TSource>(this IEnumerable<TSource> set, IEnumerable<TSource> subSet)
        {
            return !subSet.Except(set).Any();
        }


        public static IEnumerable<T> Fold<T>(this IEnumerable<T> set, Func<T, T, T> func)
        {
            return set.Aggregate(func);
        }

    }
}
