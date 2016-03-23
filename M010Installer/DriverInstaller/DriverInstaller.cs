using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;

namespace DriverInstaller
{
    [RunInstaller(true)]
    public partial class DriverInstaller : System.Configuration.Install.Installer
    {
        public DriverInstaller()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(Me.Context.Parameters("AssemblyPath")) + "\MyApplication.exe");
        }
    }
}
