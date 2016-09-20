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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class MonitoringType
    {

        private PropertyType[] propertyField;

        private string maintenanceStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public PropertyType[] property
        {
            get { return this.propertyField; }
            set { this.propertyField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maintenanceStatus
        {
            get { return this.maintenanceStatusField; }
            set { this.maintenanceStatusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class PropertyType
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ConsoleAccessType
    {

        private PropertyType[] propertyField;

        private string maintenanceStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public PropertyType[] property
        {
            get { return this.propertyField; }
            set { this.propertyField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maintenanceStatus
        {
            get { return this.maintenanceStatusField; }
            set { this.maintenanceStatusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class BackupType
    {

        private PropertyType[] propertyField;

        private string typeField;

        private string maintenanceStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public PropertyType[] property
        {
            get { return this.propertyField; }
            set { this.propertyField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maintenanceStatus
        {
            get { return this.maintenanceStatusField; }
            set { this.maintenanceStatusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class CpuSpeedType
    {

        private string displayNameField;

        private string descriptionField;

        private string unavailableReasonField;

        private string idField;

        private bool defaultField;

        private bool availableField;

        /// <remarks/>
        public string displayName
        {
            get { return this.displayNameField; }
            set { this.displayNameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string unavailableReason
        {
            get { return this.unavailableReasonField; }
            set { this.unavailableReasonField = value; }
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
        public bool @default
        {
            get { return this.defaultField; }
            set { this.defaultField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool available
        {
            get { return this.availableField; }
            set { this.availableField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class DiskSpeedType
    {

        private string displayNameField;

        private string abbreviationField;

        private string descriptionField;

        private string unavailableReasonField;

        private string idField;

        private bool defaultField;

        private bool availableField;

        /// <remarks/>
        public string displayName
        {
            get { return this.displayNameField; }
            set { this.displayNameField = value; }
        }

        /// <remarks/>
        public string abbreviation
        {
            get { return this.abbreviationField; }
            set { this.abbreviationField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string unavailableReason
        {
            get { return this.unavailableReasonField; }
            set { this.unavailableReasonField = value; }
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
        public bool @default
        {
            get { return this.defaultField; }
            set { this.defaultField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool available
        {
            get { return this.availableField; }
            set { this.availableField = value; }
        }
    }

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class ClusterType
	{

		private string displayNameField;

		private string descriptionField;

		private PropertyType[] propertyField;

		private string idField;

		private bool defaultField;

		/// <remarks/>
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
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("property")]
		public PropertyType[] property
		{
			get
			{
				return this.propertyField;
			}
			set
			{
				this.propertyField = value;
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
		public bool @default
		{
			get
			{
				return this.defaultField;
			}
			set
			{
				this.defaultField = value;
			}
		}
	}


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class HypervisorType
    {

        private DiskSpeedType[] diskSpeedField;

        private CpuSpeedType[] cpuSpeedField;

		private ClusterType[] clusterField;

		private PropertyType[] propertyField;

        private string typeField;

        private string maintenanceStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("diskSpeed")]
        public DiskSpeedType[] diskSpeed
        {
            get { return this.diskSpeedField; }
            set { this.diskSpeedField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cpuSpeed")]
        public CpuSpeedType[] cpuSpeed
        {
            get { return this.cpuSpeedField; }
            set { this.cpuSpeedField = value; }
        }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("cluster")]
		public ClusterType[] cluster
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
		[System.Xml.Serialization.XmlElementAttribute("property")]
        public PropertyType[] property
        {
            get { return this.propertyField; }
            set { this.propertyField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maintenanceStatus
        {
            get { return this.maintenanceStatusField; }
            set { this.maintenanceStatusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class NetworkingType
    {

        private PropertyType[] propertyField;

        private string typeField;

        private string maintenanceStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public PropertyType[] property
        {
            get { return this.propertyField; }
            set { this.propertyField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maintenanceStatus
        {
            get { return this.maintenanceStatusField; }
            set { this.maintenanceStatusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class DrsType
    {

        private PropertyType[] propertyField;

        private IdListType targetDatacentersField;

        private string maintenanceStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public PropertyType[] property
        {
            get { return this.propertyField; }
            set { this.propertyField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("targetDatacenters")]
        public IdListType targetDatacenters
        {
            get { return this.targetDatacentersField; }
            set { this.targetDatacentersField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maintenanceStatus
        {
            get { return this.maintenanceStatusField; }
            set { this.maintenanceStatusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class IdListType
    {
        private string listField;

        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public string list
        {
            get { return this.listField; }
            set { this.listField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class DatacenterType
    {

        private string displayNameField;

        private string cityField;

        private string stateField;

        private string countryField;

        private string vpnUrlField;

        private string ftpsHostField;

        private NetworkingType networkingField;

        private HypervisorType hypervisorField;

        private BackupType backupField;

        private ConsoleAccessType consoleAccessField;

        private MonitoringType monitoringField;

        private DrsType drsField;

        private string idField;

        private string typeField;

        /// <remarks/>
        public string displayName
        {
            get { return this.displayNameField; }
            set { this.displayNameField = value; }
        }

        /// <remarks/>
        public string city
        {
            get { return this.cityField; }
            set { this.cityField = value; }
        }

        /// <remarks/>
        public string state
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <remarks/>
        public string country
        {
            get { return this.countryField; }
            set { this.countryField = value; }
        }

        /// <remarks/>
        public string vpnUrl
        {
            get { return this.vpnUrlField; }
            set { this.vpnUrlField = value; }
        }

        /// <remarks/>
        public string ftpsHost
        {
            get { return this.ftpsHostField; }
            set { this.ftpsHostField = value; }
        }

        /// <remarks/>
        public NetworkingType networking
        {
            get { return this.networkingField; }
            set { this.networkingField = value; }
        }

        /// <remarks/>
        public HypervisorType hypervisor
        {
            get { return this.hypervisorField; }
            set { this.hypervisorField = value; }
        }

        /// <remarks/>
        public BackupType backup
        {
            get { return this.backupField; }
            set { this.backupField = value; }
        }

        /// <remarks/>
        public ConsoleAccessType consoleAccess
        {
            get { return this.consoleAccessField; }
            set { this.consoleAccessField = value; }
        }

        /// <remarks/>
        public MonitoringType monitoring
        {
            get { return this.monitoringField; }
            set { this.monitoringField = value; }
        }

        /// <remarks/>
        public DrsType drs
        {
            get { return this.drsField; }
            set { this.drsField = value; }
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class datacenters
    {

        private DatacenterType[] datacenterField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("datacenter")]
        public DatacenterType[] datacenter
        {
            get { return this.datacenterField; }
            set { this.datacenterField = value; }
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
}
