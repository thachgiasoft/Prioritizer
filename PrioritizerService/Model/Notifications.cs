//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace PrioritizerService.Model
{
    [DataContract(IsReference = true)]
    [Serializable]
    [KnownType(typeof(Tenant))]
    public partial class Notifications: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public System.Guid ID
        {
            get { return _iD; }
            set
            {
                if (_iD != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _iD = value;
                    OnPropertyChanged("ID");
                }
            }
        }
        private System.Guid _iD;
    
        [DataMember]
        public Nullable<System.Guid> userID
        {
            get { return _userID; }
            set
            {
                if (_userID != value)
                {
                    ChangeTracker.RecordPropertyChange("userID");
                    _userID = value;
                    OnPropertyChanged("userID");
                }
            }
        }
        private Nullable<System.Guid> _userID;
    
        [DataMember]
        public Nullable<System.Guid> projectID
        {
            get { return _projectID; }
            set
            {
                if (_projectID != value)
                {
                    ChangeTracker.RecordPropertyChange("projectID");
                    _projectID = value;
                    OnPropertyChanged("projectID");
                }
            }
        }
        private Nullable<System.Guid> _projectID;
    
        [DataMember]
        public System.Guid NotificationRecipientID
        {
            get { return _notificationRecipientID; }
            set
            {
                if (_notificationRecipientID != value)
                {
                    ChangeTracker.RecordPropertyChange("NotificationRecipientID");
                    _notificationRecipientID = value;
                    OnPropertyChanged("NotificationRecipientID");
                }
            }
        }
        private System.Guid _notificationRecipientID;
    
        [DataMember]
        public System.Guid NotificationTypeID
        {
            get { return _notificationTypeID; }
            set
            {
                if (_notificationTypeID != value)
                {
                    ChangeTracker.RecordPropertyChange("NotificationTypeID");
                    _notificationTypeID = value;
                    OnPropertyChanged("NotificationTypeID");
                }
            }
        }
        private System.Guid _notificationTypeID;
    
        [DataMember]
        public System.Guid TenantID
        {
            get { return _tenantID; }
            set
            {
                if (_tenantID != value)
                {
                    ChangeTracker.RecordOriginalValue("TenantID", _tenantID);
      if (!IsDeserializing)
      {
                          if (Tenant != null && Tenant.ID != value)
                        {
                            Tenant = null;
                        }
                    }
                    _tenantID = value;
                    OnPropertyChanged("TenantID");
                }
            }
        }
        private System.Guid _tenantID;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Tenant Tenant
        {
            get { return _tenant; }
            set
            {
                if (!ReferenceEquals(_tenant, value))
                {
                    var previousValue = _tenant;
                    _tenant = value;
                    FixupTenant(previousValue);
                    OnNavigationPropertyChanged("Tenant");
                }
            }
        }
        private Tenant _tenant;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            Tenant = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupTenant(Tenant previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Notifications.Contains(this))
            {
                previousValue.Notifications.Remove(this);
            }
    
            if (Tenant != null)
            {
                if (!Tenant.Notifications.Contains(this))
                {
                    Tenant.Notifications.Add(this);
                }
    
                TenantID = Tenant.ID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Tenant")
                    && (ChangeTracker.OriginalValues["Tenant"] == Tenant))
                {
                    ChangeTracker.OriginalValues.Remove("Tenant");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Tenant", previousValue);
                }
                if (Tenant != null && !Tenant.ChangeTracker.ChangeTrackingEnabled)
                {
                    Tenant.StartTracking();
                }
            }
        }

        #endregion
    }
}
