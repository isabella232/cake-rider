#load nuget:?package=Cake.IntelliJ.Recipe&version=0.1.5

Environment.SetVariableNames(
  githubTokenVariable: "GITHUB_PAT"
);

BuildParameters.SetParameters(
  context: Context,
  buildSystem: BuildSystem,
  sourceDirectoryPath: "./src/rider",
  title: "Cake for Rider",
  repositoryName: "Cake-Rider",
  repositoryOwner: "cake-build",
  marketplaceId: "15729-cake-rider",
  webLinkRoot: "", // do *not* create a virtual directory for wyam docs. This setting will break gh-pages. (But work for preview)
  wyamConfigurationFile: MakeAbsolute((FilePath)"docs/wyam.config"),
  preferredBuildProviderType: BuildProviderType.GitHubActions,
  preferredBuildAgentOperatingSystem: PlatformFamily.Linux
);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context);

Build.Run();
