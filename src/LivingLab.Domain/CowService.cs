public class CowService : ICowService
{
    private readonly ICowRepository _cowRepository;

    public CowService(ICowRepository cowRepository) => _cowRepository = cowRepository;

    public IEnumerable<Cow> GetAllCows() => _cowRepository.GetAllCows();

    public Cow? GetCowById(string id) => _cowRepository.GetCowById(id);

    public void Add(Cow cow)
    {
        _cowRepository.Add(cow);
    }
    
    public void Update(Cow cow) => _cowRepository.Update(cow);

    public void Delete(string id) => _cowRepository.Delete(id);
}