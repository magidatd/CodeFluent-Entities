﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.AzureCache
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Wednesday, 27 August 2014 12:34.
    // Build:1.0.61214.0773
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0773")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Name={Name}, Id={Id}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class Product : System.ICloneable, System.IComparable, System.IComparable<SoftFluent.Samples.AzureCache.Product>, CodeFluent.Runtime.ICodeFluentCollectionEntity<System.Guid>, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<SoftFluent.Samples.AzureCache.Product>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private byte[] _rowVersion;
        
        private System.Guid _id = CodeFluentPersistence.DefaultGuidValue;
        
        private string _name = default(string);
        
        private string _description = default(string);
        
        private System.Guid _categoryId = CodeFluentPersistence.DefaultGuidValue;
        
        [System.NonSerializedAttribute()]
        private SoftFluent.Samples.AzureCache.Category _category = null;
        
        public Product()
        {
            this._id = System.Guid.NewGuid();
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.Id.ToString();
            }
            set
            {
                this.Id = ((System.Guid)(ConvertUtilities.ChangeType(value, typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.Name;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        [System.ComponentModel.DataObjectFieldAttribute(false, true)]
        [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.ByteArrayConverter))]
        public byte[] RowVersion
        {
            get
            {
                return this._rowVersion;
            }
            set
            {
                if (((value != null) 
                            && (value.Length == 0)))
                {
                    value = null;
                }
                this._rowVersion = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("RowVersion"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.Guid))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public System.Guid Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<System.Guid>.Default.Equals(value, this._id) == true))
                {
                    return;
                }
                System.Guid oldKey = this._id;
                if ((value.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
                    this._id = System.Guid.NewGuid();
                }
                else
                {
                    this._id = value;
                }
                try
                {
                    this.OnCollectionKeyChanged(oldKey);
                }
                catch (System.ArgumentException )
                {
                    this._id = oldKey;
                    return;
                }
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Name"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Description"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public System.Guid CategoryId
        {
            get
            {
                if (((this._categoryId.Equals(CodeFluentPersistence.DefaultGuidValue) == true) 
                            && (this._category != null)))
                {
                    this._categoryId = this._category.Id;
                }
                return this._categoryId;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<System.Guid>.Default.Equals(value, this.CategoryId) == true))
                {
                    return;
                }
                this._category = null;
                this._categoryId = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Category"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CategoryId"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SoftFluent.Samples.AzureCache.Category Category
        {
            get
            {
                if ((this._category == null))
                {
                    this._category = SoftFluent.Samples.AzureCache.Category.Load(this._categoryId);
                }
                return this._category;
            }
            set
            {
                this._categoryId = CodeFluentPersistence.DefaultGuidValue;
                this._category = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Category"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CategoryId"));
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        System.Guid CodeFluent.Runtime.Utilities.IKeyable<System.Guid>.Key
        {
            get
            {
                return this.Id;
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.Created) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        [field:System.NonSerializedAttribute()]
        public event System.EventHandler<CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>> KeyChanged;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(SoftFluent.Samples.AzureCache.Product product)
        {
            if ((product == null))
            {
                return false;
            }
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return base.Equals(product);
            }
            return (this.Id.Equals(product.Id) == true);
        }
        
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            SoftFluent.Samples.AzureCache.Product product = null;
			product = obj as SoftFluent.Samples.AzureCache.Product;
            return this.Equals(product);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            SoftFluent.Samples.AzureCache.Product product = null;
product = value as SoftFluent.Samples.AzureCache.Product;
            if ((product == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(product);
            return localCompareTo;
        }
        
        public virtual int CompareTo(SoftFluent.Samples.AzureCache.Product product)
        {
            if ((product == null))
            {
                throw new System.ArgumentNullException("product");
            }
            int localCompareTo = this.Id.CompareTo(product.Id);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = SoftFluent.Samples.AzureCache.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.AzureCache.Product.ExternalValidate", "Type \'SoftFluent.Samples.AzureCache.Product\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                string localValidate = SoftFluent.Samples.AzureCache.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.AzureCache.Product.Id.NullException", "\'Id\' property cannot be set to \'00000000-0000-0000-0000-000000000000\' for type \'S" +
                        "oftFluent.Samples.AzureCache.Product\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate);
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            SoftFluent.Samples.AzureCache.Product.ClearCache();
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            if ((this.RowVersion == null))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.AzureCache.Constants.SoftFluent_Samples_AzureCacheStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Product", "Delete");
            persistence.AddParameter("@Product_Id", this.Id, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
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
                this._id = CodeFluentPersistence.GetReaderValue(reader, "Product_Id", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
                this._name = CodeFluentPersistence.GetReaderValue(reader, "Product_Name", ((string)(default(string))));
                this._description = CodeFluentPersistence.GetReaderValue(reader, "Product_Description", ((string)(default(string))));
                this.CategoryId = CodeFluentPersistence.GetReaderValue(reader, "Product_Category_Id", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.RowVersion) 
                        == 0) 
                        == false))
            {
                this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        // CacheManager1
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        private static SoftFluent.Samples.AzureCache.Product CacheLoad(bool useCache, System.Guid id)
        {
            if ((id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return null;
            }
            SoftFluent.Samples.AzureCache.Product product = null;
            string cacheKey = null;
            if ((useCache == true))
            {
                cacheKey = CodeFluent.Runtime.Caching.SimpleCacheManager.BuildCacheKey("4fb84cba8f1558db4fd51370370eb1c0", id);
product = SoftFluent.Samples.AzureCache.Caching.CacheManager1.Manager.Get("SoftFluent.Samples.AzureCache.Product", cacheKey) as SoftFluent.Samples.AzureCache.Product;
                if ((product != null))
                {
                    return product;
                }
            }
            product = new SoftFluent.Samples.AzureCache.Product();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.AzureCache.Constants.SoftFluent_Samples_AzureCacheStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Product", "Load");
            persistence.AddParameter("@Id", id, CodeFluentPersistence.DefaultGuidValue);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    product.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    product.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    if ((useCache == true))
                    {
                        SoftFluent.Samples.AzureCache.Caching.CacheManager1.Manager.Add("SoftFluent.Samples.AzureCache.Product", cacheKey, product, null);
                    }
                    return product;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        // CacheManager1
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
        private static SoftFluent.Samples.AzureCache.Product CacheLoadById(bool useCache, System.Guid id)
        {
            if ((id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return null;
            }
            SoftFluent.Samples.AzureCache.Product product = null;
            string cacheKey = null;
            if ((useCache == true))
            {
                cacheKey = CodeFluent.Runtime.Caching.SimpleCacheManager.BuildCacheKey("a9e5a1a24ea026921bce45d1e9e624fc", id);
product = SoftFluent.Samples.AzureCache.Caching.CacheManager1.Manager.Get("SoftFluent.Samples.AzureCache.Product", cacheKey) as SoftFluent.Samples.AzureCache.Product;
                if ((product != null))
                {
                    return product;
                }
            }
            product = new SoftFluent.Samples.AzureCache.Product();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.AzureCache.Constants.SoftFluent_Samples_AzureCacheStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Product", "LoadById");
            persistence.AddParameter("@Id", id, CodeFluentPersistence.DefaultGuidValue);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    product.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    product.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    if ((useCache == true))
                    {
                        SoftFluent.Samples.AzureCache.Caching.CacheManager1.Manager.Add("SoftFluent.Samples.AzureCache.Product", cacheKey, product, null);
                    }
                    return product;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.AzureCache.Constants.SoftFluent_Samples_AzureCacheStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Product", "Load");
            persistence.AddParameter("@Id", this.Id);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            SoftFluent.Samples.AzureCache.Product.ClearCache();
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.AzureCache.Constants.SoftFluent_Samples_AzureCacheStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Product", "Save");
            persistence.AddParameter("@Product_Id", this.Id, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@Product_Name", this.Name, default(string));
            persistence.AddParameter("@Product_Description", this.Description, default(string));
            persistence.AddParameter("@Product_Category_Id", this.CategoryId, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@_trackLastWriteUser", persistence.Context.User.Name);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(SoftFluent.Samples.AzureCache.Product product)
        {
            if ((product == null))
            {
                return false;
            }
            bool ret = product.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(SoftFluent.Samples.AzureCache.Product product)
        {
            bool ret = SoftFluent.Samples.AzureCache.Product.Save(product);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(SoftFluent.Samples.AzureCache.Product product)
        {
            if ((product == null))
            {
                return false;
            }
            bool ret = product.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("Id=");
            writer.Write(this.Id);
            writer.Write(",");
            writer.Write("Name=");
            writer.Write(this.Name);
            writer.Write(",");
            writer.Write("Description=");
            writer.Write(this.Description);
            writer.Write(",");
            writer.Write("Category=");
            if ((this._category != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._category)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_categoryId=");
            writer.Write(this._categoryId);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.AzureCache.Product LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            SoftFluent.Samples.AzureCache.Product product;
            System.Guid var = ((System.Guid)(ConvertUtilities.ChangeType(key, typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            product = SoftFluent.Samples.AzureCache.Product.Load(var);
            return product;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public SoftFluent.Samples.AzureCache.Product Clone(bool deep)
        {
            SoftFluent.Samples.AzureCache.Product product = new SoftFluent.Samples.AzureCache.Product();
            this.CopyTo(product, deep);
            return product;
        }
        
        public SoftFluent.Samples.AzureCache.Product Clone()
        {
            SoftFluent.Samples.AzureCache.Product localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("Id") == true))
            {
                this.Id = ((System.Guid)(ConvertUtilities.ChangeType(dict["Id"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((dict.Contains("Description") == true))
            {
                this.Description = ((string)(ConvertUtilities.ChangeType(dict["Description"], typeof(string), default(string))));
            }
            if ((dict.Contains("Name") == true))
            {
                this.Name = ((string)(ConvertUtilities.ChangeType(dict["Name"], typeof(string), default(string))));
            }
            if ((dict.Contains("CategoryId") == true))
            {
                this.CategoryId = ((System.Guid)(ConvertUtilities.ChangeType(dict["CategoryId"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(SoftFluent.Samples.AzureCache.Product product, bool deep)
        {
            if ((product == null))
            {
                throw new System.ArgumentNullException("product");
            }
            product.Id = this.Id;
            product.Description = this.Description;
            product.Name = this.Name;
            product.CategoryId = this.CategoryId;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, product));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["Id"] = this.Id;
            dict["Description"] = this.Description;
            dict["Name"] = this.Name;
            dict["CategoryId"] = this.CategoryId;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
        
        protected void OnCollectionKeyChanged(System.Guid key)
        {
            if ((this.KeyChanged != null))
            {
                this.KeyChanged(this, new CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>(key));
            }
        }
        
        // CacheManager1
        public static SoftFluent.Samples.AzureCache.Product Load(System.Guid id)
        {
            return Product.CacheLoad(true, id);
        }
        
        // CacheManager1
        public static SoftFluent.Samples.AzureCache.Product NoCacheLoad(System.Guid id)
        {
            return Product.CacheLoad(false, id);
        }
        
        // CacheManager1
        public static SoftFluent.Samples.AzureCache.Product LoadById(System.Guid id)
        {
            return Product.CacheLoadById(true, id);
        }
        
        // CacheManager1
        public static SoftFluent.Samples.AzureCache.Product NoCacheLoadById(System.Guid id)
        {
            return Product.CacheLoadById(false, id);
        }
        
        public static void ClearCache()
        {
            SoftFluent.Samples.AzureCache.Caching.CacheManager0.Manager.Clear("SoftFluent.Samples.AzureCache.Product");
            SoftFluent.Samples.AzureCache.Caching.CacheManager1.Manager.Clear("SoftFluent.Samples.AzureCache.Product");
        }
    }
}
