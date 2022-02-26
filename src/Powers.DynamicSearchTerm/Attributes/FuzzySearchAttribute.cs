using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.DynamicSearchTerm.Attributes
{
    /// <summary>
    /// 模糊查询
    /// </summary>
    public class FuzzySearchAttribute : Attribute, IComparable<FuzzySearchAttribute>
    {
        public int CompareTo(FuzzySearchAttribute other)
        {
            throw new NotImplementedException();
        }
    }
}
