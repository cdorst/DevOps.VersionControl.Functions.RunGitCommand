using static Common.Functions.RunCommandLineTool.CommandLineToolRunner;

namespace DevOps.VersionControl.Functions.RunGitCommand
{
    public static class GitCommandRunner
    {
        private const string git = nameof(git);

        public static void Git(string directory, string command, params string[] arguments)
            => Prompt(directory,
                tool: git,
                command,
                arguments);
    }
}
