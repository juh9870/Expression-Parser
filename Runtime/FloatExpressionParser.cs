using System.Globalization;
using UnityEngine;

namespace CodeWriter.ExpressionParser
{
    public class FloatExpressionParser : ExpressionParser<float>
    {
        public static readonly ExpressionParser<float> Instance = new FloatExpressionParser();

        protected override float Parse(string input) =>
            float.Parse(input, NumberStyles.Any, CultureInfo.InvariantCulture);

        protected override float Negate(float v) => -v;
        protected override float Add(float a, float b) => a + b;
        protected override float Sub(float a, float b) => a - b;
        protected override float Mul(float a, float b) => a * b;
        protected override float Div(float a, float b) => a / b;
        protected override float Mod(float a, float b) => a % b;
        protected override float Pow(float a, float b) => Mathf.Pow(a, b);
        protected override float Not(float v) => Mathf.Approximately(v, 0) ? 1 : 0;
        protected override float And(float a, float b) => !Mathf.Approximately(a, 0) ? b : 0;
        protected override float Or(float a, float b) => Mathf.Approximately(a, 0) ? b : a;
        protected override float Equal(float a, float b) => Mathf.Approximately(a, b) ? 1 : 0;
        protected override float NotEqual(float a, float b) => !Mathf.Approximately(a, b) ? 1 : 0;
        protected override float LessThan(float a, float b) => a < b ? 1 : 0;
        protected override float LessThanOrEqual(float a, float b) => a <= b ? 1 : 0;
        protected override float GreaterThan(float a, float b) => a > b ? 1 : 0;
        protected override float GreaterThanOrEqual(float a, float b) => a >= b ? 1 : 0;
        protected override bool IsTrue(float v) => !Mathf.Approximately(v, 0);
    }
}