namespace Mutations.Domain.Entity;

/**
* The original picture entity, created from mutations.
*/
public record Picture : IOriginal
{
    /**@inheritdoc*/
    public MutationType MutationType { get; init; } = MutationType.Picture;
    /**@inheritdoc*/
    public string OutputFolder { get; init; }
    /**@inheritdoc*/
    public string Output { get; init; }

    /**
    * Constructor for the OriginalPicture entity.
    * @param outputFolder The folder where the mutation will be saved.
    * @param output The name of the mutation file.
    */
    public Picture(string outputFolder, string output)
    {
        OutputFolder = outputFolder;
        Output = output;
    }
}
