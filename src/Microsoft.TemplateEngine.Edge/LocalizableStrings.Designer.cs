﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.TemplateEngine.Edge {
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
    internal class LocalizableStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizableStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.TemplateEngine.Edge.LocalizableStrings", typeof(LocalizableStrings).Assembly);
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
        ///   Looks up a localized string similar to latest version.
        /// </summary>
        internal static string Generic_LatestVersion {
            get {
                return ResourceManager.GetString("Generic_LatestVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to version {0}.
        /// </summary>
        internal static string Generic_Version {
            get {
                return ResourceManager.GetString("Generic_Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is already installed, version: {1}, it will be replaced with {2}.
        /// </summary>
        internal static string GlobalSettingsTemplatesSourcesProvider_Info_PackageAlreadyInstalled {
            get {
                return ResourceManager.GetString("GlobalSettingsTemplatesSourcesProvider_Info_PackageAlreadyInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} was successfully uninstalled.
        /// </summary>
        internal static string GlobalSettingsTemplatesSourcesProvider_Info_PackageUninstalled {
            get {
                return ResourceManager.GetString("GlobalSettingsTemplatesSourcesProvider_Info_PackageUninstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load the NuGet source {0}.
        /// </summary>
        internal static string NuGetApiPackageManager_Error_FailedToLoadSource {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Error_FailedToLoadSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load NuGet sources configured for the folder {currentDirectory}.
        /// </summary>
        internal static string NuGetApiPackageManager_Error_FailedToLoadSources {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Error_FailedToLoadSources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read package information from NuGet source {0}.
        /// </summary>
        internal static string NuGetApiPackageManager_Error_FailedToReadPackage {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Error_FailedToReadPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0] already exists.
        /// </summary>
        internal static string NuGetApiPackageManager_Error_FileAlreadyExists {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Error_FileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No NuGet sources are defined or enabled.
        /// </summary>
        internal static string NuGetApiPackageManager_Error_NoSources {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Error_NoSources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to remove {0} after failed download. Remove the file manually if it exists..
        /// </summary>
        internal static string NuGetApiPackageManager_Warning_FailedToDelete {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Warning_FailedToDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to download {0} from NuGet feed {1}.
        /// </summary>
        internal static string NuGetApiPackageManager_Warning_FailedToDownload {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Warning_FailedToDownload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load NuGet source {0}: the source is not valid. It will be skipped in further processing..
        /// </summary>
        internal static string NuGetApiPackageManager_Warning_FailedToLoadSource {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Warning_FailedToLoadSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not found in NuGet feeds {1}.
        /// </summary>
        internal static string NuGetApiPackageManager_Warning_PackageNotFound {
            get {
                return ResourceManager.GetString("NuGetApiPackageManager_Warning_PackageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to copy package {0} to {1}.
        /// </summary>
        internal static string NuGetInstaller_Error_CopyFailed {
            get {
                return ResourceManager.GetString("NuGetInstaller_Error_CopyFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read content of package {0}.
        /// </summary>
        internal static string NuGetInstaller_Error_FailedToReadPackage {
            get {
                return ResourceManager.GetString("NuGetInstaller_Error_FailedToReadPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} already exists.
        /// </summary>
        internal static string NuGetInstaller_Error_FileAlreadyExists {
            get {
                return ResourceManager.GetString("NuGetInstaller_Error_FileAlreadyExists", resourceCulture);
            }
        }
    }
}
