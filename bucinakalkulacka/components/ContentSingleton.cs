namespace bucinakalkulacka.components
{
    public class ContentSingleton
    {
        public static Content Instance { get; set; } = null;       

        public static Content GetInstance()
        {
            if (Instance == null)
                Instance = new Content();

            return Instance;
        }

    }
}
