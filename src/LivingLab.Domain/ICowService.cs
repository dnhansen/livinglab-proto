public interface ICowService
{
    IEnumerable<Cow> GetAllCows();

    Cow? GetCowById(string id);

    void Add(Cow cow);

    void Update(Cow cow);

    void Delete(string id);
}