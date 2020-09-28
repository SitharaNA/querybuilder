using System.Collections.Generic;

namespace SqlKata.SqlExpressions
{
    public class StringValue : SqlExpression, HasBinding
    {
        public string Value { get; }

        public StringValue(string value)
        {
            Value = value;
        }

        public IEnumerable<object> GetBindings()
        {
            return new[] { Value };
        }
    }
}