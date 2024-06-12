// Decompiled with JetBrains decompiler
// Type: hj
// Assembly: IToolS.IOServers.BandR, Version=3.5.58.1, Culture=neutral, PublicKeyToken=null
// MVID: 25819E46-7C08-4154-BEE2-2DB3D3974551
// Assembly location: C:\Users\ss_six\Desktop\FXE\FXE software integration package\COMET_FXE-PVIServices_Example\Pluto-PVI-trial_01\packages\IToolS.BandR.3.5.58\lib\net20\IToolS.IOServers.BandR.dll

using System;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class hj
{
  internal static uint a(string s)
  {
    int num1 = 0;
    short num2;
    uint num3;
    while (true)
    {
      int index;
      switch (num1)
      {
        case 0:
label_1:
          switch (0)
          {
            case 0:
              break;
            default:
              continue;
          }
          break;
        case 1:
          if (index >= s.Length)
          {
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          num3 = (uint) (((int) s[index] ^ (int) num3) * 16777619);
          ++index;
          num2 = (short) 2698;
          int num4 = (int) num2;
          num2 = (short) 2698;
          int num5 = (int) num2;
          switch (num4 == num5 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_1;
            default:
              num2 = (short) 0;
              if (num2 == (short) 0)
                ;
              num2 = (short) 5;
              num1 = (int) (IntPtr) num2;
              continue;
          }
        case 2:
          goto label_12;
        case 3:
        case 5:
          num2 = (short) 1;
          num1 = (int) (IntPtr) num2;
          continue;
        case 4:
          num3 = 2166136261U;
          index = 0;
          num2 = (short) 3;
          num1 = (int) (IntPtr) num2;
          continue;
      }
      num2 = (short) 0;
      if (s != null)
      {
        num2 = (short) 4;
        num1 = (int) (IntPtr) num2;
      }
      else
        break;
    }
label_12:
    num2 = (short) 1;
    if (num2 == (short) 0)
      ;
    return num3;
  }
}
