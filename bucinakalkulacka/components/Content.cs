namespace bucinakalkulacka.components
{
    public class Content
    {
        public string Value { get; set; } = "";
        public string[] Db { get; set; } = new string[2];
        public int counter = 0;
        public bool CelaCisla { get; set; } = false;
        public void CelaCislaSwap()
        {
            CelaCisla = !CelaCisla;
        }
        public void AddValue(string value)
        {
            if (Value.Length > 0)
            {
                char check = Value[Value.Length - 1];

                if (
                    check == '+' ||
                    check == '-' ||
                    check == '*' ||
                    check == '/' ||
                    check == '.'
                )
                {
                    if (
                        value == "+" ||
                        value == "-" ||
                        value == "*" ||
                        value == "/" ||
                        value == "."
                        )
                    {
                        PopValue();
                    }
                }
            }
            
            string[] pole = Value.Split(new char[] { '+', '/', '*' });
            
            string posledniPrvek = pole[pole.Length - 1];

            if (!(posledniPrvek.Contains(".") && value == "."))
            { 
                Value = Value + value;
            }
        }
        public void PopValue()
        {
            if (Value.Length > 0)
                Value = Value.Substring(0, Value.Length - 1);
        }
        public void AddDb(string vypocet)
        {
            if (counter == Db.Length)
                ExtendDb();

            Db[counter] = $"{Value} = {vypocet}";       
            counter++;
        }
        private void ExtendDb()
        {            
            string[] temp = new string[Db.Length * 2];
            for(int i = 0; i < Db.Length; i++)
            {
                temp[i] = Db[i];
            }
            Db = temp;
        }
        public void Clear()
        {
            this.Value = "";
        }
    }
}
