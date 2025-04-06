public class InMemoryCowRepository : ICowRepository
{
    private readonly List<Cow> _cows = new()
    {
        new("0001", "HOL"),
        new("0002", "HOL"),
        new("0003", "KRY"),
        new("0004", "HOL"),
        new("0005", "KRY"),
    };

    public Cow? GetCowById(string id) => _cows.FirstOrDefault(cow => cow.Id == id);

    public IEnumerable<Cow> GetAllCows() => _cows;

    public void Add(Cow cow)
    {
        string id = cow.Id;
        if (_cows.Any(c => c.Id == id))
        {
            throw new InvalidOperationException("A product with this ID already exists.");
        }

        _cows.Add(cow);
    }

    public void Update(Cow cow)
    {
        string id = cow.Id;
        Cow? existing = _cows.FirstOrDefault(c => c.Id == id);
        
        if (existing != null) _cows.Remove(existing);
        _cows.Add(cow);
    }

    public void Delete(string id)
    {
        Cow? existing = _cows.FirstOrDefault(c => c.Id == id);

        if (existing != null) _cows.Remove(existing);
    }
}