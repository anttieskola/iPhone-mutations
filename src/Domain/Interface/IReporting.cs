namespace Mutations.Domain.Interface;

public interface IReporting
{
    void Report(string message, ReportingLevel level = ReportingLevel.Info);
    void ReportProgress(string message, int progressPercentage);
    bool IsVerboseEnabled { get; }
}
