param($rootPath, $toolsPath, $package, $project)

Write-Host Setting MRLib items CopyToOutputDirectory=true
$project.ProjectItems.Item("MRLib").ProjectItems.Item("Microsoft.Hadoop.CombineDriver.exe").Properties.Item("CopyToOutputDirectory").Value = 1
$project.ProjectItems.Item("MRLib").ProjectItems.Item("Microsoft.Hadoop.MapDriver.exe").Properties.Item("CopyToOutputDirectory").Value = 1
$project.ProjectItems.Item("MRLib").ProjectItems.Item("Microsoft.Hadoop.ReduceDriver.exe").Properties.Item("CopyToOutputDirectory").Value = 1
$project.ProjectItems.Item("MRLib").ProjectItems.Item("Microsoft.Hadoop.MapReduce.dll").Properties.Item("CopyToOutputDirectory").Value = 1
$project.ProjectItems.Item("MRLib").ProjectItems.Item("MRRunner.exe").Properties.Item("CopyToOutputDirectory").Value = 1

Write-Host Post-install complete.

