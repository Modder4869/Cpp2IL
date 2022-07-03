﻿namespace Cpp2IL.Plugin.BuildReport.Model;

public class OutputMethodData
{
    public string FullName { get; set; }
    public int MachineCodeSizeBytes { get; set; }
    public string? NonGenericVersionFullName { get; set; }
    public bool IsRemovedByGenericSharing { get; set; }
}