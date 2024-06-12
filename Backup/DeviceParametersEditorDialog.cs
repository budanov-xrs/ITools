// Decompiled with JetBrains decompiler
// Type: IToolS.IOServers.BandR.DeviceParametersEditorDialog
// Assembly: IToolS.IOServers.BandR, Version=3.5.58.1, Culture=neutral, PublicKeyToken=null
// MVID: 25819E46-7C08-4154-BEE2-2DB3D3974551
// Assembly location: C:\Users\ss_six\Desktop\FXE\FXE software integration package\COMET_FXE-PVIServices_Example\Pluto-PVI-trial_01\packages\IToolS.BandR.3.5.58\lib\net20\IToolS.IOServers.BandR.dll

using BR.AN.PviServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace IToolS.IOServers.BandR
{
  public class DeviceParametersEditorDialog : UserControl
  {
    private Dictionary<DeviceType, string> a;
    private IContainer b;
    private ListView c;
    private ColumnHeader d;
    private ColumnHeader e;

    public DeviceParametersEditorDialog()
    {
      this.a();
      this.a = new Dictionary<DeviceType, string>();
      this.a.Add(DeviceType.Serial, "/IF=COM1 /BD=57600 /PA=2 /IT=1");
      this.a.Add(DeviceType.Can, "/IF=INACAN1 /BD=500000 /BI=1598 /CT=10 /MC=10 /IO=900 /IR=10 /SA=1 /CNO=0 /IT=150");
      this.a.Add(DeviceType.TcpIp, "/IF=TCPIP /SA=1");
      this.a.Add(DeviceType.Shared, "/IF=LS251_1");
      this.a.Add(DeviceType.Modem, "/IF=MODEM /MO='' /TN='' /IT=40 /RI=60 /MR=INFINITE");
      foreach (DeviceType key in this.a.Keys)
        this.c.Items.Add(new ListViewItem(new string[2]
        {
          key.ToString(),
          this.a[key]
        })
        {
          Tag = (object) key
        });
    }

    public DeviceParametersEditorDialog(string value)
      : this()
    {
      foreach (ListViewItem listViewItem in this.c.Items)
      {
        if (listViewItem.SubItems[1].Text == value)
        {
          listViewItem.Selected = true;
          break;
        }
      }
    }

    public string Value
    {
      get
      {
        while (this.c.SelectedItems.Count > 0)
        {
          short num1 = 32752;
          int num2 = (int) num1;
          num1 = (short) 32752;
          int num3 = (int) num1;
          switch (num2 == num3 ? 1 : 0)
          {
            case 0:
            case 2:
              continue;
            case 1:
              num1 = (short) 1;
              if (num1 == (short) 0)
                ;
              num1 = (short) 0;
              if (num1 == (short) 0)
                ;
              return this.c.SelectedItems[0].SubItems[1].Text;
            default:
              num1 = (short) 0;
              goto case 1;
          }
        }
        return "";
      }
    }

    protected override void Dispose(bool disposing)
    {
label_0:
      short num1 = 0;
      num1 = (short) 2;
      int num2 = (int) (IntPtr) num1;
      while (true)
      {
        switch (num2)
        {
          case 0:
            goto label_12;
          case 1:
            num1 = (short) 3;
            num2 = (int) (IntPtr) num1;
            continue;
          case 2:
            num1 = (short) 1;
            if (num1 == (short) 0)
              ;
            switch (0)
            {
              case 0:
                break;
              default:
                continue;
            }
            break;
          case 3:
            if (this.b != null)
            {
              num1 = (short) 4;
              num2 = (int) (IntPtr) num1;
              continue;
            }
            goto label_12;
          case 4:
            this.b.Dispose();
            num1 = (short) 0;
            num2 = (int) (IntPtr) num1;
            continue;
        }
        if (disposing)
        {
          num1 = (short) -21827;
          int num3 = (int) num1;
          num1 = (short) -21827;
          int num4 = (int) num1;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_0;
            default:
              num1 = (short) 0;
              if (num1 == (short) 0)
                ;
              num1 = (short) 1;
              num2 = (int) (IntPtr) num1;
              continue;
          }
        }
        else
          break;
      }
label_12:
      base.Dispose(disposing);
    }

    private void a()
    {
      short num1 = -20708;
      int num2 = (int) num1;
      num1 = (short) -20708;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          short num4 = 0;
          num4 = (short) 0;
          if (num4 == (short) 0)
            ;
          num4 = (short) 1;
          if (num4 == (short) 0)
            ;
          this.c = new ListView();
          this.d = new ColumnHeader();
          this.e = new ColumnHeader();
          this.SuspendLayout();
          this.c.Columns.AddRange(new ColumnHeader[2]
          {
            this.d,
            this.e
          });
          this.c.Dock = DockStyle.Fill;
          this.c.FullRowSelect = true;
          this.c.GridLines = true;
          this.c.HeaderStyle = ColumnHeaderStyle.Nonclickable;
          this.c.HideSelection = false;
          this.c.Location = new Point(0, 0);
          this.c.MultiSelect = false;
          this.c.Name = "listView1";
          this.c.Size = new Size(342, 224);
          this.c.TabIndex = 0;
          this.c.UseCompatibleStateImageBehavior = false;
          this.c.View = View.Details;
          this.d.Text = "Type";
          this.d.Width = 90;
          this.e.Text = "Parameters";
          this.e.Width = 200;
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.Controls.Add((Control) this.c);
          this.Name = nameof (DeviceParametersEditorDialog);
          this.Size = new Size(300, 224);
          this.ResumeLayout(false);
          break;
        default:
          goto case 1;
      }
    }
  }
}
