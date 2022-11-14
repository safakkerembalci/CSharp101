
internal class Contacts
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public bool IsCompleted { get; set; }

    public Contacts(int id, string firstName, string surname, string phone, bool isCompleted)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.Surname = surname;
        this.Phone = phone;
        this.IsCompleted = isCompleted;
    }
}