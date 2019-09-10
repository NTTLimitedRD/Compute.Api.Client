using DD.CBU.Compute.Api.Contracts.Network20;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
[System.Xml.Serialization.XmlRootAttribute("reconfigureImage", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
public partial class ReconfigureImageType
{
    /// <remarks/>
    public ReconfigureImageTypeAdvancedVirtualizationSettings advancedVirtualizationSettings;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
public partial class ReconfigureImageTypeAdvancedVirtualizationSettings
{
    /// <remarks/>
    public bool? nestedHardwareVirtualization;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool nestedHardwareVirtualizationSpecified
    {
        get { return this.nestedHardwareVirtualization != null; }
        set { this.nestedHardwareVirtualizationSpecified = value; }
    }

    /// <remarks/>
    public string cpuLatencySensitivity;

    /// <remarks/>
    public bool? numaAutosize;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool numaAutosizeSpecified
    {
        get { return this.numaAutosize != null; }
        set { this.numaAutosizeSpecified = value; }
    }

    /// <remarks/>
    public bool? enableHostInfoToVmTools;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool enableHostInfoToVmToolsSpecified
    {
        get { return this.enableHostInfoToVmTools != null; }
        set { this.enableHostInfoToVmToolsSpecified = value; }
    }
}
