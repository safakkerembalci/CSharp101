class Classes
{
    static void Main(string[] args)
    {
        // Söz Dizimi
        // class SözDizimi
        // {
        //      [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
        //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı ([Parametre Listesi])
        //      {
        //          Metot Komutları
        //      }
        // }

        // Erişim Belirleyiciler
        // * Public
        // * Private
        // * Internal
        // * Protected

        Personal personal1 = new Personal();
        personal1.name = "Kerem";
        personal1.surname = "Şafak";
        personal1.ID = 3341;
        personal1.department = "Software";

        personal1.infoPersonal();

        Console.WriteLine("************************");

        Personal personal2 = new Personal();
        personal2.name = "Elon";
        personal2.surname = "Musk";
        personal2.ID = 45745;
        personal2.department = "Purchasing";

        personal2.infoPersonal();
    }

    class Personal
    {
        public string name;
        public string surname;
        public int ID;
        public string department;

        public void infoPersonal()
        {
            Console.WriteLine("Personal Name: {0}", name);
            Console.WriteLine("Personal Surname: {0}", surname);
            Console.WriteLine("Personal ID: {0}", ID);
            Console.WriteLine("Personal Department: {0}", department);

        }
    }
}