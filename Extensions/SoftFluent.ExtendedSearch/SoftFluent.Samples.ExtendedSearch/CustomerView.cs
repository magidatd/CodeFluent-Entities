﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.ExtendedSearch
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 29 June 2015 18:09.
    // Build:1.0.61214.0817
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0817")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    public partial class CustomerView : CodeFluent.Runtime.ICodeFluentLightEntity
    {
        
        private string _fullName = default(string);
        
        private System.DateTime _dateOfBirth = CodeFluentPersistence.DefaultDateTimeValue;
        
        public CustomerView()
        {
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string FullName
        {
            get
            {
                return this._fullName;
            }
            set
            {
                this._fullName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime DateOfBirth
        {
            get
            {
                return this._dateOfBirth;
            }
            set
            {
                this._dateOfBirth = value;
            }
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._fullName = CodeFluentPersistence.GetReaderValue(reader, "Customer_FullName", ((string)(default(string))));
                this._dateOfBirth = CodeFluentPersistence.GetReaderValue(reader, "Customer_DateOfBirth", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
            }
        }
        
        void CodeFluent.Runtime.ICodeFluentLightEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
    }
}
