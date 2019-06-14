namespace DD.CBU.Compute.Api.Contracts.Server
{

    using DD.CBU.Compute.Api.Contracts.Network20;

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoricalServerConfigurationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationType
    {

        private ServerConfigurationTypeCluster clusterField;

        private CpuType cpuField;

        private uint memoryGbField;

        private NameValuePairType[] advancedVirtualizationSettingField;

        private ServerConfigurationTypeScsiController[] scsiControllerField;

        private ServerConfigurationTypeSataController[] sataControllerField;

        private ServerConfigurationTypeIdeController[] ideControllerField;

        private ServerConfigurationTypeFloppy[] floppyField;

        private ServerConfigurationTypeNetworkInfo networkInfoField;

        private string[] specialTraitField;

        private string[] softwareLabelField;

        private ServerConfigurationTypeGuest guestField;

        private string virtualHardwareVersionField;

        /// <remarks/>
        public ServerConfigurationTypeCluster cluster
        {
            get
            {
                return this.clusterField;
            }
            set
            {
                this.clusterField = value;
            }
        }

        /// <remarks/>
        public CpuType cpu
        {
            get
            {
                return this.cpuField;
            }
            set
            {
                this.cpuField = value;
            }
        }

        /// <remarks/>
        public uint memoryGb
        {
            get
            {
                return this.memoryGbField;
            }
            set
            {
                this.memoryGbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("advancedVirtualizationSetting")]
        public NameValuePairType[] advancedVirtualizationSetting
        {
            get
            {
                return this.advancedVirtualizationSettingField;
            }
            set
            {
                this.advancedVirtualizationSettingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scsiController")]
        public ServerConfigurationTypeScsiController[] scsiController
        {
            get
            {
                return this.scsiControllerField;
            }
            set
            {
                this.scsiControllerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sataController")]
        public ServerConfigurationTypeSataController[] sataController
        {
            get
            {
                return this.sataControllerField;
            }
            set
            {
                this.sataControllerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ideController")]
        public ServerConfigurationTypeIdeController[] ideController
        {
            get
            {
                return this.ideControllerField;
            }
            set
            {
                this.ideControllerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("floppy")]
        public ServerConfigurationTypeFloppy[] floppy
        {
            get
            {
                return this.floppyField;
            }
            set
            {
                this.floppyField = value;
            }
        }

        /// <remarks/>
        public ServerConfigurationTypeNetworkInfo networkInfo
        {
            get
            {
                return this.networkInfoField;
            }
            set
            {
                this.networkInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("specialTrait")]
        public string[] specialTrait
        {
            get
            {
                return this.specialTraitField;
            }
            set
            {
                this.specialTraitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("softwareLabel")]
        public string[] softwareLabel
        {
            get
            {
                return this.softwareLabelField;
            }
            set
            {
                this.softwareLabelField = value;
            }
        }

        /// <remarks/>
        public ServerConfigurationTypeGuest guest
        {
            get
            {
                return this.guestField;
            }
            set
            {
                this.guestField = value;
            }
        }

        /// <remarks/>
        public string virtualHardwareVersion
        {
            get
            {
                return this.virtualHardwareVersionField;
            }
            set
            {
                this.virtualHardwareVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeCluster
    {

        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class CpuType
    {

        private uint countField;

        private string speedField;

        private uint coresPerSocketField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint coresPerSocket
        {
            get
            {
                return this.coresPerSocketField;
            }
            set
            {
                this.coresPerSocketField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeScsiController
    {

        private ServerConfigurationTypeScsiControllerDisk[] diskField;

        private string idField;

        private string adapterTypeField;

        private string stateField;

        private int busNumberField;

        private bool busNumberFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("disk")]
        public ServerConfigurationTypeScsiControllerDisk[] disk
        {
            get
            {
                return this.diskField;
            }
            set
            {
                this.diskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string adapterType
        {
            get
            {
                return this.adapterTypeField;
            }
            set
            {
                this.adapterTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int busNumber
        {
            get
            {
                return this.busNumberField;
            }
            set
            {
                this.busNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool busNumberSpecified
        {
            get
            {
                return this.busNumberFieldSpecified;
            }
            set
            {
                this.busNumberFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeScsiControllerDisk
    {

        private string idField;

        private int sizeGbField;

        private string speedField;

        private int iopsField;

        private bool iopsFieldSpecified;

        private string driveTypeField;

        private string stateField;

        private int scsiIdField;

        private bool scsiIdFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb
        {
            get
            {
                return this.sizeGbField;
            }
            set
            {
                this.sizeGbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int iops
        {
            get
            {
                return this.iopsField;
            }
            set
            {
                this.iopsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iopsSpecified
        {
            get
            {
                return this.iopsFieldSpecified;
            }
            set
            {
                this.iopsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string driveType
        {
            get
            {
                return this.driveTypeField;
            }
            set
            {
                this.driveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int scsiId
        {
            get
            {
                return this.scsiIdField;
            }
            set
            {
                this.scsiIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scsiIdSpecified
        {
            get
            {
                return this.scsiIdFieldSpecified;
            }
            set
            {
                this.scsiIdFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeSataController
    {

        private object[] itemsField;

        private string idField;

        private string adapterTypeField;

        private string stateField;

        private int busNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device", typeof(ServerConfigurationTypeSataControllerDevice))]
        [System.Xml.Serialization.XmlElementAttribute("disk", typeof(ServerConfigurationTypeSataControllerDisk))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string adapterType
        {
            get
            {
                return this.adapterTypeField;
            }
            set
            {
                this.adapterTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int busNumber
        {
            get
            {
                return this.busNumberField;
            }
            set
            {
                this.busNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeSataControllerDevice
    {

        private string idField;

        private string typeField;

        private int sizeGbField;

        private bool sizeGbFieldSpecified;

        private string fileNameField;

        private string driveTypeField;

        private string stateField;

        private int sataIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb
        {
            get
            {
                return this.sizeGbField;
            }
            set
            {
                this.sizeGbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeGbSpecified
        {
            get
            {
                return this.sizeGbFieldSpecified;
            }
            set
            {
                this.sizeGbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string driveType
        {
            get
            {
                return this.driveTypeField;
            }
            set
            {
                this.driveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sataId
        {
            get
            {
                return this.sataIdField;
            }
            set
            {
                this.sataIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeSataControllerDisk
    {

        private string idField;

        private int sizeGbField;

        private string speedField;

        private int iopsField;

        private bool iopsFieldSpecified;

        private string driveTypeField;

        private string stateField;

        private int sataIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb
        {
            get
            {
                return this.sizeGbField;
            }
            set
            {
                this.sizeGbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int iops
        {
            get
            {
                return this.iopsField;
            }
            set
            {
                this.iopsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iopsSpecified
        {
            get
            {
                return this.iopsFieldSpecified;
            }
            set
            {
                this.iopsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string driveType
        {
            get
            {
                return this.driveTypeField;
            }
            set
            {
                this.driveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sataId
        {
            get
            {
                return this.sataIdField;
            }
            set
            {
                this.sataIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeIdeController
    {

        private object[] itemsField;

        private string idField;

        private string adapterTypeField;

        private string stateField;

        private int channelField;

        private bool channelFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device", typeof(ServerConfigurationTypeIdeControllerDevice))]
        [System.Xml.Serialization.XmlElementAttribute("disk", typeof(ServerConfigurationTypeIdeControllerDisk))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string adapterType
        {
            get
            {
                return this.adapterTypeField;
            }
            set
            {
                this.adapterTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool channelSpecified
        {
            get
            {
                return this.channelFieldSpecified;
            }
            set
            {
                this.channelFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeIdeControllerDevice
    {

        private string idField;

        private string typeField;

        private int sizeGbField;

        private bool sizeGbFieldSpecified;

        private string fileNameField;

        private string driveTypeField;

        private string stateField;

        private int slotField;

        private bool slotFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb
        {
            get
            {
                return this.sizeGbField;
            }
            set
            {
                this.sizeGbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeGbSpecified
        {
            get
            {
                return this.sizeGbFieldSpecified;
            }
            set
            {
                this.sizeGbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string driveType
        {
            get
            {
                return this.driveTypeField;
            }
            set
            {
                this.driveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int slot
        {
            get
            {
                return this.slotField;
            }
            set
            {
                this.slotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool slotSpecified
        {
            get
            {
                return this.slotFieldSpecified;
            }
            set
            {
                this.slotFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeIdeControllerDisk
    {

        private string idField;

        private int sizeGbField;

        private string speedField;

        private int iopsField;

        private bool iopsFieldSpecified;

        private string driveTypeField;

        private string stateField;

        private int slotField;

        private bool slotFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb
        {
            get
            {
                return this.sizeGbField;
            }
            set
            {
                this.sizeGbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int iops
        {
            get
            {
                return this.iopsField;
            }
            set
            {
                this.iopsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iopsSpecified
        {
            get
            {
                return this.iopsFieldSpecified;
            }
            set
            {
                this.iopsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string driveType
        {
            get
            {
                return this.driveTypeField;
            }
            set
            {
                this.driveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int slot
        {
            get
            {
                return this.slotField;
            }
            set
            {
                this.slotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool slotSpecified
        {
            get
            {
                return this.slotFieldSpecified;
            }
            set
            {
                this.slotFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeFloppy
    {

        private string idField;

        private int driveNumberField;

        private int sizeGbField;

        private bool sizeGbFieldSpecified;

        private string fileNameField;

        private string stateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int driveNumber
        {
            get
            {
                return this.driveNumberField;
            }
            set
            {
                this.driveNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sizeGb
        {
            get
            {
                return this.sizeGbField;
            }
            set
            {
                this.sizeGbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeGbSpecified
        {
            get
            {
                return this.sizeGbFieldSpecified;
            }
            set
            {
                this.sizeGbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeNetworkInfo
    {

        private ServerConfigurationTypeNetworkInfoPrimaryNic primaryNicField;

        private ServerConfigurationTypeNetworkInfoAdditionalNic[] additionalNicField;

        private string networkDomainIdField;

        private string networkDomainNameField;

        /// <remarks/>
        public ServerConfigurationTypeNetworkInfoPrimaryNic primaryNic
        {
            get
            {
                return this.primaryNicField;
            }
            set
            {
                this.primaryNicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalNic")]
        public ServerConfigurationTypeNetworkInfoAdditionalNic[] additionalNic
        {
            get
            {
                return this.additionalNicField;
            }
            set
            {
                this.additionalNicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkDomainId
        {
            get
            {
                return this.networkDomainIdField;
            }
            set
            {
                this.networkDomainIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkDomainName
        {
            get
            {
                return this.networkDomainNameField;
            }
            set
            {
                this.networkDomainNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeNetworkInfoPrimaryNic
    {

        private string idField;

        private string privateIpv4Field;

        private string ipv6Field;

        private string vlanIdField;

        private string vlanNameField;

        private string networkAdapterField;

        private bool connectedField;

        private int keyField;

        private string stateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string privateIpv4
        {
            get
            {
                return this.privateIpv4Field;
            }
            set
            {
                this.privateIpv4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ipv6
        {
            get
            {
                return this.ipv6Field;
            }
            set
            {
                this.ipv6Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vlanId
        {
            get
            {
                return this.vlanIdField;
            }
            set
            {
                this.vlanIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vlanName
        {
            get
            {
                return this.vlanNameField;
            }
            set
            {
                this.vlanNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkAdapter
        {
            get
            {
                return this.networkAdapterField;
            }
            set
            {
                this.networkAdapterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool connected
        {
            get
            {
                return this.connectedField;
            }
            set
            {
                this.connectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeNetworkInfoAdditionalNic
    {

        private string idField;

        private string privateIpv4Field;

        private string ipv6Field;

        private string vlanIdField;

        private string vlanNameField;

        private string networkAdapterField;

        private bool connectedField;

        private int keyField;

        private string stateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string privateIpv4
        {
            get
            {
                return this.privateIpv4Field;
            }
            set
            {
                this.privateIpv4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ipv6
        {
            get
            {
                return this.ipv6Field;
            }
            set
            {
                this.ipv6Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vlanId
        {
            get
            {
                return this.vlanIdField;
            }
            set
            {
                this.vlanIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vlanName
        {
            get
            {
                return this.vlanNameField;
            }
            set
            {
                this.vlanNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkAdapter
        {
            get
            {
                return this.networkAdapterField;
            }
            set
            {
                this.networkAdapterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool connected
        {
            get
            {
                return this.connectedField;
            }
            set
            {
                this.connectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeGuest
    {

        private ServerConfigurationTypeGuestOperatingSystem operatingSystemField;

        private bool osCustomizationField;

        /// <remarks/>
        public ServerConfigurationTypeGuestOperatingSystem operatingSystem
        {
            get
            {
                return this.operatingSystemField;
            }
            set
            {
                this.operatingSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool osCustomization
        {
            get
            {
                return this.osCustomizationField;
            }
            set
            {
                this.osCustomizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ServerConfigurationTypeGuestOperatingSystem
    {

        private string idField;

        private string displayNameField;

        private string familyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }
    }
}
