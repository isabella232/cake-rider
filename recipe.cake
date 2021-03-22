#load nuget:?package=Cake.IntelliJ.Recipe&version=0.1.3

Environment.SetVariableNames();

BuildParameters.SetParameters(
  context: Context,
  buildSystem: BuildSystem,
  sourceDirectoryPath: "./rider",
  title: "Cake for Rider",
  repositoryName: "Cake-Rider",
  appVeyorProjectSlug: "Cake-Rider", // https://github.com/cake-contrib/Cake.Recipe/issues/816
  repositoryOwner: "cake-build",
  marketplaceId: "15729-cake-rider"
);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context);

Build.Run();
