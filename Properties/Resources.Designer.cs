﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GLEED2D.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GLEED2D.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to (Left Click) = start new circle      (Right Click) = exit circle draw mode.
        /// </summary>
        internal static string Circle_Entered {
            get {
                return ResourceManager.GetString("Circle_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = add circle to level      (Right Click) = cancel circle.
        /// </summary>
        internal static string Circle_Started {
            get {
                return ResourceManager.GetString("Circle_Started", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap folder {
            get {
                object obj = ResourceManager.GetObject("folder", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no layer in the level. Please add a new layer before adding items..
        /// </summary>
        internal static string No_Layer {
            get {
                return ResourceManager.GetString("No_Layer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = start new path      (Right Click) = exit path draw mode.
        /// </summary>
        internal static string Path_Entered {
            get {
                return ResourceManager.GetString("Path_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = next point      (BackSpace) = delete last point      (Middle Click) = add path to level      (Right Click) = cancel path.
        /// </summary>
        internal static string Path_Started {
            get {
                return ResourceManager.GetString("Path_Started", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = start new rectangle      (Right Click) = exit rectangle draw mode.
        /// </summary>
        internal static string Rectangle_Entered {
            get {
                return ResourceManager.GetString("Rectangle_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = add rectangle to level      (LeftCtrl) = make square      (Right Click) = cancel rectangle.
        /// </summary>
        internal static string Rectangle_Started {
            get {
                return ResourceManager.GetString("Rectangle_Started", resourceCulture);
            }
        }
    }
}