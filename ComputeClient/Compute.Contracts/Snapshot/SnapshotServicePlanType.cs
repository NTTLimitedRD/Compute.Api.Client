using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.CBU.Compute.Api.Contracts.Snapshot
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class SnapshotServicePlanType
	{

		private string displayNameField;

		private string descriptionField;

		private string snapshotFrequencyField;

		private bool supportsReplicationField;

		private bool availableField;

		private string idField;

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
		public string snapshotFrequency
		{
			get
			{
				return this.snapshotFrequencyField;
			}
			set
			{
				this.snapshotFrequencyField = value;
			}
		}

		/// <remarks/>
		public bool supportsReplication
		{
			get
			{
				return this.supportsReplicationField;
			}
			set
			{
				this.supportsReplicationField = value;
			}
		}

		/// <remarks/>
		public bool available
		{
			get
			{
				return this.availableField;
			}
			set
			{
				this.availableField = value;
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
	}
}
