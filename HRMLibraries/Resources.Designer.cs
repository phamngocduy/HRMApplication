﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.Libraries {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HRM.Libraries.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 12345.
        /// </summary>
        public static string AdminPassword {
            get {
                return ResourceManager.GetString("AdminPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Admin.
        /// </summary>
        public static string AdminRoleName {
            get {
                return ResourceManager.GetString("AdminRoleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Admin.
        /// </summary>
        public static string AdminUserName {
            get {
                return ResourceManager.GetString("AdminUserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AuthConnection.
        /// </summary>
        public static string AuthConnection {
            get {
                return ResourceManager.GetString("AuthConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to vi-VN.
        /// </summary>
        public static string CultureInfo {
            get {
                return ResourceManager.GetString("CultureInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ~/App_Data/text.locale-vi.txt.
        /// </summary>
        public static string Vietnamese {
            get {
                return ResourceManager.GetString("Vietnamese", resourceCulture);
            }
        }
    }
}
