﻿namespace DD.CBU.Compute.Api.Contracts.Image
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("importImage", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class ImportImageType
    {
        /// <remarks/>
        public string ovfPackage;

        /// <remarks/>
        public string name;

        /// <remarks/>
        public string description;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clusterId", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("datacenterId", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        /// <remarks/>
        public bool guestOsCustomization;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool guestOsCustomizationSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        clusterId,

        /// <remarks/>
        datacenterId,
    }
}
