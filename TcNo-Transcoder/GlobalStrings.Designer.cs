﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TcNo_Transcoder {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class GlobalStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GlobalStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TcNo_Transcoder.GlobalStrings", typeof(GlobalStrings).Assembly);
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
        ///   Looks up a localized string similar to Failed to read settings file. Check everything is correct and try again.
        ///Error: {0}.
        /// </summary>
        internal static string ErrFailedSettingsRead {
            get {
                return ResourceManager.GetString("ErrFailedSettingsRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: {0} was not found in the settings file, or there was another error involving it.
        ///Please verify the settings file and try again..
        /// </summary>
        internal static string ErrSettingNotFound {
            get {
                return ResourceManager.GetString("ErrSettingNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopped..
        /// </summary>
        internal static string ErrStopped {
            get {
                return ResourceManager.GetString("ErrStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TechNobo&apos;s Video Transcoder
        ///------------------------------------------
        ///FIRST: Audio ENCODERS and then DECODERS.
        ///
        ///To see a list of videdo encoders, use -v
        ///
        ///------------------------------------------
        ///Listing available audio ENCODERS (output)
        ///------------------------------------------
        ///
        ///#
        ///
        ///------------------------------------------
        ///Listing available audio DECODERS (input)
        ///------------------------------------------
        ///
        ///
        ///#
        ///
        ///------------------------------------------.
        /// </summary>
        internal static string InfoAudio {
            get {
                return ResourceManager.GetString("InfoAudio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Everything complete.
        ///---------------------
        ///Start time: {0}
        ///Finish time: {1}
        ///---------------------
        ///Thanks for using TechNobo&apos;s Transcoder!
        ///---------------------
        ///GitHub: https://github.com/TcNobo/TcNo-Transcoder
        ///YouTube: https://YouTube.com/TechNobo
        ///Web: https://tcno.co/.
        /// </summary>
        internal static string InfoComplete {
            get {
                return ResourceManager.GetString("InfoComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Everything complete.
        ///---------------------
        ///Thanks for using TechNobo&apos;s Transcoder!
        ///---------------------
        ///GitHub: https://github.com/TcNobo/TcNo-Transcoder
        ///YouTube: https://YouTube.com/TechNobo
        ///Web: https://tcno.co/.
        /// </summary>
        internal static string InfoCompleteNoTime {
            get {
                return ResourceManager.GetString("InfoCompleteNoTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NOTE:
        ///When manually setting: use 0, 1, or any other integer, next to the GPU of your choice.
        /// 
        ///The following GPU&apos;s are available for NVEncC transcoding:.
        /// </summary>
        internal static string InfoDevices {
            get {
                return ResourceManager.GetString("InfoDevices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hello.
        ///Welcome to TechNobo&apos;s Video Transcoder {0}
        ///built for generating Proxy files with multitrack audio quickly.
        ///
        ///---------------------------------------
        ///
        ///BASIC USAGE:
        ///Edit settings in settings.cfg.
        ///Either:
        ///    - Run this .exe without arguments and follow instructions on screen.
        ///    - Drag and drop a file/folder onto this .exe
        ///    - Right click a file/folder, &quot;Add to TcNo Transcode Queue&quot; and run this .exe (See &apos;Queue information&apos; below)
        ///
        ///---------------------------------------
        ///
        ///INFORMATION  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InfoHelp {
            get {
                return ResourceManager.GetString("InfoHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TechNobo&apos;s Video Transcoder
        ///------------------------------------------
        ///
        ///{0} --check - formats
        ///
        ///------------------------------------------
        ///Remember to scroll to the top.
        ///ABOVE: Video Muxers and Demuxers.
        ///
        ///    || D - : Demuxer(input) ONLY.
        ///    || -M : Muxer(output) ONLY
        ///    || DM : Demuxer and Muxer, both input and output available.
        ///
        ///To see a list of audio encoders, use -a
        ///------------------------------------------.
        /// </summary>
        internal static string InfoVideo {
            get {
                return ResourceManager.GetString("InfoVideo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to TechNobo&apos;s Video Transcoder {0}
        ///------------------------
        ///Run with -h or --help to display help.
        ///Run with -i or --info to display info.
        ///------------------------.
        /// </summary>
        internal static string InfoWelcome {
            get {
                return ResourceManager.GetString("InfoWelcome", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PRESS ANY KEY TO CLOSE....
        /// </summary>
        internal static string PrgAnyKeyToClose {
            get {
                return ResourceManager.GetString("PrgAnyKeyToClose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using {0}
        ///The file will save to: {1}
        ///If you want it saved to a new directory, exit, and set it in settings.bat.
        ///Press any key to continue....
        /// </summary>
        internal static string PrgChangeDir {
            get {
                return ResourceManager.GetString("PrgChangeDir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you wish to continue?.
        /// </summary>
        internal static string PrgContinue {
            get {
                return ResourceManager.GetString("PrgContinue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Is this correct? (y/n):.
        /// </summary>
        internal static string PrgCorrect {
            get {
                return ResourceManager.GetString("PrgCorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ATTENTION!
        ///Dragging files in will process them INSTANTLY using the settings in settings.bat!
        ///
        ///The following files will be processed:.
        /// </summary>
        internal static string PrgDragDropNotice {
            get {
                return ResourceManager.GetString("PrgDragDropNotice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Drag and Drop input file into here:.
        /// </summary>
        internal static string PrgDragDropPrompt {
            get {
                return ResourceManager.GetString("PrgDragDropPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Queue processing cancelled..
        /// </summary>
        internal static string PrgProcessingCancelled {
            get {
                return ResourceManager.GetString("PrgProcessingCancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} will render with the current settings:
        ///Resolution: {1}
        ///FPS: {2}
        ///Codec: {3}
        ///
        ///This command will be run:.
        /// </summary>
        internal static string PrgVerifyRenderSettings {
            get {
                return ResourceManager.GetString("PrgVerifyRenderSettings", resourceCulture);
            }
        }
    }
}
