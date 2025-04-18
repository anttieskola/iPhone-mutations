using IPhoneMediaSync.Infra;

namespace IPhoneMediaSync.Test.Infra;

public class MyFileSystemTests
{
    [Fact]
    public async Task MutationPathErrorsAsync()
    {
        // Arrange
        var fs = new MyFileSystem();

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentNullException>(async () =>
        {
            await fs.SearchMutations(string.Empty);
        });

        await Assert.ThrowsAsync<DirectoryNotFoundException>(async () =>
        {
            await fs.SearchMutations("/notfound");
        });
    }
}

