﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: CodeFluent.Runtime.Utilities.CodeFluentGeneratedAttribute("1.0.61214.0817", "CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 29 June " +
    "2015 18:09.", CodeFluent.Runtime.Utilities.CodeFluentGeneratedAttributeOptions.CompiledWithVisualStudio, 2695476103u)]

namespace SoftFluent.Samples.ExtendedSearch.Resources
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 29 June 2015 18:09.
    // Build:1.0.61214.0817
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0817")]
    public sealed partial class Manager
    {
        
        private static Manager _loader;
        
        private System.Resources.ResourceManager _resources;
        
        private Manager()
        {
            this._resources = new System.Resources.ResourceManager("SoftFluent.Samples.ExtendedSearch.SoftFluent.Samples.ExtendedSearch", System.Reflection.Assembly.GetExecutingAssembly());
            try
            {
                this._resources.GetString("_cf_build");
            }
            catch (System.Resources.MissingManifestResourceException e)
            {
                throw new CodeFluent.Runtime.CodeFluentRuntimeException(@"CF6050: Cannot find resource set in the current assembly. If this project was compiled with CodeFluent, you should not specify the 'runtimeResourceBaseName' attribute, nor the 'resourceFileFormat' attribute in CodeDomProducer configuration. If this project was compiled with Microsoft Visual Studio 2003 or higher, please make sure the project's Default Namespace is empty, or configure CodeDomProducer with the 'runtimeResourceBaseName' attribute. If this project was compiled with Microsoft Visual Studio 2005 or higher, please make sure the 'resourceFileFormat' attribute is set to 'resx' as well.", e);
            }
        }
        
        private static Manager GetLoader()
        {
            if ((Manager._loader == null))
            {
                System.Type type = typeof(Manager);
                System.Threading.Monitor.Enter(type);
                try
                {
                    if ((Manager._loader == null))
                    {
                        Manager._loader = new Manager();
                    }
                }
                finally
                {
                    System.Threading.Monitor.Exit(type);
                }
            }
            return Manager._loader;
        }
        
        public static object GetObject(System.Globalization.CultureInfo culture, string name, string defaultValue)
        {
            Manager loader = Manager.GetLoader();
            object obj = loader._resources.GetObject(name, culture);
            if ((obj == null))
            {
                return defaultValue;
            }
            return obj;
        }
        
        public static object GetObject(string name, string defaultValue)
        {
            return Manager.GetObject(null, name, defaultValue);
        }
        
        public static string GetString(System.Globalization.CultureInfo culture, string name, object[] args)
        {
            Manager loader = Manager.GetLoader();
            string str = loader._resources.GetString(name, culture);
            if ((str == null))
            {
                return name;
            }
            if ((args != null))
            {
                return string.Format(culture, str, args);
            }
            else
            {
                return str;
            }
        }
        
        public static string GetString(string name, object[] args)
        {
            return Manager.GetString(null, name, args);
        }
        
        public static string GetString(string name, string defaultValue)
        {
            return Manager.GetStringWithDefault(null, name, defaultValue, null);
        }
        
        public static string GetStringWithDefault(System.Globalization.CultureInfo culture, string name, string defaultValue, object[] args)
        {
            Manager loader = Manager.GetLoader();
            string str = loader._resources.GetString(name, culture);
            if ((str == null))
            {
                if (((defaultValue == null) 
                            || (args == null)))
                {
                    return defaultValue;
                }
                else
                {
                    return string.Format(culture, defaultValue, args);
                }
            }
            if ((args != null))
            {
                return string.Format(culture, str, args);
            }
            else
            {
                return str;
            }
        }
        
        public static string GetStringWithDefault(string name, string defaultValue, object[] args)
        {
            return Manager.GetStringWithDefault(null, name, defaultValue, args);
        }
        
        public static string GetStringWithDefault(string name, string defaultValue)
        {
            return Manager.GetStringWithDefault(null, name, defaultValue, null);
        }
        
        public static string GetUserMessage(System.Globalization.CultureInfo culture, CodeFluent.Runtime.UserExceptionType type, string name, params object[] args)
        {
            string code = string.Concat(CodeFluent.Runtime.CodeFluentRuntimeException.UserMessagePrefix, ".", type.ToString(), ".", name);
            Manager loader = Manager.GetLoader();
            string str = loader._resources.GetString(code, culture);
            if ((str == null))
            {
                code = string.Concat(CodeFluent.Runtime.CodeFluentRuntimeException.UserMessagePrefix, ".", type.ToString());
                str = loader._resources.GetString(code, culture);
                if ((str == null))
                {
                    str = CodeFluent.Runtime.CodeFluentRuntimeException.GetUserMessage(culture, type, args);
                }
            }
            if ((args != null))
            {
                return string.Format(culture, str, args);
            }
            else
            {
                return str;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0817")]
    public sealed partial class ValueValidationFailureHandler : CodeFluent.Runtime.Rules.BaseValueValidationFailureHandler
    {
        
        private static SoftFluent.Samples.ExtendedSearch.Resources.ValueValidationFailureHandler _current = new SoftFluent.Samples.ExtendedSearch.Resources.ValueValidationFailureHandler();
        
        public ValueValidationFailureHandler()
        {
        }
        
        public static SoftFluent.Samples.ExtendedSearch.Resources.ValueValidationFailureHandler Current
        {
            get
            {
                return SoftFluent.Samples.ExtendedSearch.Resources.ValueValidationFailureHandler._current;
            }
        }
        
        public override string GetMessage(System.Globalization.CultureInfo culture, CodeFluent.Runtime.Rules.ValueValidator validator, string failureCode, object[] arguments)
        {
            string baseMessage = base.GetMessage(culture, validator, failureCode, arguments);
            string code = this.GetCode(validator, failureCode);
            string message = SoftFluent.Samples.ExtendedSearch.Resources.Manager.GetString(culture, code, arguments);
            if ((message == code))
            {
                return baseMessage;
            }
            return message;
        }
    }
}
namespace SoftFluent.Samples.ExtendedSearch
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0817")]
    public sealed partial class Constants
    {
        
        public const string SoftFluent_Samples_ExtendedSearchStoreName = "SoftFluent.Samples.ExtendedSearch";
        
        private Constants()
        {
        }
    }
}
