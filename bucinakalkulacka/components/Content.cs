namespace bucinakalkulacka.components
{
    public class Content
    {
        public string Value { get; set; } = "";

        public void Push(string value)
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
                        Pop();
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
        public void Pop()
        {
            if (Value.Length > 0)
                Value = Value.Substring(0, Value.Length - 1);
        }       
    }
}
