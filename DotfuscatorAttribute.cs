// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: IToolS.IOServers.BandR, Version=3.5.58.1, Culture=neutral, PublicKeyToken=null
// MVID: 25819E46-7C08-4154-BEE2-2DB3D3974551
// Assembly location: C:\Users\ss_six\Desktop\FXE\FXE software integration package\COMET_FXE-PVIServices_Example\Pluto-PVI-trial_01\packages\IToolS.BandR.3.5.58\lib\net20\IToolS.IOServers.BandR.dll

using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly)]
[ComVisible(false)]
public sealed class DotfuscatorAttribute : Attribute
{
    private string a;
    private int c;

    public DotfuscatorAttribute(string a, int c)
    {
        DotfuscatorAttribute dotfuscatorAttribute = this;
        this.a = a;
        this.c = c;
    }

    public string A 
    { 
        get => a; 
        set => a = value; 
    }

    public int C
    {
        get => c;
        set => c = value;
    }
}
