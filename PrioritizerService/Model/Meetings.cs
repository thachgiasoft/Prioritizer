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
    [KnownType(typeof(MeetingTasks))]
    [KnownType(typeof(Users))]
    [KnownType(typeof(MeetingAttendies))]
    [KnownType(typeof(MeetingCategoryMap))]
    [KnownType(typeof(Tenant))]
    public partial class Meetings: IObjectWithChangeTracker, INotifyPropertyChanged
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
        public string MeetingName
        {
            get { return _meetingName; }
            set
            {
                if (_meetingName != value)
                {
                    ChangeTracker.RecordPropertyChange("MeetingName");
                    _meetingName = value;
                    OnPropertyChanged("MeetingName");
                }
            }
        }
        private string _meetingName;
    
        [DataMember]
        public System.Guid MeetingOwner
        {
            get { return _meetingOwner; }
            set
            {
                if (_meetingOwner != value)
                {
                    ChangeTracker.RecordOriginalValue("MeetingOwner", _meetingOwner);
      if (!IsDeserializing)
      {
                          if (Users != null && Users.ID != value)
                        {
                            Users = null;
                        }
                    }
                    _meetingOwner = value;
                    OnPropertyChanged("MeetingOwner");
                }
            }
        }
        private System.Guid _meetingOwner;
    
        [DataMember]
        public Nullable<System.DateTime> MeetingDate
        {
            get { return _meetingDate; }
            set
            {
                if (_meetingDate != value)
                {
                    ChangeTracker.RecordPropertyChange("MeetingDate");
                    _meetingDate = value;
                    OnPropertyChanged("MeetingDate");
                }
            }
        }
        private Nullable<System.DateTime> _meetingDate;
    
        [DataMember]
        public byte[] MeetingSummaryRTF
        {
            get { return _meetingSummaryRTF; }
            set
            {
                if (_meetingSummaryRTF != value)
                {
                    ChangeTracker.RecordPropertyChange("MeetingSummaryRTF");
                    _meetingSummaryRTF = value;
                    OnPropertyChanged("MeetingSummaryRTF");
                }
            }
        }
        private byte[] _meetingSummaryRTF;
    
        [DataMember]
        public Nullable<System.DateTime> updateDate
        {
            get { return _updateDate; }
            set
            {
                if (_updateDate != value)
                {
                    ChangeTracker.RecordOriginalValue("updateDate", _updateDate);
                    _updateDate = value;
                    OnPropertyChanged("updateDate");
                }
            }
        }
        private Nullable<System.DateTime> _updateDate;
    
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
        public TrackableCollection<MeetingTasks> MeetingTasks
        {
            get
            {
                if (_meetingTasks == null)
                {
                    _meetingTasks = new TrackableCollection<MeetingTasks>();
                    _meetingTasks.CollectionChanged += FixupMeetingTasks;
                }
                return _meetingTasks;
            }
            set
            {
                if (!ReferenceEquals(_meetingTasks, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_meetingTasks != null)
                    {
                        _meetingTasks.CollectionChanged -= FixupMeetingTasks;
                    }
                    _meetingTasks = value;
                    if (_meetingTasks != null)
                    {
                        _meetingTasks.CollectionChanged += FixupMeetingTasks;
                    }
                    OnNavigationPropertyChanged("MeetingTasks");
                }
            }
        }
        private TrackableCollection<MeetingTasks> _meetingTasks;
    
        [DataMember]
        public Users Users
        {
            get { return _users; }
            set
            {
                if (!ReferenceEquals(_users, value))
                {
                    var previousValue = _users;
                    _users = value;
                    FixupUsers(previousValue);
                    OnNavigationPropertyChanged("Users");
                }
            }
        }
        private Users _users;
    
        [DataMember]
        public TrackableCollection<MeetingAttendies> MeetingAttendies
        {
            get
            {
                if (_meetingAttendies == null)
                {
                    _meetingAttendies = new TrackableCollection<MeetingAttendies>();
                    _meetingAttendies.CollectionChanged += FixupMeetingAttendies;
                }
                return _meetingAttendies;
            }
            set
            {
                if (!ReferenceEquals(_meetingAttendies, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_meetingAttendies != null)
                    {
                        _meetingAttendies.CollectionChanged -= FixupMeetingAttendies;
                    }
                    _meetingAttendies = value;
                    if (_meetingAttendies != null)
                    {
                        _meetingAttendies.CollectionChanged += FixupMeetingAttendies;
                    }
                    OnNavigationPropertyChanged("MeetingAttendies");
                }
            }
        }
        private TrackableCollection<MeetingAttendies> _meetingAttendies;
    
        [DataMember]
        public TrackableCollection<MeetingCategoryMap> MeetingCategoryMap
        {
            get
            {
                if (_meetingCategoryMap == null)
                {
                    _meetingCategoryMap = new TrackableCollection<MeetingCategoryMap>();
                    _meetingCategoryMap.CollectionChanged += FixupMeetingCategoryMap;
                }
                return _meetingCategoryMap;
            }
            set
            {
                if (!ReferenceEquals(_meetingCategoryMap, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_meetingCategoryMap != null)
                    {
                        _meetingCategoryMap.CollectionChanged -= FixupMeetingCategoryMap;
                    }
                    _meetingCategoryMap = value;
                    if (_meetingCategoryMap != null)
                    {
                        _meetingCategoryMap.CollectionChanged += FixupMeetingCategoryMap;
                    }
                    OnNavigationPropertyChanged("MeetingCategoryMap");
                }
            }
        }
        private TrackableCollection<MeetingCategoryMap> _meetingCategoryMap;
    
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
            MeetingTasks.Clear();
            Users = null;
            MeetingAttendies.Clear();
            MeetingCategoryMap.Clear();
            Tenant = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupUsers(Users previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Meetings.Contains(this))
            {
                previousValue.Meetings.Remove(this);
            }
    
            if (Users != null)
            {
                if (!Users.Meetings.Contains(this))
                {
                    Users.Meetings.Add(this);
                }
    
                MeetingOwner = Users.ID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Users")
                    && (ChangeTracker.OriginalValues["Users"] == Users))
                {
                    ChangeTracker.OriginalValues.Remove("Users");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Users", previousValue);
                }
                if (Users != null && !Users.ChangeTracker.ChangeTrackingEnabled)
                {
                    Users.StartTracking();
                }
            }
        }
    
        private void FixupTenant(Tenant previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Meetings.Contains(this))
            {
                previousValue.Meetings.Remove(this);
            }
    
            if (Tenant != null)
            {
                if (!Tenant.Meetings.Contains(this))
                {
                    Tenant.Meetings.Add(this);
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
    
        private void FixupMeetingTasks(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (MeetingTasks item in e.NewItems)
                {
                    item.Meetings = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("MeetingTasks", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (MeetingTasks item in e.OldItems)
                {
                    if (ReferenceEquals(item.Meetings, this))
                    {
                        item.Meetings = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("MeetingTasks", item);
                    }
                }
            }
        }
    
        private void FixupMeetingAttendies(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (MeetingAttendies item in e.NewItems)
                {
                    item.Meetings = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("MeetingAttendies", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (MeetingAttendies item in e.OldItems)
                {
                    if (ReferenceEquals(item.Meetings, this))
                    {
                        item.Meetings = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("MeetingAttendies", item);
                    }
                }
            }
        }
    
        private void FixupMeetingCategoryMap(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (MeetingCategoryMap item in e.NewItems)
                {
                    item.Meetings = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("MeetingCategoryMap", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (MeetingCategoryMap item in e.OldItems)
                {
                    if (ReferenceEquals(item.Meetings, this))
                    {
                        item.Meetings = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("MeetingCategoryMap", item);
                    }
                }
            }
        }

        #endregion
    }
}
