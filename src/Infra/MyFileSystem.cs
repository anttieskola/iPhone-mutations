
namespace IPhoneMediaSync.Infra;

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

        // Mutations path: /Photodata/Mutations/102APPLE/IMG_3942/Adjustements/FullSizeRender.heic


        return await Task.FromResult(new List<Mutation>());
    }
}
