using static Common.Functions.JoinCommandLineArguments.CommandLineArgumentsJoiner;
using static Common.Functions.RunCommandLine.CommandLineRunner;

namespace DevOps.VersionControl.Functions.RunGitCommand
{
    public static class GitCommandRunner
    {
        private const string git = nameof(git);

        public static void Git(string directory, string command, params string[] arguments)
            => Run(directory,
                command: git,
                arguments: Join(command, arguments));
    }
}
