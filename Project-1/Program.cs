// setup
string select, firstName, surname, phone, deleteName, status, type;
int id;

List<Contacts> contactList = new List<Contacts>();

// loop
while (true)
{
    select = Methods.readConsole("Lütfen Yapmak İstediğiniz İşlemi Seçiniz:\n*****************************************\n(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelle\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n(0) Çıkış\n");

    switch (select)
    {
        case "1":
            addContact();
            continue;

        case "2":
            deleteContact();
            continue;

        case "3":
            updateContact();
            continue;

        case "4":
            listContact();
            continue;

        case "5":
            searchContact();
            continue;

        case "0":
            Methods.exit();
            continue;

        default:
            Console.WriteLine("Lütfen 0-5 arasında bir değer giriniz!");
            continue;
    }
}

void addContact()
{
    firstName = Methods.readConsole("Lütfen isim giriniz: ");
    surname = Methods.readConsole("Lütfen soyisim giriniz: ");
    phone = Methods.readConsole("Lütfen telefon numarası giriniz: ");

    Contacts contact = new Contacts(contactList.Count > 0 ? contactList.Last().Id++ : 1, firstName, surname, phone, false);
    contactList.Add(contact);
    Console.WriteLine("Kişi rehbere eklenmiştir.");
}

void deleteContact()
{
    listContact();
    if (contactList.Count > 0)
    {
        deleteName = Methods.readConsole("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        Contacts contact = contactList.Find(x => x.FirstName == deleteName)!;
        Contacts contact1 = contactList.Find(x => x.Surname == deleteName)!;
        if (contact != null || contact1 != null)
        {
            string confirm;
            Console.WriteLine(deleteName + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (E/H)");
            confirm = Console.ReadLine()!.ToUpper();
            if (confirm == "E")
            {
                contactList.Remove(contact!);
                contactList.Remove(contact1);
                Console.WriteLine("Kişi rehberden silinmiştir.");
            }
            else
            {
                deleteContact();
            }
        }
        else
        {
            string select = Methods.readConsole("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");

            switch (select)
            {
                case "1":
                    Methods.exit();
                    break;
                case "2":
                    deleteContact();
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ya da 2 değerlerinden birini giriniz.");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("Rehberde uygun veri bulunamamıştır");
        deleteContact();
    }

}

void updateContact()
{
    listContact();
    if (contactList.Count > 0)
    {
        id = int.Parse(Methods.readConsole("Lütfen güncellemek istediğiniz kaydın ID numarasını giriniz: "));
        Contacts contact = contactList.Find(x => x.Id == id)!;

        if (contact != null)
        {
            contact.FirstName = Methods.readConsole("Yeni İsim: ");
            contact.Surname = Methods.readConsole("Yeni Soyisim: ");
            contact.Phone = Methods.readConsole("Yeni Telefon Numarası: ");
            status = Methods.readConsole("Tamamlandı mı? (E/H)").ToUpper();
            contact.IsCompleted = status == "E" ? true : false;
            Console.WriteLine("Kayıt güncellendi");
        }
        else
        {
            string select = Methods.readConsole("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Güncellemeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");

            switch (select)
            {
                case "1":
                    Methods.exit();
                    break;
                case "2":
                    updateContact();
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ya da 2 değerlerinden birini giriniz.");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("Rehberde uygun veri bulunamamıştır");
        updateContact();
    }
}

void listContact()
{
    if (contactList.Count > 0)
    {
        /*
        Console.WriteLine("ID\tİSİM\tSOYİSİM\tTELEFON NUMARASI\tDURUM");
        foreach (var contact in contactList)
        {
            Console.WriteLine(contact.Id+"\t"+contact.FirstName+"\t"+contact.Surname+"\t"+contact.Phone+"\t\t"+contact.IsCompleted);
        }
        */
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("*****************************************");
        foreach (var contact in contactList)
        {
            Console.WriteLine("İsim: " + contact.FirstName + "\n" + "Soyisim: " + contact.Surname + "\n" + "Telefon Numarası: " + contact.Phone);
            Console.WriteLine("-");
        }
    }
    else
    {
        Console.WriteLine("Kişi bulunamadı!");
    }
}

void searchContact()
{
    type = Methods.readConsole("Arama yapmak istediğiniz tipi seçiniz:\nİsme göre arama yapmak için: (1)\nSoyisme göre arama yapmak için: (2)\nTelefon numarasına göre arama yapmak için: (3)");

    switch (type)
    {
        case "1":
            getName();
            break;
        case "2":
            getSurname();
            break;
        case "3":
            getPhone();
            break;
        default:
            Console.WriteLine("Lütfen 1-3 arasında bir değer giriniz.");
            break;
    }
}

void getName()
{
    firstName = Methods.readConsole("Lütfen aramak istediğiniz ismi giriniz: ");
    foreach (var contact in contactList)
    {
        if (contact.FirstName == firstName)
        {
            Console.WriteLine("İsim: " + contact.FirstName + "\n" + "Soyisim: " + contact.Surname + "\n" + "Telefon Numarası: " + contact.Phone);
            Console.WriteLine("-");
        }
    }
}

void getSurname()
{
    surname = Methods.readConsole("Lütfen aramak istediğiniz telefon numarasını giriniz: ");
    foreach (var contact in contactList)
    {
        if (contact.Surname == surname)
        {
            Console.WriteLine("İsim: " + contact.FirstName + "\n" + "Soyisim: " + contact.Surname + "\n" + "Telefon Numarası: " + contact.Phone);
            Console.WriteLine("-");
        }
    }
}

void getPhone()
{
    phone = Methods.readConsole("Lütfen aramak istediğiniz telefon numarasını giriniz: ");
    foreach (var contact in contactList)
    {
        if (contact.Phone == phone)
        {
            Console.WriteLine("İsim: " + contact.FirstName + "\n" + "Soyisim: " + contact.Surname + "\n" + "Telefon Numarası: " + contact.Phone);
            Console.WriteLine("-");
        }
    }
}