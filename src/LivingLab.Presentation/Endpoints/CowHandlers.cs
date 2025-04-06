public class CowHandlers
{
    private readonly ICowService _cowService;

    public CowHandlers(ICowService cowService) => _cowService = cowService;

    public IEnumerable<Cow> GetAllCows() => _cowService.GetAllCows();

    public Cow? GetCowById(string id) => _cowService.GetCowById(id);

    public void Add(string id, string race)
    {
        _cowService.Add(new Cow(id, race));
    }

    public void Update(string id, string race) => _cowService.Update(new Cow(id, race));

    public void Delete(string id) => _cowService.Delete(id);
}