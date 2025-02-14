namespace Mutations.Domain.Interface;

public interface IMutationFileSystem
{
    public Task<IEnumerable<Mutation>> SearchMutations(string searchPath);
    public Task<bool> SaveMutation(Mutation mutation);
}
