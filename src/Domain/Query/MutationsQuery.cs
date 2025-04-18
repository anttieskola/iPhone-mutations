namespace IPhoneMediaSync.Domain.Query;

public record MutationQuery : IRequest<IEnumerable<Mutation>>
{
    public required string SearchPath { get; set; }
}

public class MutationQueryHandler(
    IFileSystem fileSystem,
    IMutationFileSystem mutationFileSystem,
    ILogger<MutationQueryHandler> logger,
    IReporting reporting) : IRequestHandler<MutationQuery, IEnumerable<Mutation>>
{
    private readonly IFileSystem _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    private readonly IMutationFileSystem _mutationFileSystem = mutationFileSystem ?? throw new ArgumentNullException(nameof(mutationFileSystem));
    private readonly ILogger<MutationQueryHandler> _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    private readonly IReporting _reporting = reporting ?? throw new ArgumentNullException(nameof(reporting));

    public async Task<IEnumerable<Mutation>> Handle(MutationQuery request, CancellationToken cancellationToken)
    {
        // check search path
        var searchPath = _fileSystem.Path.GetFullPath(request.SearchPath);
        if (!_fileSystem.Directory.Exists(searchPath))
        {
            var errorMessage = $"Mutations directory not found: {searchPath}";
            _logger.LogCritical("Fatal error: {Message}", errorMessage);
            _reporting.Report(errorMessage, ReportingLevel.Critical);
            throw new DirectoryNotFoundException(errorMessage);
        }
        // find mutations and return
        var mutations = await _mutationFileSystem.SearchMutations(searchPath);
        return mutations;
    }
}