﻿//------------------------------------------------------------------------------
// <auto-generated>
//    이 코드는 템플릿에서 생성되었습니다.
//
//    이 파일을 수동으로 변경하면 응용 프로그램에 예기치 않은 동작이 발생할 수 있습니다.
//    코드가 다시 생성되면 이 파일에 대한 수동 변경 사항을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM 관계 메타데이터

[assembly: EdmRelationshipAttribute("JupiterModel", "FK_common_Exceptions_common_Exceptions_State", "common_Exceptions_State", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Jupiter.Repository.ExceptionHandle.common_Exceptions_State), "common_Exceptions", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Jupiter.Repository.ExceptionHandle.common_Exceptions), true)]
[assembly: EdmRelationshipAttribute("JupiterModel", "FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Jupiter.Repository.ExceptionHandle.common_Exceptions), "common_Exceptions_Handle", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Jupiter.Repository.ExceptionHandle.common_Exceptions_Handle), true)]

#endregion

namespace Jupiter.Repository.ExceptionHandle
{
    #region 컨텍스트
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    public partial class ExceptionHandleEntities : ObjectContext
    {
        #region 생성자
    
        /// <summary>
        /// 응용 프로그램 구성 파일의 'ExceptionHandleEntities' 섹션에서 검색된 연결 문자열을 사용하여 새 ExceptionHandleEntities 개체를 초기화합니다.
        /// </summary>
        public ExceptionHandleEntities() : base("name=ExceptionHandleEntities", "ExceptionHandleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 새 ExceptionHandleEntities 개체를 초기화합니다.
        /// </summary>
        public ExceptionHandleEntities(string connectionString) : base(connectionString, "ExceptionHandleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 새 ExceptionHandleEntities 개체를 초기화합니다.
        /// </summary>
        public ExceptionHandleEntities(EntityConnection connection) : base(connection, "ExceptionHandleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 부분 메서드(Partial Method)
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        public ObjectSet<common_Exceptions> common_Exceptions
        {
            get
            {
                if ((_common_Exceptions == null))
                {
                    _common_Exceptions = base.CreateObjectSet<common_Exceptions>("common_Exceptions");
                }
                return _common_Exceptions;
            }
        }
        private ObjectSet<common_Exceptions> _common_Exceptions;
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        public ObjectSet<common_Exceptions_Handle> common_Exceptions_Handle
        {
            get
            {
                if ((_common_Exceptions_Handle == null))
                {
                    _common_Exceptions_Handle = base.CreateObjectSet<common_Exceptions_Handle>("common_Exceptions_Handle");
                }
                return _common_Exceptions_Handle;
            }
        }
        private ObjectSet<common_Exceptions_Handle> _common_Exceptions_Handle;
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        public ObjectSet<common_Exceptions_State> common_Exceptions_State
        {
            get
            {
                if ((_common_Exceptions_State == null))
                {
                    _common_Exceptions_State = base.CreateObjectSet<common_Exceptions_State>("common_Exceptions_State");
                }
                return _common_Exceptions_State;
            }
        }
        private ObjectSet<common_Exceptions_State> _common_Exceptions_State;

        #endregion

        #region AddTo 메서드
    
        /// <summary>
        /// common_Exceptions EntitySet에 새 개체를 추가하는 데 사용되지 않는 메서드입니다. 연결된 ObjectSet&lt;T&gt; 속성의 .Add 메서드를 대신 사용하십시오.
        /// </summary>
        public void AddTocommon_Exceptions(common_Exceptions common_Exceptions)
        {
            base.AddObject("common_Exceptions", common_Exceptions);
        }
    
        /// <summary>
        /// common_Exceptions_Handle EntitySet에 새 개체를 추가하는 데 사용되지 않는 메서드입니다. 연결된 ObjectSet&lt;T&gt; 속성의 .Add 메서드를 대신 사용하십시오.
        /// </summary>
        public void AddTocommon_Exceptions_Handle(common_Exceptions_Handle common_Exceptions_Handle)
        {
            base.AddObject("common_Exceptions_Handle", common_Exceptions_Handle);
        }
    
        /// <summary>
        /// common_Exceptions_State EntitySet에 새 개체를 추가하는 데 사용되지 않는 메서드입니다. 연결된 ObjectSet&lt;T&gt; 속성의 .Add 메서드를 대신 사용하십시오.
        /// </summary>
        public void AddTocommon_Exceptions_State(common_Exceptions_State common_Exceptions_State)
        {
            base.AddObject("common_Exceptions_State", common_Exceptions_State);
        }

        #endregion

    }

    #endregion

    #region 엔터티
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="JupiterModel", Name="common_Exceptions")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class common_Exceptions : EntityObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 common_Exceptions 개체를 만듭니다.
        /// </summary>
        /// <param name="id">Id 속성의 초기 값입니다.</param>
        /// <param name="createDate">CreateDate 속성의 초기 값입니다.</param>
        /// <param name="exceptions_StateId">Exceptions_StateId 속성의 초기 값입니다.</param>
        public static common_Exceptions Createcommon_Exceptions(global::System.Int64 id, global::System.DateTime createDate, global::System.Byte exceptions_StateId)
        {
            common_Exceptions common_Exceptions = new common_Exceptions();
            common_Exceptions.Id = id;
            common_Exceptions.CreateDate = createDate;
            common_Exceptions.Exceptions_StateId = exceptions_StateId;
            return common_Exceptions;
        }

        #endregion

        #region 단순 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Message
        {
            get
            {
                return _Message;
            }
            set
            {
                OnMessageChanging(value);
                ReportPropertyChanging("Message");
                _Message = StructuralObject.SetValidValue(value, true, "Message");
                ReportPropertyChanged("Message");
                OnMessageChanged();
            }
        }
        private global::System.String _Message;
        partial void OnMessageChanging(global::System.String value);
        partial void OnMessageChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Source
        {
            get
            {
                return _Source;
            }
            set
            {
                OnSourceChanging(value);
                ReportPropertyChanging("Source");
                _Source = StructuralObject.SetValidValue(value, true, "Source");
                ReportPropertyChanged("Source");
                OnSourceChanged();
            }
        }
        private global::System.String _Source;
        partial void OnSourceChanging(global::System.String value);
        partial void OnSourceChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String StackTrace
        {
            get
            {
                return _StackTrace;
            }
            set
            {
                OnStackTraceChanging(value);
                ReportPropertyChanging("StackTrace");
                _StackTrace = StructuralObject.SetValidValue(value, true, "StackTrace");
                ReportPropertyChanged("StackTrace");
                OnStackTraceChanged();
            }
        }
        private global::System.String _StackTrace;
        partial void OnStackTraceChanging(global::System.String value);
        partial void OnStackTraceChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, true, "UserName");
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Url
        {
            get
            {
                return _Url;
            }
            set
            {
                OnUrlChanging(value);
                ReportPropertyChanging("Url");
                _Url = StructuralObject.SetValidValue(value, true, "Url");
                ReportPropertyChanged("Url");
                OnUrlChanged();
            }
        }
        private global::System.String _Url;
        partial void OnUrlChanging(global::System.String value);
        partial void OnUrlChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UrlReferrer
        {
            get
            {
                return _UrlReferrer;
            }
            set
            {
                OnUrlReferrerChanging(value);
                ReportPropertyChanging("UrlReferrer");
                _UrlReferrer = StructuralObject.SetValidValue(value, true, "UrlReferrer");
                ReportPropertyChanged("UrlReferrer");
                OnUrlReferrerChanged();
            }
        }
        private global::System.String _UrlReferrer;
        partial void OnUrlReferrerChanging(global::System.String value);
        partial void OnUrlReferrerChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserHostName
        {
            get
            {
                return _UserHostName;
            }
            set
            {
                OnUserHostNameChanging(value);
                ReportPropertyChanging("UserHostName");
                _UserHostName = StructuralObject.SetValidValue(value, true, "UserHostName");
                ReportPropertyChanged("UserHostName");
                OnUserHostNameChanged();
            }
        }
        private global::System.String _UserHostName;
        partial void OnUserHostNameChanging(global::System.String value);
        partial void OnUserHostNameChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserHostAddress
        {
            get
            {
                return _UserHostAddress;
            }
            set
            {
                OnUserHostAddressChanging(value);
                ReportPropertyChanging("UserHostAddress");
                _UserHostAddress = StructuralObject.SetValidValue(value, true, "UserHostAddress");
                ReportPropertyChanged("UserHostAddress");
                OnUserHostAddressChanged();
            }
        }
        private global::System.String _UserHostAddress;
        partial void OnUserHostAddressChanging(global::System.String value);
        partial void OnUserHostAddressChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                OnCreateDateChanging(value);
                ReportPropertyChanging("CreateDate");
                _CreateDate = StructuralObject.SetValidValue(value, "CreateDate");
                ReportPropertyChanged("CreateDate");
                OnCreateDateChanged();
            }
        }
        private global::System.DateTime _CreateDate;
        partial void OnCreateDateChanging(global::System.DateTime value);
        partial void OnCreateDateChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte Exceptions_StateId
        {
            get
            {
                return _Exceptions_StateId;
            }
            set
            {
                OnExceptions_StateIdChanging(value);
                ReportPropertyChanging("Exceptions_StateId");
                _Exceptions_StateId = StructuralObject.SetValidValue(value, "Exceptions_StateId");
                ReportPropertyChanged("Exceptions_StateId");
                OnExceptions_StateIdChanged();
            }
        }
        private global::System.Byte _Exceptions_StateId;
        partial void OnExceptions_StateIdChanging(global::System.Byte value);
        partial void OnExceptions_StateIdChanged();

        #endregion

        #region 탐색 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("JupiterModel", "FK_common_Exceptions_common_Exceptions_State", "common_Exceptions_State")]
        public common_Exceptions_State common_Exceptions_State
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<common_Exceptions_State>("JupiterModel.FK_common_Exceptions_common_Exceptions_State", "common_Exceptions_State").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<common_Exceptions_State>("JupiterModel.FK_common_Exceptions_common_Exceptions_State", "common_Exceptions_State").Value = value;
            }
        }
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<common_Exceptions_State> common_Exceptions_StateReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<common_Exceptions_State>("JupiterModel.FK_common_Exceptions_common_Exceptions_State", "common_Exceptions_State");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<common_Exceptions_State>("JupiterModel.FK_common_Exceptions_common_Exceptions_State", "common_Exceptions_State", value);
                }
            }
        }
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("JupiterModel", "FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions_Handle")]
        public EntityCollection<common_Exceptions_Handle> common_Exceptions_Handle
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<common_Exceptions_Handle>("JupiterModel.FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions_Handle");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<common_Exceptions_Handle>("JupiterModel.FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions_Handle", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="JupiterModel", Name="common_Exceptions_Handle")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class common_Exceptions_Handle : EntityObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 common_Exceptions_Handle 개체를 만듭니다.
        /// </summary>
        /// <param name="id">Id 속성의 초기 값입니다.</param>
        /// <param name="exceptionId">ExceptionId 속성의 초기 값입니다.</param>
        /// <param name="userName">UserName 속성의 초기 값입니다.</param>
        /// <param name="comment">Comment 속성의 초기 값입니다.</param>
        /// <param name="createDate">CreateDate 속성의 초기 값입니다.</param>
        public static common_Exceptions_Handle Createcommon_Exceptions_Handle(global::System.Int64 id, global::System.Int64 exceptionId, global::System.String userName, global::System.String comment, global::System.DateTime createDate)
        {
            common_Exceptions_Handle common_Exceptions_Handle = new common_Exceptions_Handle();
            common_Exceptions_Handle.Id = id;
            common_Exceptions_Handle.ExceptionId = exceptionId;
            common_Exceptions_Handle.UserName = userName;
            common_Exceptions_Handle.Comment = comment;
            common_Exceptions_Handle.CreateDate = createDate;
            return common_Exceptions_Handle;
        }

        #endregion

        #region 단순 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ExceptionId
        {
            get
            {
                return _ExceptionId;
            }
            set
            {
                OnExceptionIdChanging(value);
                ReportPropertyChanging("ExceptionId");
                _ExceptionId = StructuralObject.SetValidValue(value, "ExceptionId");
                ReportPropertyChanged("ExceptionId");
                OnExceptionIdChanged();
            }
        }
        private global::System.Int64 _ExceptionId;
        partial void OnExceptionIdChanging(global::System.Int64 value);
        partial void OnExceptionIdChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false, "UserName");
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Comment
        {
            get
            {
                return _Comment;
            }
            set
            {
                OnCommentChanging(value);
                ReportPropertyChanging("Comment");
                _Comment = StructuralObject.SetValidValue(value, false, "Comment");
                ReportPropertyChanged("Comment");
                OnCommentChanged();
            }
        }
        private global::System.String _Comment;
        partial void OnCommentChanging(global::System.String value);
        partial void OnCommentChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                OnCreateDateChanging(value);
                ReportPropertyChanging("CreateDate");
                _CreateDate = StructuralObject.SetValidValue(value, "CreateDate");
                ReportPropertyChanged("CreateDate");
                OnCreateDateChanged();
            }
        }
        private global::System.DateTime _CreateDate;
        partial void OnCreateDateChanging(global::System.DateTime value);
        partial void OnCreateDateChanged();

        #endregion

        #region 탐색 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("JupiterModel", "FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions")]
        public common_Exceptions common_Exceptions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<common_Exceptions>("JupiterModel.FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<common_Exceptions>("JupiterModel.FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions").Value = value;
            }
        }
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<common_Exceptions> common_ExceptionsReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<common_Exceptions>("JupiterModel.FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<common_Exceptions>("JupiterModel.FK_common_Exceptions_Handle_common_Exceptions", "common_Exceptions", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="JupiterModel", Name="common_Exceptions_State")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class common_Exceptions_State : EntityObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 common_Exceptions_State 개체를 만듭니다.
        /// </summary>
        /// <param name="id">Id 속성의 초기 값입니다.</param>
        /// <param name="name">Name 속성의 초기 값입니다.</param>
        /// <param name="description">Description 속성의 초기 값입니다.</param>
        public static common_Exceptions_State Createcommon_Exceptions_State(global::System.Byte id, global::System.String name, global::System.String description)
        {
            common_Exceptions_State common_Exceptions_State = new common_Exceptions_State();
            common_Exceptions_State.Id = id;
            common_Exceptions_State.Name = name;
            common_Exceptions_State.Description = description;
            return common_Exceptions_State;
        }

        #endregion

        #region 단순 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Byte _Id;
        partial void OnIdChanging(global::System.Byte value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

        #region 탐색 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("JupiterModel", "FK_common_Exceptions_common_Exceptions_State", "common_Exceptions")]
        public EntityCollection<common_Exceptions> common_Exceptions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<common_Exceptions>("JupiterModel.FK_common_Exceptions_common_Exceptions_State", "common_Exceptions");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<common_Exceptions>("JupiterModel.FK_common_Exceptions_common_Exceptions_State", "common_Exceptions", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
