﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kros.AspNetCore.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kros.AspNetCore.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Authorization service forbidden this request..
        /// </summary>
        internal static string AuthorizationServiceForbiddenRequest {
            get {
                return ResourceManager.GetString("AuthorizationServiceForbiddenRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User request is invalid..
        /// </summary>
        internal static string BadRequest {
            get {
                return ResourceManager.GetString("BadRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error code exception {0}..
        /// </summary>
        internal static string ErrorCodeException {
            get {
                return ResourceManager.GetString("ErrorCodeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception {0} was thrown during request pipeline. Status code of the response was changed to {1}..
        /// </summary>
        internal static string ErrorHandlingMiddleware_StatusCodeChange {
            get {
                return ResourceManager.GetString("ErrorHandlingMiddleware_StatusCodeChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; configuration section is missing or empty..
        /// </summary>
        internal static string GatewayJwtAuthorizationMissingSection {
            get {
                return ResourceManager.GetString("GatewayJwtAuthorizationMissingSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  IdentityServer handler for scheme {0}.
        /// </summary>
        internal static string IdentityHealthCheckBuilderName {
            get {
                return ResourceManager.GetString("IdentityHealthCheckBuilderName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource was not found..
        /// </summary>
        internal static string NotFound {
            get {
                return ResourceManager.GetString("NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User does not have permission to access requested resource..
        /// </summary>
        internal static string UserDoNotHavePermissionToAccessRequestedResource {
            get {
                return ResourceManager.GetString("UserDoNotHavePermissionToAccessRequestedResource", resourceCulture);
            }
        }
    }
}
