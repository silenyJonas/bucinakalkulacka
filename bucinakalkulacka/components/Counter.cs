using System;
using System.Data;
using System.Globalization;

namespace bucinakalkulacka.components
{
    public class Counter
    {
        DataTable dt = new();
        private bool CelaCisla { get; set; }
        public Counter(bool celaCisla)
        {
            this.CelaCisla = celaCisla;
        }        
        
        public string GetValue(string baseValue)
        {
            //baseValue = "xxxxx"; //chybný vstup

            return UdelatCeleCislo(dt.Compute(baseValue, "").ToString().Replace(",", "."));
        }
        public string Mocnit(string baseValue)
        {
            try
            {
                baseValue = GetValue(baseValue);
                return UdelatCeleCislo(dt.Compute($"{baseValue}*{baseValue}", "").ToString()).Replace(",", ".");
            }
            catch
            {
                return baseValue;
            }
        }
        public string Odmocnit(string baseValue)
        {
            baseValue = GetValue(baseValue);
            return UdelatCeleCislo(Math.Sqrt(float.Parse(baseValue, CultureInfo.InvariantCulture)).ToString()).Replace(",", ".");
        }
        public string UdelatCeleCislo(string input)
        {
            if (this.CelaCisla)
            {
                string[] pole = input.Split('.');

                if (pole.Length > 1)
                {
                    if (!"01234".Contains(pole[1].Substring(0, 1)))
                    {
                        return dt.Compute($"{pole[0]}+1", "").ToString();
                    }
                    return pole[0];
                }
                return input;
            }

            return input;
        }
    }
}
