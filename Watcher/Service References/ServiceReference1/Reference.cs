﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Watcher.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemSql", Namespace="http://schemas.datacontract.org/2004/07/WcfDataService")]
    [System.SerializableAttribute()]
    public partial class ItemSql : Watcher.ServiceReference1.ItemSqlSimple {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short DataTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FormatValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MaxValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MinValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TimeOutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool TrendField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnitField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DataName {
            get {
                return this.DataNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DataNameField, value) != true)) {
                    this.DataNameField = value;
                    this.RaisePropertyChanged("DataName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short DataType {
            get {
                return this.DataTypeField;
            }
            set {
                if ((this.DataTypeField.Equals(value) != true)) {
                    this.DataTypeField = value;
                    this.RaisePropertyChanged("DataType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FormatValue {
            get {
                return this.FormatValueField;
            }
            set {
                if ((object.ReferenceEquals(this.FormatValueField, value) != true)) {
                    this.FormatValueField = value;
                    this.RaisePropertyChanged("FormatValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MaxValue {
            get {
                return this.MaxValueField;
            }
            set {
                if ((this.MaxValueField.Equals(value) != true)) {
                    this.MaxValueField = value;
                    this.RaisePropertyChanged("MaxValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MinValue {
            get {
                return this.MinValueField;
            }
            set {
                if ((this.MinValueField.Equals(value) != true)) {
                    this.MinValueField = value;
                    this.RaisePropertyChanged("MinValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TimeOut {
            get {
                return this.TimeOutField;
            }
            set {
                if ((this.TimeOutField.Equals(value) != true)) {
                    this.TimeOutField = value;
                    this.RaisePropertyChanged("TimeOut");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Trend {
            get {
                return this.TrendField;
            }
            set {
                if ((this.TrendField.Equals(value) != true)) {
                    this.TrendField = value;
                    this.RaisePropertyChanged("Trend");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Unit {
            get {
                return this.UnitField;
            }
            set {
                if ((object.ReferenceEquals(this.UnitField, value) != true)) {
                    this.UnitField = value;
                    this.RaisePropertyChanged("Unit");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemSqlTrend", Namespace="http://schemas.datacontract.org/2004/07/WcfDataService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Watcher.ServiceReference1.ItemSqlSimple))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Watcher.ServiceReference1.ItemSql))]
    public partial class ItemSqlTrend : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double DataValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SqlTimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double DataValue {
            get {
                return this.DataValueField;
            }
            set {
                if ((this.DataValueField.Equals(value) != true)) {
                    this.DataValueField = value;
                    this.RaisePropertyChanged("DataValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SqlTime {
            get {
                return this.SqlTimeField;
            }
            set {
                if ((this.SqlTimeField.Equals(value) != true)) {
                    this.SqlTimeField = value;
                    this.RaisePropertyChanged("SqlTime");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemSqlSimple", Namespace="http://schemas.datacontract.org/2004/07/WcfDataService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Watcher.ServiceReference1.ItemSql))]
    public partial class ItemSqlSimple : Watcher.ServiceReference1.ItemSqlTrend {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DeviceTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short QualityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DeviceTime {
            get {
                return this.DeviceTimeField;
            }
            set {
                if ((this.DeviceTimeField.Equals(value) != true)) {
                    this.DeviceTimeField = value;
                    this.RaisePropertyChanged("DeviceTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Quality {
            get {
                return this.QualityField;
            }
            set {
                if ((this.QualityField.Equals(value) != true)) {
                    this.QualityField = value;
                    this.RaisePropertyChanged("Quality");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemSqlTrends", Namespace="http://schemas.datacontract.org/2004/07/WcfDataService")]
    [System.SerializableAttribute()]
    public partial class ItemSqlTrends : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MaxValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MinValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Watcher.ServiceReference1.ItemSqlTrend[] RecordsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MaxValue {
            get {
                return this.MaxValueField;
            }
            set {
                if ((this.MaxValueField.Equals(value) != true)) {
                    this.MaxValueField = value;
                    this.RaisePropertyChanged("MaxValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MinValue {
            get {
                return this.MinValueField;
            }
            set {
                if ((this.MinValueField.Equals(value) != true)) {
                    this.MinValueField = value;
                    this.RaisePropertyChanged("MinValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Watcher.ServiceReference1.ItemSqlTrend[] Records {
            get {
                return this.RecordsField;
            }
            set {
                if ((object.ReferenceEquals(this.RecordsField, value) != true)) {
                    this.RecordsField = value;
                    this.RaisePropertyChanged("Records");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TIDELOGEx", Namespace="http://schemas.datacontract.org/2004/07/WcfDataService")]
    [System.SerializableAttribute()]
    public partial class TIDELOGEx : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KMAZSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LitersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SqlTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TDTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TankDensityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TankLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TankTemperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TankTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TankVolumeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Car {
            get {
                return this.CarField;
            }
            set {
                if ((object.ReferenceEquals(this.CarField, value) != true)) {
                    this.CarField = value;
                    this.RaisePropertyChanged("Car");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KMAZS {
            get {
                return this.KMAZSField;
            }
            set {
                if ((object.ReferenceEquals(this.KMAZSField, value) != true)) {
                    this.KMAZSField = value;
                    this.RaisePropertyChanged("KMAZS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Liters {
            get {
                return this.LitersField;
            }
            set {
                if ((this.LitersField.Equals(value) != true)) {
                    this.LitersField = value;
                    this.RaisePropertyChanged("Liters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operator {
            get {
                return this.OperatorField;
            }
            set {
                if ((object.ReferenceEquals(this.OperatorField, value) != true)) {
                    this.OperatorField = value;
                    this.RaisePropertyChanged("Operator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SqlTime {
            get {
                return this.SqlTimeField;
            }
            set {
                if ((this.SqlTimeField.Equals(value) != true)) {
                    this.SqlTimeField = value;
                    this.RaisePropertyChanged("SqlTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TDTime {
            get {
                return this.TDTimeField;
            }
            set {
                if ((this.TDTimeField.Equals(value) != true)) {
                    this.TDTimeField = value;
                    this.RaisePropertyChanged("TDTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TankDensity {
            get {
                return this.TankDensityField;
            }
            set {
                if ((this.TankDensityField.Equals(value) != true)) {
                    this.TankDensityField = value;
                    this.RaisePropertyChanged("TankDensity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TankLevel {
            get {
                return this.TankLevelField;
            }
            set {
                if ((this.TankLevelField.Equals(value) != true)) {
                    this.TankLevelField = value;
                    this.RaisePropertyChanged("TankLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TankTemperature {
            get {
                return this.TankTemperatureField;
            }
            set {
                if ((this.TankTemperatureField.Equals(value) != true)) {
                    this.TankTemperatureField = value;
                    this.RaisePropertyChanged("TankTemperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TankTime {
            get {
                return this.TankTimeField;
            }
            set {
                if ((this.TankTimeField.Equals(value) != true)) {
                    this.TankTimeField = value;
                    this.RaisePropertyChanged("TankTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TankVolume {
            get {
                return this.TankVolumeField;
            }
            set {
                if ((this.TankVolumeField.Equals(value) != true)) {
                    this.TankVolumeField = value;
                    this.RaisePropertyChanged("TankVolume");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetItemsFull", ReplyAction="http://tempuri.org/IDataService/GetItemsFullResponse")]
        Watcher.ServiceReference1.ItemSql[] GetItemsFull();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetItemsShort", ReplyAction="http://tempuri.org/IDataService/GetItemsShortResponse")]
        Watcher.ServiceReference1.ItemSqlSimple[] GetItemsShort();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetItemsShortByDataNames", ReplyAction="http://tempuri.org/IDataService/GetItemsShortByDataNamesResponse")]
        Watcher.ServiceReference1.ItemSqlSimple[] GetItemsShortByDataNames(string[] dataNames);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetTrends", ReplyAction="http://tempuri.org/IDataService/GetTrendsResponse")]
        Watcher.ServiceReference1.ItemSqlTrends GetTrends(string tableName, int type, System.DateTime dateBegin, System.DateTime dateEnd, int timePeriod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetSqlCurrentTime", ReplyAction="http://tempuri.org/IDataService/GetSqlCurrentTimeResponse")]
        System.DateTime GetSqlCurrentTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetVersion", ReplyAction="http://tempuri.org/IDataService/GetVersionResponse")]
        string GetVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetDateTimeOffset", ReplyAction="http://tempuri.org/IDataService/GetDateTimeOffsetResponse")]
        System.DateTimeOffset GetDateTimeOffset();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SetClientInfoFull", ReplyAction="http://tempuri.org/IDataService/SetClientInfoFullResponse")]
        bool SetClientInfoFull(string quid, string ipAddress, string version, System.DateTime clientTime, string browserInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SetClientInfoShort", ReplyAction="http://tempuri.org/IDataService/SetClientInfoShortResponse")]
        bool SetClientInfoShort(string quid, System.DateTime clientTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetMTBTIDELOGs", ReplyAction="http://tempuri.org/IDataService/GetMTBTIDELOGsResponse")]
        Watcher.ServiceReference1.TIDELOGEx[] GetMTBTIDELOGs(string tableName, System.DateTime dateBegin, System.DateTime dateEnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetServiceInfo", ReplyAction="http://tempuri.org/IDataService/GetServiceInfoResponse")]
        string GetServiceInfo();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : Watcher.ServiceReference1.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<Watcher.ServiceReference1.IDataService>, Watcher.ServiceReference1.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Watcher.ServiceReference1.ItemSql[] GetItemsFull() {
            return base.Channel.GetItemsFull();
        }
        
        public Watcher.ServiceReference1.ItemSqlSimple[] GetItemsShort() {
            return base.Channel.GetItemsShort();
        }
        
        public Watcher.ServiceReference1.ItemSqlSimple[] GetItemsShortByDataNames(string[] dataNames) {
            return base.Channel.GetItemsShortByDataNames(dataNames);
        }
        
        public Watcher.ServiceReference1.ItemSqlTrends GetTrends(string tableName, int type, System.DateTime dateBegin, System.DateTime dateEnd, int timePeriod) {
            return base.Channel.GetTrends(tableName, type, dateBegin, dateEnd, timePeriod);
        }
        
        public System.DateTime GetSqlCurrentTime() {
            return base.Channel.GetSqlCurrentTime();
        }
        
        public string GetVersion() {
            return base.Channel.GetVersion();
        }
        
        public System.DateTimeOffset GetDateTimeOffset() {
            return base.Channel.GetDateTimeOffset();
        }
        
        public bool SetClientInfoFull(string quid, string ipAddress, string version, System.DateTime clientTime, string browserInformation) {
            return base.Channel.SetClientInfoFull(quid, ipAddress, version, clientTime, browserInformation);
        }
        
        public bool SetClientInfoShort(string quid, System.DateTime clientTime) {
            return base.Channel.SetClientInfoShort(quid, clientTime);
        }
        
        public Watcher.ServiceReference1.TIDELOGEx[] GetMTBTIDELOGs(string tableName, System.DateTime dateBegin, System.DateTime dateEnd) {
            return base.Channel.GetMTBTIDELOGs(tableName, dateBegin, dateEnd);
        }
        
        public string GetServiceInfo() {
            return base.Channel.GetServiceInfo();
        }
    }
}