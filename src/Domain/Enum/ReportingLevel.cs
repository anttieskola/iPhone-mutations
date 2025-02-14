namespace Mutations.Domain.Enum;

public enum ReportingLevel
{
    Verbose,    // Detailed information
    Info,       // General information
    Warning,    // Potential issues
    Error,      // Errors that don't stop execution
    Critical    // Errors that stop execution
}
