﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.17626
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageReflection.Resources
{
    using System;


    /// <summary>
    ///   Clase de recurso fuertemente tipado para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompila tu proyecto de Visual Studio.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AppResources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources()
        {
        }

        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché usada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ImageReflection.Resources.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Invalida la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos usando esta clase de recursos fuertemente tipados.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Busca una cadena traducida similar a LeftToRight.
        /// </summary>
        public static string ResourceFlowDirection
        {
            get
            {
                return ResourceManager.GetString("ResourceFlowDirection", resourceCulture);
            }
        }

        /// <summary>
        ///   Busca una cadena traducida similar a us-EN.
        /// </summary>
        public static string ResourceLanguage
        {
            get
            {
                return ResourceManager.GetString("ResourceLanguage", resourceCulture);
            }
        }

        /// <summary>
        ///   Busca una cadena traducida similar a MI APLICACIÓN.
        /// </summary>
        public static string ApplicationTitle
        {
            get
            {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Busca una cadena traducida similar a botón
        /// </summary>
        public static string AppBarButtonText
        {
            get
            {
                return ResourceManager.GetString("AppBarButtonText", resourceCulture);
            }
        }

        /// <summary>
        ///   Busca una cadena traducida similar a elemento de menú.
        /// </summary>
        public static string AppBarMenuItemText
        {
            get
            {
                return ResourceManager.GetString("AppBarMenuItemText", resourceCulture);
            }
        }
    }
}
