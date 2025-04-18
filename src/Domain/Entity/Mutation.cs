namespace IPhoneMediaSync.Domain.Entity;

/**
 * The mutation entity.
 */
public record Mutation
{
    /**
     * The current complete path of the mutation.
    */
    public required string CompletePath { get; set; }

    /**
     * The folder name example APPLE001
    */
    public required string FolderName { get; set; }

    /**
     * The original name of the picture or video
     * for example IMG_2026.jpg or IMG_2026.MOV
     */
    public required string OriginalName { get; set; }
}
