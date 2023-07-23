using System;
using Nuke.Common;
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

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Parameter("API base URL")] string ApiBaseUrl = "https://api.aspose.cloud";

    [Parameter("Client ID")] string ClientId = "email.cloud";
    [Parameter("Client Secret")] string ClientSecret = "email.cloud";

    [Solution] Solution Solution = null!;

    Target Test => _ => _
        .Executes(() =>
        {
            var testProject = Solution.GetProject("Aspose.Email-Cloud.Tests") ?? throw new Exception("Test project not found");
            return DotNetTest(_ => _
                .SetProjectFile(testProject.Path)
                .SetFilter("TestCategory=Pipeline")
                .SetProcessWorkingDirectory(testProject.Directory)
                .SetProcessEnvironmentVariable("clientId", ClientId)
                .SetProcessEnvironmentVariable("clientSecret", ClientSecret)
                .SetProcessEnvironmentVariable("apiBaseUrl", ApiBaseUrl));
        });

}