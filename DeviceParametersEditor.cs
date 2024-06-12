// Decompiled with JetBrains decompiler
// Type: IToolS.IOServers.BandR.DeviceParametersEditor
// Assembly: IToolS.IOServers.BandR, Version=3.5.58.1, Culture=neutral, PublicKeyToken=null
// MVID: 25819E46-7C08-4154-BEE2-2DB3D3974551
// Assembly location: C:\Users\ss_six\Desktop\FXE\FXE software integration package\COMET_FXE-PVIServices_Example\Pluto-PVI-trial_01\packages\IToolS.BandR.3.5.58\lib\net20\IToolS.IOServers.BandR.dll

using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace IToolS.IOServers.BandR
{
  public class DeviceParametersEditor : UITypeEditor
  {
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
      short num1 = 22044;
      int num2 = (int) num1;
      num1 = (short) 22044;
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
          return UITypeEditorEditStyle.DropDown;
        default:
          goto case 1;
      }
    }

    public override bool IsDropDownResizable
    {
      get
      {
        short num1 = 3241;
        int num2 = (int) num1;
        num1 = (short) 3241;
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
            return true;
          default:
            goto case 1;
        }
      }
    }

    public override object EditValue(
      ITypeDescriptorContext context,
      IServiceProvider provider,
      object value)
    {
label_0:
      short num1 = 0;
      IWindowsFormsEditorService service = (IWindowsFormsEditorService) provider.GetService(typeof (IWindowsFormsEditorService));
      if (service == null)
        return value;
      num1 = (short) 29546;
      int num2 = (int) num1;
      num1 = (short) 29546;
      int num3 = (int) num1;
      switch (num2 == num3 ? 1 : 0)
      {
        case 0:
        case 2:
          goto label_0;
        default:
          num1 = (short) 1;
          if (num1 == (short) 0)
            ;
          num1 = (short) 0;
          if (num1 == (short) 0)
            ;
          DeviceParametersEditorDialog parametersEditorDialog = new DeviceParametersEditorDialog(Convert.ToString(value));
          service.DropDownControl((Control) parametersEditorDialog);
          return (object) parametersEditorDialog.Value;
      }
    }
  }
}
