using System;
using System.Data;
using System.Globalization;

namespace bucinakalkulacka.components
{
    public class Counter
    {
        DataTable dt = new();

        public string GetValue(string baseValue)
        {
            return dt.Compute(baseValue, "").ToString().Replace(",", ".");
        }
        public string Mocnit(string baseValue)
        {
            try
            {
                baseValue = GetValue(baseValue);
                return dt.Compute($"{baseValue}*{baseValue}", "").ToString().Replace(",", ".");
            }
            catch
            {
                return baseValue;
            }            
        }
        public string Odmocnit(string baseValue)
        {          
            return Math.Sqrt(float.Parse(baseValue, CultureInfo.InvariantCulture)).ToString();
        }

    }
}
