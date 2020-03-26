﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualDice.Resources {
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
    internal class Capacities {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Capacities() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VirtualDice.Resources.Capacities", typeof(Capacities).Assembly);
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
        ///   Looks up a localized string similar to Vision dans le noir.
        /// </summary>
        internal static string DwarfCapacity {
            get {
                return ResourceManager.GetString("DwarfCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dans le noir total, le Nain voit comme dans la pénombre jusqu’à 30 m..
        /// </summary>
        internal static string DwarfCapacityDescription {
            get {
                return ResourceManager.GetString("DwarfCapacityDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don étrange.
        /// </summary>
        internal static string GnomeCapacity {
            get {
                return ResourceManager.GetString("GnomeCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Le gnome possède un talent inné pour les sciences, qu’elles soient occultes ou plus ordinaires. Il obtient un bonus de +2 sur tous les tests d&apos;INT..
        /// </summary>
        internal static string GnomeCapacityDescription {
            get {
                return ResourceManager.GetString("GnomeCapacityDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Petite taille.
        /// </summary>
        internal static string HalfelinCapacity {
            get {
                return ResourceManager.GetString("HalfelinCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Le Halfelin obtient un bonus de +1 en DEF et de +2 à tous les tests de discrétion. En revanche, un Halfelin peut seulement utiliser à une main une arme dont les DM sont au maximum égaux à 1d6 (épée courte, masse, etc.). Il lui faut utiliser les 2 mains pour les armes qui infligent 1d8 à 1d10 de DM (épée longue). Enfin il lui est interdit d’utiliser les armes qui infligent plus de 1d10 DM..
        /// </summary>
        internal static string HalfelinCapacityDescription {
            get {
                return ResourceManager.GetString("HalfelinCapacityDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instinct de survie.
        /// </summary>
        internal static string HumanCapacity {
            get {
                return ResourceManager.GetString("HumanCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lorsqu’une attaque devrait amener le personnage à 0 PV, les DM qu’elle inflige sont divisés par 2 (minimum 1)..
        /// </summary>
        internal static string HumanCapacityDescription {
            get {
                return ResourceManager.GetString("HumanCapacityDescription", resourceCulture);
            }
        }
    }
}