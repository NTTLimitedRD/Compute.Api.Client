﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace DD.CBU.Compute.Api.Contracts {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:didata.com:api:cloud:types")]
    public partial class ReservedPublicIpv4AddressType {
        
        private string datacenterIdField;
        
        private string ipBlockIdField;
        
        private string networkDomainIdField;
        
        private string networkIdField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datacenterId {
            get {
                return this.datacenterIdField;
            }
            set {
                this.datacenterIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ipBlockId {
            get {
                return this.ipBlockIdField;
            }
            set {
                this.ipBlockIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkDomainId {
            get {
                return this.networkDomainIdField;
            }
            set {
                this.networkDomainIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkId {
            get {
                return this.networkIdField;
            }
            set {
                this.networkIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:didata.com:api:cloud:types")]
    public partial class ReservedPrivateIpv4AddressType {
        
        private string datacenterIdField;
        
        private string networkIdField;
        
        private string vlanIdField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datacenterId {
            get {
                return this.datacenterIdField;
            }
            set {
                this.datacenterIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkId {
            get {
                return this.networkIdField;
            }
            set {
                this.networkIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vlanId {
            get {
                return this.vlanIdField;
            }
            set {
                this.vlanIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:didata.com:api:cloud:types", IsNullable=false)]
    public partial class reservedPrivateIpv4Addresses {
        
        private ReservedPrivateIpv4AddressType[] ipv4Field;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private int pageCountField;
        
        private bool pageCountFieldSpecified;
        
        private int totalCountField;
        
        private bool totalCountFieldSpecified;
        
        private int pageSizeField;
        
        private bool pageSizeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ipv4")]
        public ReservedPrivateIpv4AddressType[] ipv4 {
            get {
                return this.ipv4Field;
            }
            set {
                this.ipv4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber {
            get {
                return this.pageNumberField;
            }
            set {
                this.pageNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified {
            get {
                return this.pageNumberFieldSpecified;
            }
            set {
                this.pageNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount {
            get {
                return this.pageCountField;
            }
            set {
                this.pageCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified {
            get {
                return this.pageCountFieldSpecified;
            }
            set {
                this.pageCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount {
            get {
                return this.totalCountField;
            }
            set {
                this.totalCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified {
            get {
                return this.totalCountFieldSpecified;
            }
            set {
                this.totalCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize {
            get {
                return this.pageSizeField;
            }
            set {
                this.pageSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified {
            get {
                return this.pageSizeFieldSpecified;
            }
            set {
                this.pageSizeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:didata.com:api:cloud:types", IsNullable=false)]
    public partial class reservedPublicIpv4Addresses {
        
        private ReservedPublicIpv4AddressType[] ipField;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private int pageCountField;
        
        private bool pageCountFieldSpecified;
        
        private int totalCountField;
        
        private bool totalCountFieldSpecified;
        
        private int pageSizeField;
        
        private bool pageSizeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ip")]
        public ReservedPublicIpv4AddressType[] ip {
            get {
                return this.ipField;
            }
            set {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber {
            get {
                return this.pageNumberField;
            }
            set {
                this.pageNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified {
            get {
                return this.pageNumberFieldSpecified;
            }
            set {
                this.pageNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount {
            get {
                return this.pageCountField;
            }
            set {
                this.pageCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified {
            get {
                return this.pageCountFieldSpecified;
            }
            set {
                this.pageCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount {
            get {
                return this.totalCountField;
            }
            set {
                this.totalCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified {
            get {
                return this.totalCountFieldSpecified;
            }
            set {
                this.totalCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize {
            get {
                return this.pageSizeField;
            }
            set {
                this.pageSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified {
            get {
                return this.pageSizeFieldSpecified;
            }
            set {
                this.pageSizeFieldSpecified = value;
            }
        }
    }
}
