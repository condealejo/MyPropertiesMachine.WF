﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPropertiesMachine.UnitTest.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MachineResourcesTest {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MachineResourcesTest() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MyPropertiesMachine.UnitTest.Resources.MachineResourcesTest", typeof(MachineResourcesTest).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;SO&quot;: &quot;Microsoft Windows NT 10.0.19041.0&quot;,
        ///    &quot;MachineName&quot;: &quot;MSI&quot;,
        ///    &quot;IP&quot;: &quot;192.168.0.10&quot;,
        ///    &quot;HardDisk&quot;: &quot;C:\\ -&gt; 100,4 GB -&gt; Usado: 42%&quot;,
        ///    &quot;RAM&quot;: &quot; 16 GB -&gt; Usado: 64%&quot;,
        ///    &quot;CPU&quot;: &quot;Intel(R) Core(TM) i7-8750H CPU @ 2.20GHz&quot;
        ///    }
        ///.
        /// </summary>
        internal static string MachineExpected {
            get {
                return ResourceManager.GetString("MachineExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ArandaTestUnit_{date}.txt.
        /// </summary>
        internal static string prmFileName {
            get {
                return ResourceManager.GetString("prmFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 192.168.0.10.
        /// </summary>
        internal static string prmIPAddress {
            get {
                return ResourceManager.GetString("prmIPAddress", resourceCulture);
            }
        }
    }
}
