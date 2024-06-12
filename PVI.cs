// Decompiled with JetBrains decompiler
// Type: IToolS.IOServers.BandR.PVI
// Assembly: IToolS.IOServers.BandR, Version=3.5.58.1, Culture=neutral, PublicKeyToken=null
// MVID: 25819E46-7C08-4154-BEE2-2DB3D3974551
// Assembly location: C:\Users\ss_six\Desktop\FXE\FXE software integration package\COMET_FXE-PVIServices_Example\Pluto-PVI-trial_01\packages\IToolS.BandR.3.5.58\lib\net20\IToolS.IOServers.BandR.dll

using BR.AN.PviServices;
using IToolS.Base;
using IToolS.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Threading;

namespace IToolS.IOServers.BandR
{
    [IOServerTypes(true, new Type[] { })]
    [IOServerManifest("IToolS.IOServers.BandR.BandRManifest.txt")]
    [IOServerFamily("BandR")]
    [IOServerName("PVI")]
    [IOServerArea(new string[] { ".*" })]
    public class PVI : MasterIOServerBase
    {
        private string a = "Service";
        private string b = "CPU";
        private Service c;
        private Cpu d;
        private Dictionary<string, PVI.a> e;
        private AutoResetEvent f = new AutoResetEvent(false);
        private DeviceType g = DeviceType.TcpIp;
        private string h;
        private string i;
        private SynchronizationContext j;
        internal const string k = "/IF=TCPIP /SA=1";
        internal const string l = "/DA=2";
        private bool m = true;
        private Dictionary<string, Dictionary<string, IVariableInternal>> n = new Dictionary<string, Dictionary<string, IVariableInternal>>();

        public PVI()
        {
            this.AllReadRequestInReadDataRequest = true;
            this.AllWriteRequestInWriteDataRequest = true;
            this.e = new Dictionary<string, PVI.a>();
            this.g = DeviceType.TcpIp;
            this.i = "/DA=2";
            this.h = "/IF=TCPIP /SA=1";
            this.j = SynchronizationContext.Current;
        }

        protected virtual void OnActivate(ActivateEventArgs e)
        {
            short num1 = 15734;
            int num2 = (int)num1;
            num1 = (short)15734;
            int num3 = (int)num1;
            switch (num2 == num3)
            {
                case true:
                    short num4 = 1;
                    if (num4 == (short)0)
                        break;
                    num4 = (short)0;
                    num4 = (short)0;
                    if (num4 == (short)0)
                        break;
                    base.OnActivate(e);
                    break;
                default:
                    break;
            }
        }

        private void _a(object A_0, VariableEventArgs A_1)
        {
            int num1;
            short num2;
            Variable variable;
            switch (0)
            {
                case 0:
                label_2:
                    num2 = (short)1;
                    if (num2 == (short)0)
                        ;
                    variable = (Variable)A_0;
                    num2 = (short)2;
                    num1 = (int)(IntPtr)num2;
                    goto default;
                default:
                    Dictionary<string, IVariableInternal>.ValueCollection.Enumerator enumerator;
                    while (true)
                    {
                        switch (num1)
                        {
                            case 0:
                                goto label_19;
                            case 1:
                                enumerator = this.n[variable.Address].Values.GetEnumerator();
                                num2 = (short)0;
                                num1 = (int)(IntPtr)num2;
                                continue;
                            case 2:
                                if (this.n.ContainsKey(variable.Address))
                                {
                                    num2 = (short)1;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                }
                                goto label_20;
                            default:
                                goto label_2;
                        }
                    }
                label_20:
                    break;
                label_19:
                    num2 = (short)0;
                label_6:
                    try
                    {
                        num2 = (short)1;
                        int num3 = (int)(IntPtr)num2;
                        while (true)
                        {
                            switch (num3)
                            {
                                case 1:
                                    switch (0)
                                    {
                                        case 0:
                                            break;
                                        default:
                                            continue;
                                    }
                                    break;
                                case 2:
                                    goto label_18;
                                case 3:
                                    num2 = (short)2;
                                    num3 = (int)(IntPtr)num2;
                                    continue;
                                case 4:
                                    if (!enumerator.MoveNext())
                                    {
                                        num2 = (short)3;
                                        num3 = (int)(IntPtr)num2;
                                        continue;
                                    }
                                    IVariableInternal current = enumerator.Current;
                                    current.Value = variable.Value.ToType(current.TypeBase.DotNetType, (IFormatProvider)CultureInfo.InvariantCulture);
                                    num2 = (short)-18575;
                                    int num4 = (int)num2;
                                    num2 = (short)-18575;
                                    int num5 = (int)num2;
                                    switch (num4 == num5 ? 1 : 0)
                                    {
                                        case 0:
                                        case 2:
                                            goto label_6;
                                        default:
                                            num2 = (short)0;
                                            if (num2 == (short)0)
                                                ;
                                            num2 = (short)0;
                                            num3 = (int)(IntPtr)num2;
                                            continue;
                                    }
                            }
                            num2 = (short)4;
                            num3 = (int)(IntPtr)num2;
                        }
                    label_18:
                        break;
                    }
                    finally
                    {
                        enumerator.Dispose();
                    }
            }
        }

        private void _e(object A_0, PviEventArgs A_1)
        {
            int num1;
            Variable variable;
            short num2;
            switch (0)
            {
                case 0:
                label_2:
                    variable = (Variable)A_0;
                    num2 = (short)2;
                    num1 = (int)(IntPtr)num2;
                    goto default;
                default:
                    Dictionary<string, IVariableInternal>.ValueCollection.Enumerator enumerator;
                    while (true)
                    {
                        switch (num1)
                        {
                            case 0:
                                goto label_17;
                            case 1:
                                enumerator = this.n[variable.Address].Values.GetEnumerator();
                                num2 = (short)0;
                                num1 = (int)(IntPtr)num2;
                                continue;
                            case 2:
                                if (this.n.ContainsKey(variable.Address))
                                {
                                    num2 = (short)1;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                }
                                goto label_20;
                            default:
                                goto label_2;
                        }
                    }
                label_20:
                    break;
                label_17:
                    num2 = (short)1;
                    if (num2 == (short)0)
                        ;
                    num2 = (short)0;
                label_5:
                    try
                    {
                        num2 = (short)1;
                        int num3 = (int)(IntPtr)num2;
                        while (true)
                        {
                            switch (num3)
                            {
                                case 1:
                                    switch (0)
                                    {
                                        case 0:
                                            break;
                                        default:
                                            continue;
                                    }
                                    break;
                                case 2:
                                    goto label_18;
                                case 3:
                                    num2 = (short)2;
                                    num3 = (int)(IntPtr)num2;
                                    continue;
                                case 4:
                                    if (!enumerator.MoveNext())
                                    {
                                        num2 = (short)3;
                                        num3 = (int)(IntPtr)num2;
                                        continue;
                                    }
                                    IVariableInternal current = enumerator.Current;
                                    current.Value = variable.Value.ToType(current.TypeBase.DotNetType, (IFormatProvider)CultureInfo.InvariantCulture);
                                    num2 = (short)13622;
                                    int num4 = (int)num2;
                                    num2 = (short)13622;
                                    int num5 = (int)num2;
                                    switch (num4 == num5 ? 1 : 0)
                                    {
                                        case 0:
                                        case 2:
                                            goto label_5;
                                        default:
                                            num2 = (short)0;
                                            if (num2 == (short)0)
                                                ;
                                            num2 = (short)0;
                                            num3 = (int)(IntPtr)num2;
                                            continue;
                                    }
                            }
                            num2 = (short)4;
                            num3 = (int)(IntPtr)num2;
                        }
                    label_18:
                        break;
                    }
                    finally
                    {
                        enumerator.Dispose();
                    }
            }
        }

        private void _d(object A_0, PviEventArgs A_1)
        {
            int num1 = 0;
            short num2;
            while (true)
            {
                Dictionary<string, IVariableInternal>.ValueCollection.Enumerator enumerator;
                Variable variable;
                switch (num1)
                {
                    case 0:
                        switch (0)
                        {
                            case 0:
                                goto label_3;
                            default:
                                continue;
                        }
                    case 1:
                        goto label_24;
                    case 2:
                        enumerator = this.n[variable.Address].Values.GetEnumerator();
                        num2 = (short)3;
                        num1 = (int)(IntPtr)num2;
                        continue;
                    case 3:
                        num2 = (short)0;
                    label_5:
                        try
                        {
                            num2 = (short)1;
                            int num3 = (int)(IntPtr)num2;
                            while (true)
                            {
                                switch (num3)
                                {
                                    case 1:
                                        switch (0)
                                        {
                                            case 0:
                                                break;
                                            default:
                                                continue;
                                        }
                                        break;
                                    case 2:
                                        goto label_19;
                                    case 3:
                                        num2 = (short)2;
                                        num3 = (int)(IntPtr)num2;
                                        continue;
                                    case 4:
                                        if (!enumerator.MoveNext())
                                        {
                                            num2 = (short)3;
                                            num3 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        enumerator.Current.State = (VariableState)3;
                                        num2 = (short)-32703;
                                        int num4 = (int)num2;
                                        num2 = (short)-32703;
                                        int num5 = (int)num2;
                                        switch (num4 == num5 ? 1 : 0)
                                        {
                                            case 0:
                                            case 2:
                                                goto label_5;
                                            default:
                                                num2 = (short)0;
                                                if (num2 == (short)0)
                                                    ;
                                                num2 = (short)0;
                                                num3 = (int)(IntPtr)num2;
                                                continue;
                                        }
                                }
                                num2 = (short)4;
                                num3 = (int)(IntPtr)num2;
                            }
                        }
                        finally
                        {
                            enumerator.Dispose();
                        }
                    case 4:
                        if (this.n.ContainsKey(variable.Address))
                        {
                            num2 = (short)2;
                            num1 = (int)(IntPtr)num2;
                            continue;
                        }
                        break;
                    case 5:
                        variable = (Variable)A_0;
                        num2 = (short)4;
                        num1 = (int)(IntPtr)num2;
                        continue;
                    default:
                    label_3:
                        if (A_1.ErrorCode != 0)
                        {
                            num2 = (short)5;
                            num1 = (int)(IntPtr)num2;
                            continue;
                        }
                        goto label_24;
                }
            label_19:
                Utilities.Logger((System.Exception)new IToolSException(string.Format("Error on connect variable address {0}: {1}", (object)variable.Address, (object)A_1.ErrorText)), (Utilities.LogType)1);
                num2 = (short)1;
                num1 = (int)(IntPtr)num2;
            }
        label_24:
            num2 = (short)1;
            if (num2 == (short)0)
                ;
        }

        protected virtual bool Connect()
        {
            int num1 = 1;
            short num2;
            while (true)
            {
                switch (num1)
                {
                    case 0:
                        num2 = (short)8;
                        num1 = (int)(IntPtr)num2;
                        continue;
                    case 1:
                        switch (0)
                        {
                            case 0:
                                break;
                            default:
                                continue;
                        }
                        break;
                    case 2:
                        if (!this.c.IsConnected)
                        {
                            num2 = (short)10;
                            num1 = (int)(IntPtr)num2;
                            continue;
                        }
                        goto case 6;
                    case 3:
                        goto label_6;
                    case 4:
                        if (this.d != null)
                        {
                            num2 = (short)5;
                            num1 = (int)(IntPtr)num2;
                            continue;
                        }
                        goto label_24;
                    case 5:
                        goto label_16;
                    case 6:
                        num2 = (short)7;
                        num1 = (int)(IntPtr)num2;
                        continue;
                    case 7:
                        if (this.d != null)
                        {
                            num2 = (short)0;
                            num1 = (int)(IntPtr)num2;
                            continue;
                        }
                        goto case 11;
                    case 8:
                        if (!this.d.IsConnected)
                        {
                            num2 = (short)9;
                            num1 = (int)(IntPtr)num2;
                            continue;
                        }
                        goto case 11;
                    case 9:
                        this.d.Remove();
                        this.d.Dispose();
                        this.d = (Cpu)null;
                        num2 = (short)11;
                        num1 = (int)(IntPtr)num2;
                        continue;
                    case 10:
                        this.c.Remove();
                        this.c.Dispose();
                        this.c = (Service)null;
                        num2 = (short)6;
                        num1 = (int)(IntPtr)num2;
                        continue;
                    case 11:
                        num2 = (short)4;
                        num1 = (int)(IntPtr)num2;
                        continue;
                }
                num2 = (short)1;
                if (num2 == (short)0)
                    ;
                if (this.j == null)
                {
                    num2 = (short)3;
                    num1 = (int)(IntPtr)num2;
                }
                else
                {
                    num2 = (short)4948;
                    int num3 = (int)num2;
                    num2 = (short)4948;
                    int num4 = (int)num2;
                    switch (num3 == num4 ? 1 : 0)
                    {
                        case 0:
                        case 2:
                            goto label_16;
                        default:
                            num2 = (short)0;
                            if (num2 == (short)0)
                                ;
                            this.c = new Service(this.ServiceName);
                            this.c.Timeout = this.TimeOut;
                            this.j.Send((SendOrPostCallback)(A_0 =>
                            {
                                try
                                {
                                    short num5 = 15058;
                                    int num6 = (int)num5;
                                    num5 = (short)15058;
                                    int num7 = (int)num5;
                                    switch (num6 == num7)
                                    {
                                        case true:
                                            short num8 = 0;
                                            if (num8 == (short)0)
                                                ;
                                            num8 = (short)1;
                                            if (num8 == (short)0)
                                                ;
                                            this.c.Error += new PviEventHandler(this.a);
                                            this.c.Connected += new PviEventHandler(this.c);
                                            this.c.Connect(this.NetConfig.Address, this.NetConfig.Port);
                                            break;
                                        default:
                                            goto case 1;
                                    }
                                }
                                catch (System.Exception ex)
                                {
                                    Utilities.Logger(ex, (Utilities.LogType)0);
                                    this.f.Set();
                                }
                            }), (object)null);
                            this.f.WaitOne(this.TimeOut);
                            num2 = (short)2;
                            num1 = (int)(IntPtr)num2;
                            continue;
                    }
                }
            }
        label_6:
            num2 = (short)0;
            throw new IToolSException("SynchronizationContext not found on PVI driver");
        label_16:
            return this.d.IsConnected;
        label_24:
            return false;
        }

        private void _c(object A_0, PviEventArgs A_1)
        {
        label_0:
            short num1 = 3;
            int num2 = (int)(IntPtr)num1;
            while (true)
            {
                switch (num2)
                {
                    case 0:
                        if (!this.c.IsConnected)
                        {
                            num1 = (short)1;
                            num2 = (int)(IntPtr)num1;
                            continue;
                        }
                        goto label_14;
                    case 1:
                        goto label_11;
                    case 2:
                        num1 = (short)1;
                        if (num1 == (short)0)
                            ;
                        num1 = (short)0;
                        num2 = (int)(IntPtr)num1;
                        continue;
                    case 3:
                        switch (0)
                        {
                            case 0:
                                break;
                            default:
                                continue;
                        }
                        break;
                }
                if (A_1.ErrorCode == 0)
                {
                    num1 = (short)0;
                    num1 = (short)2;
                    num2 = (int)(IntPtr)num1;
                }
                else
                    break;
            }
            return;
        label_11:
            num1 = (short)-846;
            int num3 = (int)num1;
            num1 = (short)-846;
            int num4 = (int)num1;
            switch (num3 == num4 ? 1 : 0)
            {
                case 0:
                case 2:
                    goto label_0;
                default:
                    num1 = (short)0;
                    if (num1 == (short)0)
                        ;
                    return;
            }
        label_14:
            this.d = new Cpu(this.c, this.CpuName);
            this.d.Connection.DeviceType = this.DeviceType;
            this.d.Connection.Device.UpdateCpuParameters(this.CpuParameters);
            this.d.Connection.Device.UpdateDeviceParameters(this.DeviceParameters);
            this.e.Clear();
            this.n.Clear();
            this.d.Connected += new PviEventHandler(this.b);
            this.d.Connect();
        }

        private void _b(object A_0, PviEventArgs A_1)
        {
            switch (0)
            {
                default:
                    int num1 = 1;
                    List<IGroupInternal>.Enumerator enumerator1;
                    while (true)
                    {
                        switch (num1)
                        {
                            case 0:
                                if (this.d.IsConnected)
                                {
                                    enumerator1 = ((List<IGroupInternal>)this.Groups).GetEnumerator();
                                    num1 = 3;
                                    continue;
                                }
                                num1 = 2;
                                continue;
                            case 1:
                                switch (0)
                                {
                                    case 0:
                                        break;
                                    default:
                                        continue;
                                }
                                break;
                            case 2:
                                goto label_46;
                            case 3:
                                goto label_41;
                            case 4:
                                num1 = 0;
                                continue;
                        }
                        if (A_1.ErrorCode == 0)
                            num1 = 4;
                        else
                            goto label_46;
                    }
                label_41:
                    if (false)
                        ;
                    try
                    {
                        int num2 = 1;
                        while (true)
                        {
                            short num3;
                            IEnumerator<IVariableInternal> enumerator2;
                            switch (num2)
                            {
                                case 0:
                                    try
                                    {
                                        num3 = (short)2;
                                        int num4 = (int)(IntPtr)num3;
                                        while (true)
                                        {
                                            IVariableInternal current;
                                            switch (num4)
                                            {
                                                case 1:
                                                    if (!((IEnumerator)enumerator2).MoveNext())
                                                    {
                                                        num3 = (short)10;
                                                        num4 = (int)(IntPtr)num3;
                                                        continue;
                                                    }
                                                    current = enumerator2.Current;
                                                    num3 = (short)9;
                                                    num4 = (int)(IntPtr)num3;
                                                    continue;
                                                case 2:
                                                    switch (0)
                                                    {
                                                        case 0:
                                                            break;
                                                        default:
                                                            continue;
                                                    }
                                                    break;
                                                case 3:
                                                    num3 = (short)6;
                                                    num4 = (int)(IntPtr)num3;
                                                    continue;
                                                case 4:
                                                    Variable variable = new Variable(this.d, current.VariableName);
                                                    variable.Address = current.Address;
                                                    variable.Active = this.UseEventsNotification;
                                                    Variable A_0_1 = variable;
                                                    this.e.Add(current.Address, new PVI.a(A_0_1, current));
                                                    A_0_1.ValueRead += new PviEventHandler(this.e);
                                                    A_0_1.ValueChanged += new VariableEventHandler(this.a);
                                                    A_0_1.Connected += new PviEventHandler(this.d);
                                                    A_0_1.Connect();
                                                    this.n.Add(current.Address, new Dictionary<string, IVariableInternal>());
                                                    num3 = (short)3;
                                                    num4 = (int)(IntPtr)num3;
                                                    continue;
                                                case 5:
                                                    goto label_9;
                                                case 6:
                                                    if (!this.n[current.Address].ContainsKey(current.VariableName))
                                                    {
                                                        this.n[current.Address].Add(current.VariableName, current);
                                                        num3 = (short)8;
                                                        num4 = (int)(IntPtr)num3;
                                                        continue;
                                                    }
                                                    num3 = (short)7;
                                                    num4 = (int)(IntPtr)num3;
                                                    continue;
                                                case 7:
                                                    Utilities.Logger("Duplicate variable name on PVI driver: " + current.VariableName, (Utilities.LogType)1);
                                                    num3 = (short)0;
                                                    num4 = (int)(IntPtr)num3;
                                                    continue;
                                                case 9:
                                                    if (!this.e.ContainsKey(current.Address))
                                                    {
                                                        num3 = (short)4;
                                                        num4 = (int)(IntPtr)num3;
                                                        continue;
                                                    }
                                                    goto case 3;
                                                case 10:
                                                    num3 = (short)5;
                                                    num4 = (int)(IntPtr)num3;
                                                    continue;
                                            }
                                        label_15:
                                            num3 = (short)32341;
                                            int num5 = (int)num3;
                                            num3 = (short)32341;
                                            int num6 = (int)num3;
                                            switch (num5 == num6 ? 1 : 0)
                                            {
                                                case 0:
                                                case 2:
                                                    goto label_15;
                                                default:
                                                    num3 = (short)0;
                                                    if (num3 == (short)0)
                                                        ;
                                                    num3 = (short)1;
                                                    num4 = (int)(IntPtr)num3;
                                                    continue;
                                            }
                                        }
                                    }
                                    finally
                                    {
                                        int num7 = 2;
                                        while (true)
                                        {
                                            switch (num7)
                                            {
                                                case 0:
                                                    goto label_36;
                                                case 1:
                                                    ((IDisposable)enumerator2).Dispose();
                                                    num7 = 0;
                                                    continue;
                                                case 2:
                                                    switch (0)
                                                    {
                                                        case 0:
                                                            break;
                                                        default:
                                                            continue;
                                                    }
                                                    break;
                                            }
                                            if (enumerator2 != null)
                                                num7 = 1;
                                            else
                                                break;
                                        }
                                    label_36:;
                                    }
                                case 1:
                                    switch (0)
                                    {
                                        case 0:
                                            break;
                                        default:
                                            continue;
                                    }
                                    break;
                                case 2:
                                    goto label_47;
                                case 3:
                                    num3 = (short)2;
                                    num2 = (int)(IntPtr)num3;
                                    continue;
                                case 4:
                                    if (!enumerator1.MoveNext())
                                    {
                                        num3 = (short)3;
                                        num2 = (int)(IntPtr)num3;
                                        continue;
                                    }
                                    enumerator2 = ((IEnumerable<IVariableInternal>)enumerator1.Current).GetEnumerator();
                                    num3 = (short)0;
                                    num2 = (int)(IntPtr)num3;
                                    continue;
                            }
                        label_9:
                            num3 = (short)4;
                            num2 = (int)(IntPtr)num3;
                        }
                    }
                    finally
                    {
                        enumerator1.Dispose();
                    }
                label_47:
                    this.f.Set();
                    break;
                label_46:
                    this.f.Set();
                    break;
            }
        }

        private void _a(object A_0, PviEventArgs A_1)
        {
            short num1 = -8836;
            int num2 = (int)num1;
            num1 = (short)-8836;
            int num3 = (int)num1;
            switch (num2 == num3)
            {
                case true:
                    short num4 = 0;
                    if (num4 == (short)0)
                        ;
                    num4 = (short)0;
                    num4 = (short)1;
                    if (num4 == (short)0)
                        ;
                    this.f.Set();
                    break;
                default:
                    goto case 1;
            }
        }

        protected virtual void Disconnect()
        {
            try
            {
                int num1;
                List<IGroupInternal>.Enumerator enumerator1;
                short num2;
                switch (0)
                {
                    case 0:
                    label_2:
                        enumerator1 = ((List<IGroupInternal>)this.Groups).GetEnumerator();
                        num2 = (short)2;
                        num1 = (int)(IntPtr)num2;
                        goto default;
                    default:
                        while (true)
                        {
                            switch (num1)
                            {
                                case 0:
                                    if (this.d.IsConnected)
                                    {
                                        num2 = (short)7;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    }
                                    goto case 6;
                                case 1:
                                    if (this.d != null)
                                    {
                                        num2 = (short)1;
                                        if (num2 == (short)0)
                                            ;
                                        num2 = (short)9;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    }
                                    goto case 13;
                                case 2:
                                    try
                                    {
                                        num2 = (short)4;
                                        int num3 = (int)(IntPtr)num2;
                                        while (true)
                                        {
                                            IEnumerator<IVariableInternal> enumerator2;
                                            switch (num3)
                                            {
                                                case 0:
                                                    goto label_51;
                                                case 1:
                                                    if (!enumerator1.MoveNext())
                                                    {
                                                        num2 = (short)2;
                                                        num3 = (int)(IntPtr)num2;
                                                        continue;
                                                    }
                                                    enumerator2 = ((IEnumerable<IVariableInternal>)enumerator1.Current).GetEnumerator();
                                                    num2 = (short)3;
                                                    num3 = (int)(IntPtr)num2;
                                                    continue;
                                                case 2:
                                                    num2 = (short)0;
                                                    num3 = (int)(IntPtr)num2;
                                                    continue;
                                                case 3:
                                                    try
                                                    {
                                                        num2 = (short)11;
                                                        int num4 = (int)(IntPtr)num2;
                                                        while (true)
                                                        {
                                                            IVariableInternal current;
                                                            switch (num4)
                                                            {
                                                                case 0:
                                                                    num2 = (short)6;
                                                                    num4 = (int)(IntPtr)num2;
                                                                    continue;
                                                                case 1:
                                                                    num2 = (short)9;
                                                                    num4 = (int)(IntPtr)num2;
                                                                    continue;
                                                                case 2:
                                                                    num2 = (short)3;
                                                                    num4 = (int)(IntPtr)num2;
                                                                    continue;
                                                                case 3:
                                                                    goto label_11;
                                                                case 4:
                                                                    if (this.e.ContainsKey(current.Address))
                                                                    {
                                                                        num2 = (short)7;
                                                                        num4 = (int)(IntPtr)num2;
                                                                        continue;
                                                                    }
                                                                    goto case 0;
                                                                case 6:
                                                                    if (this.n.ContainsKey(current.Address))
                                                                    {
                                                                        num2 = (short)1;
                                                                        num4 = (int)(IntPtr)num2;
                                                                        continue;
                                                                    }
                                                                    break;
                                                                case 7:
                                                                    this.e[current.Address].a.ValueChanged -= new VariableEventHandler(this.e);
                                                                    this.e.Remove(current.VariableName);
                                                                    num2 = (short)0;
                                                                    num4 = (int)(IntPtr)num2;
                                                                    continue;
                                                                case 8:
                                                                    if (((IEnumerator)enumerator2).MoveNext())
                                                                    {
                                                                        current = enumerator2.Current;
                                                                        num2 = (short)4;
                                                                        num4 = (int)(IntPtr)num2;
                                                                        continue;
                                                                    }
                                                                    num2 = (short)2;
                                                                    num4 = (int)(IntPtr)num2;
                                                                    continue;
                                                                case 9:
                                                                    if (this.n[current.Address].ContainsKey(current.VariableName))
                                                                    {
                                                                        num2 = (short)10;
                                                                        num4 = (int)(IntPtr)num2;
                                                                        continue;
                                                                    }
                                                                    break;
                                                                case 10:
                                                                    this.n[current.Address].Remove(current.VariableName);
                                                                    num2 = (short)5;
                                                                    num4 = (int)(IntPtr)num2;
                                                                    continue;
                                                                case 11:
                                                                    switch (0)
                                                                    {
                                                                        case 0:
                                                                            break;
                                                                        default:
                                                                            continue;
                                                                    }
                                                                    break;
                                                            }
                                                            num2 = (short)8;
                                                            num4 = (int)(IntPtr)num2;
                                                        }
                                                    }
                                                    finally
                                                    {
                                                        short num5 = 2;
                                                        int num6 = (int)(IntPtr)num5;
                                                        while (true)
                                                        {
                                                            switch (num6)
                                                            {
                                                                case 0:
                                                                    goto label_40;
                                                                case 1:
                                                                    num5 = (short)4709;
                                                                    int num7 = (int)num5;
                                                                    num5 = (short)4709;
                                                                    int num8 = (int)num5;
                                                                    switch (num7 == num8 ? 1 : 0)
                                                                    {
                                                                        case 0:
                                                                        case 2:
                                                                            goto label_40;
                                                                        default:
                                                                            num5 = (short)0;
                                                                            if (num5 == (short)0)
                                                                                ;
                                                                            ((IDisposable)enumerator2).Dispose();
                                                                            num5 = (short)0;
                                                                            num6 = (int)(IntPtr)num5;
                                                                            continue;
                                                                    }
                                                                case 2:
                                                                    switch (0)
                                                                    {
                                                                        case 0:
                                                                            break;
                                                                        default:
                                                                            continue;
                                                                    }
                                                                    break;
                                                            }
                                                            if (enumerator2 != null)
                                                            {
                                                                num5 = (short)1;
                                                                num6 = (int)(IntPtr)num5;
                                                            }
                                                            else
                                                                break;
                                                        }
                                                    label_40:;
                                                    }
                                                case 4:
                                                    switch (0)
                                                    {
                                                        case 0:
                                                            break;
                                                        default:
                                                            continue;
                                                    }
                                                    break;
                                            }
                                        label_11:
                                            num2 = (short)1;
                                            num3 = (int)(IntPtr)num2;
                                        }
                                    }
                                    finally
                                    {
                                        enumerator1.Dispose();
                                    }
                                label_51:
                                    num1 = 1;
                                    continue;
                                case 3:
                                    this.c.Error -= new PviEventHandler(this.a);
                                    this.c.Connected -= new PviEventHandler(this.c);
                                    num2 = (short)5;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                case 4:
                                    this.c.Disconnect();
                                    num2 = (short)10;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                case 5:
                                    if (this.c.IsConnected)
                                    {
                                        num2 = (short)4;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    }
                                    goto case 10;
                                case 6:
                                    this.d.Remove();
                                    this.d.Dispose();
                                    this.d = (Cpu)null;
                                    num2 = (short)13;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                case 7:
                                    this.d.Disconnect();
                                    num2 = (short)6;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                case 8:
                                    goto label_58;
                                case 9:
                                    this.d.Connected -= new PviEventHandler(this.b);
                                    num2 = (short)0;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                case 10:
                                    this.c.Remove();
                                    this.c.Dispose();
                                    this.c = (Service)null;
                                    num2 = (short)12;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                case 11:
                                    if (this.c != null)
                                    {
                                        num2 = (short)3;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    }
                                    goto case 12;
                                case 12:
                                    num2 = (short)8;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                case 13:
                                    num2 = (short)11;
                                    num1 = (int)(IntPtr)num2;
                                    continue;
                                default:
                                    goto label_2;
                            }
                        }
                }
            }
            catch
            {
            }
        label_58:
            base.Disconnect();
        }

        protected virtual bool GetVariableAddress(IVariableInternal variable, out int address)
        {
            short num1 = -14366;
            int num2 = (int)num1;
            num1 = (short)-14366;
            int num3 = (int)num1;
            switch (num2 == num3)
            {
                case true:
                    short num4 = 1;
                    if (num4 == (short)0)
                        ;
                    num4 = (short)0;
                    if (num4 == (short)0)
                        ;
                    num4 = (short)0;
                    address = 0;
                    return true;
                default:
                    goto case 1;
            }
        }

        private IECDataTypes _a(string itoolsType)
        {
            int num1;
            uint num2;
            short num3;
            switch (0)
            {
                case 0:
                label_2:
                    // ISSUE: reference to a compiler-generated method
                    num2 = hj.a(itoolsType);
                    num3 = (short)39;
                    num1 = (int)(IntPtr)num3;
                    goto default;
                default:
                    while (true)
                    {
                        switch (num1)
                        {
                            case 0:
                                num3 = (short)68;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 1:
                            case 2:
                            case 4:
                            case 16:
                            case 17:
                            case 20:
                            case 22:
                            case 23:
                            case 25:
                            case 30:
                            case 40:
                            case 47:
                            case 53:
                            case 59:
                            case 65:
                                goto label_115;
                            case 3:
                                if (num2 > 3297363694U)
                                {
                                    num3 = (short)55;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)64;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 5:
                                if (num2 != 3651752933U)
                                {
                                    num3 = (short)6;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)52;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 6:
                                num3 = (short)56;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 7:
                                num3 = (short)65;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 8:
                                if (!(itoolsType == "ULong"))
                                {
                                    num3 = (short)35;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_37;
                            case 9:
                                if (!(itoolsType == "DoubleLong"))
                                {
                                    num3 = (short)51;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_98;
                            case 10:
                                num3 = (short)47;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 11:
                                num3 = (short)43;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 12:
                                if (!(itoolsType == "UByte"))
                                {
                                    num3 = (short)32;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_12;
                            case 13:
                                num3 = (short)4;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 14:
                                num3 = (short)20;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 15:
                                if (num2 == 3297363694U)
                                {
                                    num3 = (short)8;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)14;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 18:
                                if (!(itoolsType == "Bool"))
                                {
                                    num3 = (short)67;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_87;
                            case 19:
                                num3 = (short)1;
                                if (num3 == (short)0)
                                    ;
                                if (num2 == 1699864918U)
                                {
                                    num3 = (short)9;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)50;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 21:
                                num3 = (short)2;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 24:
                                num3 = (short)15;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 26:
                                num3 = (short)53;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 27:
                                if (num2 != 2284044042U)
                                {
                                    num3 = (short)28;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)45;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 28:
                                num3 = (short)69;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 29:
                                if (!(itoolsType == "String"))
                                {
                                    num3 = (short)7;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_101;
                            case 31:
                                if (!(itoolsType == "DoubleULong"))
                                {
                                    num3 = (short)21;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_81;
                            case 32:
                                num3 = (short)25;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 33:
                                num3 = (short)66;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 34:
                                if (!(itoolsType == "Long"))
                                {
                                    num3 = (short)36;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_22;
                            case 35:
                                num3 = (short)30;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 36:
                                num3 = (short)59;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 37:
                                num3 = (short)16;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 38:
                                if (!(itoolsType == "DoubleReal"))
                                {
                                    num3 = (short)42;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_23;
                            case 39:
                                if (num2 <= 1699864918U)
                                {
                                    num3 = (short)11;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)3;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 41:
                                if (num2 != 1615808600U)
                                {
                                    num3 = (short)61;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)29;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 42:
                                num3 = (short)40;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 43:
                                if (num2 <= 1167299699U)
                                {
                                    num3 = (short)33;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)54;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 44:
                                num3 = (short)17;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 45:
                                if (!(itoolsType == "UInteger"))
                                {
                                    num3 = (short)20515;
                                    int num4 = (int)num3;
                                    num3 = (short)20515;
                                    int num5 = (int)num3;
                                    switch (num4 == num5 ? 1 : 0)
                                    {
                                        case 0:
                                        case 2:
                                            goto label_115;
                                        default:
                                            num3 = (short)0;
                                            if (num3 == (short)0)
                                                ;
                                            num3 = (short)26;
                                            num1 = (int)(IntPtr)num3;
                                            continue;
                                    }
                                }
                                else
                                    goto label_74;
                            case 46:
                                num3 = (short)41;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 48:
                                if (!(itoolsType == "Real"))
                                {
                                    num3 = (short)37;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_19;
                            case 49:
                                num3 = (short)22;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 50:
                                num3 = (short)1;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 51:
                                num3 = (short)60;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 52:
                                if (!(itoolsType == "Integer"))
                                {
                                    num3 = (short)49;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_100;
                            case 54:
                                if (num2 != 1460403325U)
                                {
                                    num3 = (short)46;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)48;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 55:
                                if (num2 != 3409549631U)
                                {
                                    num3 = (short)62;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)63;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 56:
                                if (num2 == 4190190954U)
                                {
                                    num3 = (short)12;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)10;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 57:
                                num3 = (short)58;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 58:
                                if (num2 == 951023137U)
                                {
                                    num3 = (short)31;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)0;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 60:
                                goto label_114;
                            case 61:
                                num3 = (short)19;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 62:
                                num3 = (short)5;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 63:
                                if (!(itoolsType == "Byte"))
                                {
                                    num3 = (short)13;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                goto label_50;
                            case 64:
                                num3 = (short)27;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 66:
                                if (num2 != 796142685U)
                                {
                                    num3 = (short)57;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)18;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 67:
                                num3 = (short)23;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 68:
                                if (num2 == 1167299699U)
                                {
                                    num3 = (short)34;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)44;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            case 69:
                                if (num2 != 2740199380U)
                                {
                                    num3 = (short)24;
                                    num1 = (int)(IntPtr)num3;
                                    continue;
                                }
                                num3 = (short)38;
                                num1 = (int)(IntPtr)num3;
                                continue;
                            default:
                                goto label_2;
                        }
                    }
                label_12:
                    return IECDataTypes.USINT;
                label_19:
                    return IECDataTypes.REAL;
                label_22:
                    return IECDataTypes.DINT;
                label_23:
                    return IECDataTypes.LREAL;
                label_37:
                    return IECDataTypes.UDINT;
                label_50:
                    return IECDataTypes.SINT;
                label_74:
                    return IECDataTypes.UINT;
                label_81:
                    return IECDataTypes.ULINT;
                label_87:
                    return IECDataTypes.BOOL;
                label_98:
                    return IECDataTypes.LINT;
                label_100:
                    return IECDataTypes.INT;
                label_101:
                    return IECDataTypes.STRING;
                label_114:
                    num3 = (short)0;
                label_115:
                    throw new IToolSException("Unhandled variable type" + itoolsType);
            }
        }

        protected virtual IOServerErrors ReadDataPack(
          VariablePack block,
          out byte[] bytes,
          bool synchro)
        {
            int num1 = 0;
            switch (num1)
            {
                default:
                    short num2;
                    switch (0)
                    {
                        case 0:
                        label_3:
                            bytes = (byte[])null;
                            num2 = (short)22;
                            num1 = (int)(IntPtr)num2;
                            goto default;
                        default:
                            IVariableInternal ivariableInternal1;
                            IVariableInternal[] variables;
                            int index;
                            IVariableInternal ivariableInternal2;
                            while (true)
                            {
                                switch (num1)
                                {
                                    case 0:
                                        this.e[ivariableInternal1.Address].b.State = (VariableState)3;
                                        num2 = (short)20;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 1:
                                    label_19:
                                        num2 = (short)25;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 2:
                                        num2 = (short)-29158;
                                        int num3 = (int)num2;
                                        num2 = (short)-29158;
                                        int num4 = (int)num2;
                                        switch (num3 == num4 ? 1 : 0)
                                        {
                                            case 0:
                                            case 2:
                                                goto label_18;
                                            default:
                                                num2 = (short)0;
                                                if (num2 == (short)0)
                                                    goto label_19;
                                                else
                                                    goto label_19;
                                        }
                                    case 3:
                                    case 15:
                                        num2 = (short)24;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 4:
                                        goto label_29;
                                    case 5:
                                        if (this.c.IsConnected)
                                        {
                                            variables = block.Variables;
                                            index = 0;
                                            num2 = (short)15;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        num2 = (short)6;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 6:
                                        variables = block.Variables;
                                        index = 0;
                                        num2 = (short)2;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 7:
                                        num2 = (short)5;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 8:
                                        ++index;
                                        num2 = (short)1;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 9:
                                        this.e[ivariableInternal2.Address].b.State = (VariableState)1;
                                        num2 = (short)8;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 10:
                                        if (this.e.ContainsKey(ivariableInternal2.Address))
                                        {
                                            num2 = (short)9;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        goto case 8;
                                    case 11:
                                    case 14:
                                    case 20:
                                    label_18:
                                        ++index;
                                        num2 = (short)3;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 12:
                                        if (this.d.IsConnected)
                                        {
                                            num2 = (short)13;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        goto case 6;
                                    case 13:
                                        num2 = (short)18;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 16:
                                        if (!this.e.ContainsKey(ivariableInternal1.Address))
                                        {
                                            ivariableInternal1.State = (VariableState)1;
                                            num2 = (short)11;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        num2 = (short)0;
                                        num2 = (short)19;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 17:
                                        num2 = (short)12;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 18:
                                        if (this.c != null)
                                        {
                                            num2 = (short)7;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        goto case 6;
                                    case 19:
                                        num2 = (short)23;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 21:
                                        goto label_38;
                                    case 22:
                                        if (this.d != null)
                                        {
                                            num2 = (short)17;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        goto case 6;
                                    case 23:
                                        if (!this.e[ivariableInternal1.Address].a.IsConnected)
                                        {
                                            num2 = (short)0;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        this.e[ivariableInternal1.Address].a.ReadValue(synchro);
                                        ivariableInternal1.Value = this.e[ivariableInternal1.Address].a.Value.ToType(ivariableInternal1.TypeBase.DotNetType, (IFormatProvider)CultureInfo.InvariantCulture);
                                        num2 = (short)14;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 24:
                                        if (index >= variables.Length)
                                        {
                                            num2 = (short)4;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        ivariableInternal1 = variables[index];
                                        num2 = (short)16;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    case 25:
                                        if (index >= variables.Length)
                                        {
                                            num2 = (short)21;
                                            num1 = (int)(IntPtr)num2;
                                            continue;
                                        }
                                        ivariableInternal2 = variables[index];
                                        num2 = (short)10;
                                        num1 = (int)(IntPtr)num2;
                                        continue;
                                    default:
                                        goto label_3;
                                }
                            }
                        label_29:
                            num2 = (short)1;
                            if (num2 == (short)0)
                                ;
                            return (IOServerErrors)1;
                        label_38:
                            this.ReInitialize();
                            return (IOServerErrors)3;
                    }
            }
        }

        protected virtual IOServerErrors WriteDataPack(
          VariablePack block,
          byte[] writeBytes,
          bool synchro)
        {
            switch (0)
            {
                default:
                    short num1 = 22;
                    int num2 = (int)(IntPtr)num1;
                    IVariableInternal ivariableInternal1;
                    IVariableInternal[] variables;
                    int index;
                    IVariableInternal ivariableInternal2;
                    while (true)
                    {
                        switch (num2)
                        {
                            case 0:
                                this.e[ivariableInternal1.Address].b.State = (VariableState)3;
                                num1 = (short)20;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 1:
                                num1 = (short)25;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 2:
                                num1 = (short)1;
                                if (num1 == (short)0)
                                    goto case 1;
                                else
                                    goto case 1;
                            case 3:
                            case 15:
                                num1 = (short)24;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 4:
                                goto label_42;
                            case 5:
                                if (this.c.IsConnected)
                                {
                                    variables = block.Variables;
                                    index = 0;
                                    num1 = (short)15;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                num1 = (short)6;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 6:
                            label_10:
                                variables = block.Variables;
                                index = 0;
                                num1 = (short)2;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 7:
                                num1 = (short)5;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 8:
                                ++index;
                                num1 = (short)1;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 9:
                                this.e[ivariableInternal2.Address].b.State = (VariableState)1;
                                num1 = (short)8;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 10:
                                if (this.e.ContainsKey(ivariableInternal2.Address))
                                {
                                    num1 = (short)9;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                goto case 8;
                            case 11:
                            case 20:
                            label_17:
                                ++index;
                                num1 = (short)3;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 12:
                                if (this.d.IsConnected)
                                {
                                    num1 = (short)13;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                goto case 6;
                            case 13:
                                num1 = (short)18;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 14:
                                num1 = (short)11714;
                                int num3 = (int)num1;
                                num1 = (short)11714;
                                int num4 = (int)num1;
                                switch (num3 == num4 ? 1 : 0)
                                {
                                    case 0:
                                    case 2:
                                        goto label_10;
                                    default:
                                        num1 = (short)0;
                                        if (num1 == (short)0)
                                            goto label_17;
                                        else
                                            goto label_17;
                                }
                            case 16:
                                if (!this.e.ContainsKey(ivariableInternal1.Address))
                                {
                                    ivariableInternal1.State = (VariableState)1;
                                    num1 = (short)11;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                num1 = (short)19;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 17:
                                num1 = (short)12;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 18:
                                if (this.c != null)
                                {
                                    num1 = (short)7;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                goto case 6;
                            case 19:
                                num1 = (short)23;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 21:
                                goto label_38;
                            case 22:
                                switch (0)
                                {
                                    case 0:
                                        goto label_4;
                                    default:
                                        continue;
                                }
                            case 23:
                                if (!this.e[ivariableInternal1.Address].a.IsConnected)
                                {
                                    num1 = (short)0;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                this.e[ivariableInternal1.Address].a.Value.Assign(ivariableInternal1.WriteValue);
                                this.e[ivariableInternal1.Address].a.WriteValue(synchro);
                                num1 = (short)14;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 24:
                                if (index >= variables.Length)
                                {
                                    num1 = (short)4;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                num1 = (short)0;
                                ivariableInternal1 = variables[index];
                                num1 = (short)16;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            case 25:
                                if (index >= variables.Length)
                                {
                                    num1 = (short)21;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                ivariableInternal2 = variables[index];
                                num1 = (short)10;
                                num2 = (int)(IntPtr)num1;
                                continue;
                            default:
                            label_4:
                                if (this.d != null)
                                {
                                    num1 = (short)17;
                                    num2 = (int)(IntPtr)num1;
                                    continue;
                                }
                                goto case 6;
                        }
                    }
                label_38:
                    this.ReInitialize();
                    return (IOServerErrors)5;
                label_42:
                    return (IOServerErrors)1;
            }
        }

        public virtual bool CheckReadRequestPack(
          IVariableInternal root,
          IVariableInternal join,
          VariablePack pack)
        {
            short num1 = -15962;
            int num2 = (int)num1;
            num1 = (short)-15962;
            int num3 = (int)num1;
            short num4;
            switch (num2 == num3)
            {
                case true:
                    num4 = (short)1;
                    if (num4 == (short)0)
                        ;
                    num4 = (short)0;
                    if (num4 == (short)0)
                        ;
                    return pack.Variables.Length < this.BlockSize;
                default:
                    num4 = (short)0;
                    goto case 1;
            }
        }

        public virtual bool CheckWriteRequestPack(
          IVariableInternal root,
          IVariableInternal join,
          VariablePack pack)
        {
            short num1 = 1;
            if (num1 == (short)0)
                ;
            num1 = (short)522;
            int num2 = (int)num1;
            num1 = (short)522;
            int num3 = (int)num1;
            switch (num2 == num3)
            {
                case true:
                    num1 = (short)0;
                    if (num1 == (short)0)
                        ;
                    num1 = (short)0;
                    return pack.Variables.Length < this.BlockSize;
                default:
                    goto case 1;
            }
        }

        protected virtual Channel CreateChannel()
        {
            short num1 = -13583;
            int num2 = (int)num1;
            num1 = (short)-13583;
            int num3 = (int)num1;
            switch (num2 == num3)
            {
                case true:
                    short num4 = 1;
                    if (num4 == (short)0)
                        ;
                    num4 = (short)0;
                    if (num4 == (short)0)
                        ;
                    num4 = (short)0;
                    return (Channel)null;
                default:
                    goto case 1;
            }
        }

        [Description("Ottiene/Imposta il nome dell servizio utilizzato per accedere al sistema B&R")]
        [AdvancedProperty]
        [DefaultValue("Service")]
        public string ServiceName
        {
            get
            {
                short num1 = 3018;
                int num2 = (int)num1;
                num1 = (short)3018;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        return this.a;
                    default:
                        goto case 1;
                }
            }
            set
            {
                short num1 = -2899;
                int num2 = (int)num1;
                num1 = (short)-2899;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        this.a = value;
                        break;
                    default:
                        goto case 1;
                }
            }
        }

        [DefaultValue("CPU")]
        [Description("Ottiene/Imposta il nome della CPU utilizzata per accedere al sistema B&R")]
        [AdvancedProperty]
        public string CpuName
        {
            get
            {
                short num1 = 1;
                if (num1 == (short)0)
                    ;
                num1 = (short)-28038;
                int num2 = (int)num1;
                num1 = (short)-28038;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        num1 = (short)0;
                        if (num1 == (short)0)
                            ;
                        num1 = (short)0;
                        return this.b;
                    default:
                        goto case 1;
                }
            }
            set
            {
                short num1 = 29542;
                int num2 = (int)num1;
                num1 = (short)29542;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        this.b = value;
                        break;
                    default:
                        goto case 1;
                }
            }
        }

        [DefaultValue(typeof(DeviceType), "TcpIp")]
        [AdvancedProperty]
        [Description("Ottiene/Imposta il tipo di device da utilizzare")]
        public DeviceType DeviceType
        {
            get
            {
                short num1 = -19465;
                int num2 = (int)num1;
                num1 = (short)-19465;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        return this.g;
                    default:
                        goto case 1;
                }
            }
            set
            {
                short num1 = 1;
                if (num1 == (short)0)
                    ;
                num1 = (short)9437;
                int num2 = (int)num1;
                num1 = (short)9437;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        num1 = (short)0;
                        if (num1 == (short)0)
                            ;
                        num1 = (short)0;
                        this.g = value;
                        break;
                    default:
                        goto case 1;
                }
            }
        }

        [AdvancedProperty]
        [Editor(typeof(DeviceParametersEditor), typeof(UITypeEditor))]
        [Description("Ottiene/Imposta i parametri di dispositivo")]
        [DefaultValue("/IF=TCPIP /SA=1")]
        public string DeviceParameters
        {
            get
            {
                short num1 = -7192;
                int num2 = (int)num1;
                num1 = (short)-7192;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        return this.h;
                    default:
                        goto case 1;
                }
            }
            set
            {
                short num1 = -11145;
                int num2 = (int)num1;
                num1 = (short)-11145;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        this.h = value;
                        break;
                    default:
                        goto case 1;
                }
            }
        }

        [AdvancedProperty]
        [Description("Ottiene/Imposta che indica se utilizzare le notifiche di cambio valore sulle variabili")]
        [DefaultValue(true)]
        public bool UseEventsNotification
        {
            get
            {
                short num1 = -6584;
                int num2 = (int)num1;
                num1 = (short)-6584;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        return this.m;
                    default:
                        goto case 1;
                }
            }
            set
            {
                short num1 = -10563;
                int num2 = (int)num1;
                num1 = (short)-10563;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        this.m = value;
                        break;
                    default:
                        goto case 1;
                }
            }
        }

        [Description("Ottiene/Imposta i parametri di dispositivo")]
        [Editor(typeof(CpuParametersEditor), typeof(UITypeEditor))]
        [DefaultValue("/DA=2")]
        [AdvancedProperty]
        public string CpuParameters
        {
            get
            {
                short num1 = -20247;
                int num2 = (int)num1;
                num1 = (short)-20247;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        return this.i;
                    default:
                        goto case 1;
                }
            }
            set
            {
                short num1 = -16907;
                int num2 = (int)num1;
                num1 = (short)-16907;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        this.i = value;
                        break;
                    default:
                        goto case 1;
                }
            }
        }

        public SynchronizationContext SynchronizationContext
        {
            get
            {
                short num1 = 20683;
                int num2 = (int)num1;
                num1 = (short)20683;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        return this.j;
                    default:
                        break;
                }

                return this.j;
            }
            set
            {
                short num1 = -29345;
                int num2 = (int)num1;
                num1 = (short)-29345;
                int num3 = (int)num1;
                switch (num2 == num3)
                {
                    case true:
                        short num4 = 1;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        if (num4 == (short)0)
                            ;
                        num4 = (short)0;
                        this.j = value;
                        break;
                    default:
                        break;
                }
            }
        }

        private class a
        {
            public Variable A;
            public IVariableInternal B;

            public a(Variable A_0, IVariableInternal A_1)
            {
                this.A = A_0;
                this.B = A_1;
            }
        }
    }
}
