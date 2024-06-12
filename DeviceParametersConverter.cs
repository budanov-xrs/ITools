// Decompiled with JetBrains decompiler
// Type: IToolS.IOServers.BandR.DeviceParametersConverter
// Assembly: IToolS.IOServers.BandR, Version=3.5.58.1, Culture=neutral, PublicKeyToken=null
// MVID: 25819E46-7C08-4154-BEE2-2DB3D3974551
// Assembly location: C:\Users\ss_six\Desktop\FXE\FXE software integration package\COMET_FXE-PVIServices_Example\Pluto-PVI-trial_01\packages\IToolS.BandR.3.5.58\lib\net20\IToolS.IOServers.BandR.dll

using BR.AN.PviServices;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace IToolS.IOServers.BandR
{
  public class DeviceParametersConverter : StringConverter
  {
    private Dictionary<DeviceType, string> a;

    public DeviceParametersConverter()
    {
      this.a = new Dictionary<DeviceType, string>();
      this.a.Add(DeviceType.Serial, "/IF=COM1 /BD=57600 /PA=2 /IT=1");
      this.a.Add(DeviceType.Can, "/IF=INACAN1 /BD=500000 /BI=1598 /CT=10 /MC=10 /IO=900 /IR=10 /SA=1 /CNO=0 /IT=150");
      this.a.Add(DeviceType.TcpIp, "/IF=TCPIP /SA=1");
      this.a.Add(DeviceType.Shared, "/IF=LS251_1");
      this.a.Add(DeviceType.Modem, "/IF=MODEM /MO='' /TN='' /IT=40 /RI=60 /MR=INFINITE");
    }

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
    {
      short num1 = 30198;
      int num2 = (int) num1;
      num1 = (short) 30198;
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
          return true;
        default:
          goto case 1;
      }
    }

    public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
    {
      short num1 = 22265;
      int num2 = (int) num1;
      num1 = (short) 22265;
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
          return false;
        default:
          goto case 1;
      }
    }

    public override TypeConverter.StandardValuesCollection GetStandardValues(
      ITypeDescriptorContext context)
    {
      short num1 = -5660;
      int num2 = (int) num1;
      num1 = (short) -5660;
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
          return new TypeConverter.StandardValuesCollection((ICollection) this.a.Values);
        default:
          goto case 1;
      }
    }
  }
}
