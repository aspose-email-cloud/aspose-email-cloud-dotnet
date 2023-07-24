using System;
using System.IO;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

namespace Builder;

class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Test);

    [Parameter("API base URL")] public string ApiBaseUrl = "https://api.aspose.cloud";

    [Parameter("Client ID")] public string ClientId = "email.cloud";
    [Parameter("Client Secret")] public string ClientSecret = "email.cloud";
    
    [Parameter("NuGet API key")] public string? NuGetApiKey;

    [Solution] public Solution Solution = null!;

    AbsolutePath BuildOut => Solution.Directory / "build_out";

    Target Test => _ => _
        .Executes(() =>
        {
            var testProject = Solution.GetProject($"{Solution.Name}.Tests") ?? throw new Exception("Test project not found");
            DotNetTest(__ => __
                .SetProjectFile(testProject.Path)
                .SetFilter("TestCategory=Pipeline")
                .SetProcessWorkingDirectory(testProject.Directory)
                .SetConfiguration(Configuration.Debug)
                .SetProcessEnvironmentVariable("clientId", ClientId)
                .SetProcessEnvironmentVariable("clientSecret", ClientSecret)
                .SetProcessEnvironmentVariable("apiBaseUrl", ApiBaseUrl));
        });

    Target Pack => _ => _
        .DependsOn(Test)
        .Executes(() => DotNetPack(__ => __
            .SetProject(Solution.GetProject(Solution.Name))
            .SetConfiguration(Configuration.Release)
            .SetOutputDirectory(BuildOut)));

    [UsedImplicitly]
    Target Deploy => _ => _
        .DependsOn(Pack)
        .Requires(() => NuGetApiKey != null)
        .Executes(() =>
        {
            var version = GetVersionString();
            var package = BuildOut / $"{Solution.Name}.{version}.nupkg";
            Assert.True(File.Exists(package), $"Package file with version {version} not found");
            DotNetNuGetPush(__ => __
                .SetApiKey(NuGetApiKey)
                .SetSource("nuget.org")
                .SetTargetPath(package));
        });

    string GetVersionString()
    {
        var project = Solution.GetProject(Solution.Name);
        var version = new Version(project.GetProperty("Version") ?? $"{DateTime.Today.Year}.{DateTime.Today.Month}.0");
        var fieldCount = version.Revision == 0 ? 3 : 4;
        return version.ToString(fieldCount);
    }
}