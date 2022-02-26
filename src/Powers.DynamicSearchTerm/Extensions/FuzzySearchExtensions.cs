using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace Powers.DynamicSearchTerm.Extensions
{
    public static class FuzzySearchExtensions
    {
        public static IQueryable<T> ApplyDynamicSearch<T>(this IQueryable<T> source, string query)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (string.IsNullOrWhiteSpace(query))
            {
                return source;
            }

            var fuzzyAfterSplit = query.Split(',');

            foreach (var fuzzyClause in fuzzyAfterSplit.Reverse())
            {
                var termedFuzzyClause = fuzzyClause.Trim();

                var fuzze = termedFuzzyClause.EndsWith(" f");

                var indexOfFirstSpace = termedFuzzyClause.IndexOf(" ", StringComparison.Ordinal);

                var propertyNameAndValue = indexOfFirstSpace == -1
                    ? termedFuzzyClause
                    : termedFuzzyClause.Remove(indexOfFirstSpace);

                var equality = propertyNameAndValue.Split('=');

                if (fuzze)
                {
                    source = source.Where($"{equality[0]}.Contains(@0)", equality[1]);
                }
                else
                {
                    source = source.Where(propertyNameAndValue);
                }
            }

            return source;
        }

        public static IQueryable<T> DynamicSearchV2<T>(this IQueryable<T> source, string query)
        {
            var querySplit = query.Split(",");
            var opStack = new Stack<string>();

            foreach (var item in querySplit)
            {
                opStack.Push(item);
            }

            return source.DynamicSearchV2(query);
        }
    }
}