public interface ICowRepository
{
    Cow? GetCowById(string id);
    IEnumerable<Cow> GetAllCows();
    void Add(Cow cow);
    void Update(Cow cow);
    void Delete(string id);
}