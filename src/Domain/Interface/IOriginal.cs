namespace IPhoneMediaSync.Domain.Interface;

/**
 * All mutations must implement this interface.
 */
public interface IOriginal
{
    /**
     * The type of mutation.
     */
    public MutationType MutationType { get; init; }
    /**
     * The folder where the mutation will be saved.
     */
    public string OutputFolder { get; init; }
    /**
     * The name of the mutation file.
     */
    public string Output { get; init; }
    /**
     * The full path of the mutation (just combination of OutputFolder and Output).
     */
    public string OutputFullPath => Path.Combine(OutputFolder, Output);
}
