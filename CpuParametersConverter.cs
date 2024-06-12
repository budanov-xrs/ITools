// Decompiled with JetBrains decompiler
// Type: IToolS.IOServers.BandR.CpuParametersConverter
// Assembly: IToolS.IOServers.BandR, Version=3.5.58.1, Culture=neutral, PublicKeyToken=null
// MVID: 25819E46-7C08-4154-BEE2-2DB3D3974551
// Assembly location: C:\Users\ss_six\Desktop\FXE\FXE software integration package\COMET_FXE-PVIServices_Example\Pluto-PVI-trial_01\packages\IToolS.BandR.3.5.58\lib\net20\IToolS.IOServers.BandR.dll

using BR.AN.PviServices;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace IToolS.IOServers.BandR
{
  public class CpuParametersConverter : StringConverter
  {
    private Dictionary<DeviceType, string> a;

    public CpuParametersConverter()
    {
      this.a = new Dictionary<DeviceType, string>();
      this.a.Add(DeviceType.Serial, "");
      this.a.Add(DeviceType.Can, "/DA=2");
      this.a.Add(DeviceType.TcpIp, "/DA=2");
      this.a.Add(DeviceType.Shared, "");
      this.a.Add(DeviceType.Modem, "/RT=990");
    }

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
    {
      short num1 = 1;
      if (num1 == (short) 0)
        ;
      num1 = (short) 5014;
      int num2 = (int) num1;
      num1 = (short) 5014;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          num1 = (short) 0;
          if (num1 == (short) 0)
            ;
          num1 = (short) 0;
          return true;
        default:
          goto case 1;
      }
    }

    public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
    {
      short num1 = 1710;
      int num2 = (int) num1;
      num1 = (short) 1710;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          short num4 = 0;
          if (num4 == (short) 0)
            ;
          num4 = (short) 1;
          if (num4 == (short) 0)
            ;
          num4 = (short) 0;
          return false;
        default:
          goto case 1;
      }
    }

    public override TypeConverter.StandardValuesCollection GetStandardValues(
      ITypeDescriptorContext context)
    {
      short num1 = 19360;
      int num2 = (int) num1;
      num1 = (short) 19360;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          short num4 = 1;
          if (num4 == (short) 0)
            ;
          num4 = (short) 0;
          if (num4 == (short) 0)
            ;
          num4 = (short) 0;
          return new TypeConverter.StandardValuesCollection((ICollection) this.a.Values);
        default:
          goto case 1;
      }
    }
  }
}
