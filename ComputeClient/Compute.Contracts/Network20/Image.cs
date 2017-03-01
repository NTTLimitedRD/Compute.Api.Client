﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace DD.CBU.Compute.Api.Contracts.Network20
{
    using System.Xml.Serialization;

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof (CustomerImageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof (OsImageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageType
    {

        private string nameField;

        private string descriptionField;

        private CpuType cpuField;

        private uint memoryGbField;
        
        private string[] softwareLabelField;

        private System.DateTime createTimeField;

        private string idField;

        private string datacenterIdField;

        private ClusterType clusterField;

        private ImageTypeNic[] nicField;

        private ImageScsiControllerType[] scsiControllerField;

        private ImageSataControllerType[] sataControllerField;

        private ImageIdeControllerType ideControllerField;

        private ImageFloppyControllerType floppyControllerField;

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public CpuType cpu
        {
            get { return this.cpuField; }
            set { this.cpuField = value; }
        }

        /// <remarks/>
        public uint memoryGb
        {
            get { return this.memoryGbField; }
            set { this.memoryGbField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scsiController")]
        public ImageScsiControllerType[] scsiController
        {
            get { return this.scsiControllerField; }
            set { this.scsiControllerField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sataController")]
        public ImageSataControllerType[] sataController
        {
            get { return this.sataControllerField; }
            set { this.sataControllerField = value; }
        }

        /// <remarks/>
        public ImageIdeControllerType ideController
        {
            get { return this.ideControllerField; }
            set { this.ideControllerField = value; }
        }

        /// <remarks/>
        public ImageFloppyControllerType floppyController
        {
            get { return this.floppyControllerField; }
            set { this.floppyControllerField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("softwareLabel")]
        public string[] softwareLabel
        {
            get { return this.softwareLabelField; }
            set { this.softwareLabelField = value; }
        }

        /// <remarks/>
        public System.DateTime createTime
        {
            get { return this.createTimeField; }
            set { this.createTimeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datacenterId
        {
            get { return this.datacenterIdField; }
            set { this.datacenterIdField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cluster")]
        public ClusterType cluster
        {
            get { return this.clusterField; }
            set { this.clusterField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nic")]
        public ImageTypeNic[] nic
        {
            get { return this.nicField; }
            set { this.nicField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageTypeDisk
    {

        private string idField;

        private int scsiIdField;

        private int sizeGbField;

        private string speedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int scsiId
        {
            get { return this.scsiIdField; }
            set { this.scsiIdField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb
        {
            get { return this.sizeGbField; }
            set { this.sizeGbField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed
        {
            get { return this.speedField; }
            set { this.speedField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ClusterType
    {
        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageTypeNic
    {
        private string networkAdapterField;

        private string keyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkAdapter
        {
            get { return this.networkAdapterField; }
            set { this.networkAdapterField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key
        {
            get { return this.keyField; }
            set { this.keyField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class customerImages
    {

        private CustomerImageType[] customerImageField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customerImage")]
        public CustomerImageType[] customerImage
        {
            get { return this.customerImageField; }
            set { this.customerImageField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber
        {
            get { return this.pageNumberField; }
            set { this.pageNumberField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified
        {
            get { return this.pageNumberFieldSpecified; }
            set { this.pageNumberFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount
        {
            get { return this.pageCountField; }
            set { this.pageCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified
        {
            get { return this.pageCountFieldSpecified; }
            set { this.pageCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount
        {
            get { return this.totalCountField; }
            set { this.totalCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified
        {
            get { return this.totalCountFieldSpecified; }
            set { this.totalCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize
        {
            get { return this.pageSizeField; }
            set { this.pageSizeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified
        {
            get { return this.pageSizeFieldSpecified; }
            set { this.pageSizeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("customerImage", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class CustomerImageType : ImageType
    {

        private CustomerImageTypeSource sourceField;

        private string stateField;

        private GuestType guestField;

        private ProgressType progressField;

        private VirtualHardwareType virtualHardwareField;

        private TagWithIdAndNameType[] tagField;

        /// <remarks/>
        public CustomerImageTypeSource source
        {
            get { return this.sourceField; }
            set { this.sourceField = value; }
        }

        /// <remarks/>
        public string state
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <remarks/>
        public ProgressType progress
        {
            get { return this.progressField; }
            set { this.progressField = value; }
        }

        /// <remarks/>
        public VirtualHardwareType virtualHardware
        {
            get { return this.virtualHardwareField; }
            set { this.virtualHardwareField = value; }
        }

        /// <remarks/>
        public GuestType guest
        {
            get { return this.guestField; }
            set { this.guestField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")]
        public TagWithIdAndNameType[] tag
        {
            get { return this.tagField; }
            set { this.tagField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class GuestType
    {
        private OperatingSystemType operatingSystemField;

        private VmToolsType vmToolsField;

        private bool osCustomizationField;

        /// <remarks/>
        public OperatingSystemType operatingSystem
        {
            get { return this.operatingSystemField; }
            set { this.operatingSystemField = value; }
        }

        /// <remarks/>
        public VmToolsType vmTools
        {
            get { return this.vmToolsField; }
            set { this.vmToolsField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool osCustomization
        {
            get { return this.osCustomizationField; }
            set { this.osCustomizationField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class VmToolsType
    {
        private string typeField;

        private string versionStatusField;

        private string runningStatusField;

        private int apiVersionField;

        private bool apiVersionSpecifiedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versionStatus
        {
            get { return this.versionStatusField; }
            set { this.versionStatusField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string runningStatus
        {
            get { return this.runningStatusField; }
            set { this.runningStatusField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int apiVersion
        {
            get { return this.apiVersionField; }
            set { this.apiVersionField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool apiVersionSpecified
        {
            get { return this.apiVersionSpecifiedField; }
            set { this.apiVersionSpecifiedField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class CustomerImageTypeSource
    {

        private CustomerImageTypeSourceArtifact[] artifactField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("artifact")]
        public CustomerImageTypeSourceArtifact[] artifact
        {
            get { return this.artifactField; }
            set { this.artifactField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class CustomerImageTypeSourceArtifact
    {

        private string typeField;

        private string valueField;

        private System.DateTime dateField;

        private bool dateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime date
        {
            get { return this.dateField; }
            set { this.dateField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified
        {
            get { return this.dateFieldSpecified; }
            set { this.dateFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class osImages
    {

        private OsImageType[] osImageField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("osImage")]
        public OsImageType[] osImage
        {
            get { return this.osImageField; }
            set { this.osImageField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber
        {
            get { return this.pageNumberField; }
            set { this.pageNumberField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified
        {
            get { return this.pageNumberFieldSpecified; }
            set { this.pageNumberFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount
        {
            get { return this.pageCountField; }
            set { this.pageCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified
        {
            get { return this.pageCountFieldSpecified; }
            set { this.pageCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount
        {
            get { return this.totalCountField; }
            set { this.totalCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified
        {
            get { return this.totalCountFieldSpecified; }
            set { this.totalCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize
        {
            get { return this.pageSizeField; }
            set { this.pageSizeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified
        {
            get { return this.pageSizeFieldSpecified; }
            set { this.pageSizeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("osImage", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class OsImageType : ImageType
    {

        private string osImageKeyField;

        private int sortOrderField;

        private OsImageTypeGuest guestField;

        /// <remarks/>
        public string osImageKey
        {
            get { return this.osImageKeyField; }
            set { this.osImageKeyField = value; }
        }

        /// <remarks/>
        public int sortOrder
        {
            get { return this.sortOrderField; }
            set { this.sortOrderField = value; }
        }

        /// <remarks/>
        public OsImageTypeGuest guest
        {
            get { return this.guestField; }
            set { this.guestField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("osImage", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class OsImageTypeGuest
    {
        private OperatingSystemType operatingSystemField;

        private bool osCustomizationField;

        /// <remarks/>
        public OperatingSystemType operatingSystem
        {
            get { return this.operatingSystemField; }
            set { this.operatingSystemField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool osCustomization
        {
            get { return this.osCustomizationField; }
            set { this.osCustomizationField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("imageMetadata", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class ImageMetadataType
    {

        private string descriptionField;

        private string cpuSpeedField;

        private string operatingSystemIdField;

        private ImageMetadataTypeDisk[] diskField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string cpuSpeed
        {
            get { return this.cpuSpeedField; }
            set { this.cpuSpeedField = value; }
        }

        /// <remarks/>
        public string operatingSystemId
        {
            get { return this.operatingSystemIdField; }
            set { this.operatingSystemIdField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("disk")]
        public ImageMetadataTypeDisk[] disk
        {
            get { return this.diskField; }
            set { this.diskField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ImageMetadataTypeDisk
    {

        private ushort scsiIdField;

        private string speedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort scsiId
        {
            get { return this.scsiIdField; }
            set { this.scsiIdField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed
        {
            get { return this.speedField; }
            set { this.speedField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class operatingSystems
    {

        private OperatingSystemDetailType[] operatingSystemField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("operatingSystem")]
        public OperatingSystemDetailType[] operatingSystem
        {
            get { return this.operatingSystemField; }
            set { this.operatingSystemField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber
        {
            get { return this.pageNumberField; }
            set { this.pageNumberField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified
        {
            get { return this.pageNumberFieldSpecified; }
            set { this.pageNumberFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount
        {
            get { return this.pageCountField; }
            set { this.pageCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified
        {
            get { return this.pageCountFieldSpecified; }
            set { this.pageCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount
        {
            get { return this.totalCountField; }
            set { this.totalCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified
        {
            get { return this.totalCountFieldSpecified; }
            set { this.totalCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize
        {
            get { return this.pageSizeField; }
            set { this.pageSizeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified
        {
            get { return this.pageSizeFieldSpecified; }
            set { this.pageSizeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("editImageMetadata", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class EditImageMetadataType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string description;

        /// <remarks/>
        public string cpuSpeed;

        /// <remarks/>
        public string operatingSystemId;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("disk")]
        public EditImageMetadataTypeDisk[] disk;

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
    public partial class EditImageMetadataTypeDisk
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed;
    }
}
