using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.DynamicSearch.Enums
{
    public enum WhereOperator
    {
        Equals,
        NotEquals,
        GreaterThan,
        LessThan,
        GreaterThanOrEqualTo,
        LessThanOrEqualTo,
        Contains,
        StartsWith,
        LessThanOrEqualWhenNullable,
        GreaterThanOrEqualWhenNullable
    }
}