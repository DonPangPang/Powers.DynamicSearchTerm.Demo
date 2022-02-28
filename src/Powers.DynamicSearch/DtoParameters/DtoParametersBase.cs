using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.DynamicSearch.DtoParameters
{
    public class DtoParametersBase<T>
    {
        public T? Id { get; set; }

        // name=Jack,age=28,age=29
        public string? Q { get; set; }

        public string? OrderBy { get; set; }
    }
}