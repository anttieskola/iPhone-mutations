
namespace Mutations.Infra;

public class MyFileSystem : IMutationFileSystem
{
    public Task<bool> SaveMutation(Mutation mutation) => throw new NotImplementedException();
    public async Task<IEnumerable<Mutation>> SearchMutations(string searchPath)
    {
        if (string.IsNullOrWhiteSpace(searchPath))
        {
            throw new ArgumentNullException(nameof(searchPath));
        }
        if (!Directory.Exists(searchPath))
        {
            throw new DirectoryNotFoundException($"Directory not found: {searchPath}");
        }
        return await Task.FromResult(new List<Mutation>());
    }
}
