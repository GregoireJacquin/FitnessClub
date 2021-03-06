﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("FitnessClubModel", "Abonnement_MemberId_Member_MemberId", "Member", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(FitnessClub.Member), "Abonnement", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(FitnessClub.Abonnement), true)]

#endregion

namespace FitnessClub
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class FitnessClubEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new FitnessClubEntities object using the connection string found in the 'FitnessClubEntities' section of the application configuration file.
        /// </summary>
        public FitnessClubEntities() : base("name=FitnessClubEntities", "FitnessClubEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FitnessClubEntities object.
        /// </summary>
        public FitnessClubEntities(string connectionString) : base(connectionString, "FitnessClubEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FitnessClubEntities object.
        /// </summary>
        public FitnessClubEntities(EntityConnection connection) : base(connection, "FitnessClubEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Abonnement> Abonnement
        {
            get
            {
                if ((_Abonnement == null))
                {
                    _Abonnement = base.CreateObjectSet<Abonnement>("Abonnement");
                }
                return _Abonnement;
            }
        }
        private ObjectSet<Abonnement> _Abonnement;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Member> Member
        {
            get
            {
                if ((_Member == null))
                {
                    _Member = base.CreateObjectSet<Member>("Member");
                }
                return _Member;
            }
        }
        private ObjectSet<Member> _Member;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Abonnement EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAbonnement(Abonnement abonnement)
        {
            base.AddObject("Abonnement", abonnement);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Member EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMember(Member member)
        {
            base.AddObject("Member", member);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FitnessClubModel", Name="Abonnement")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Abonnement : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Abonnement object.
        /// </summary>
        /// <param name="abonnementId">Initial value of the AbonnementId property.</param>
        /// <param name="memberId">Initial value of the MemberId property.</param>
        public static Abonnement CreateAbonnement(global::System.Int32 abonnementId, global::System.Int32 memberId)
        {
            Abonnement abonnement = new Abonnement();
            abonnement.AbonnementId = abonnementId;
            abonnement.MemberId = memberId;
            return abonnement;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AbonnementId
        {
            get
            {
                return _AbonnementId;
            }
            set
            {
                if (_AbonnementId != value)
                {
                    OnAbonnementIdChanging(value);
                    ReportPropertyChanging("AbonnementId");
                    _AbonnementId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AbonnementId");
                    OnAbonnementIdChanged();
                }
            }
        }
        private global::System.Int32 _AbonnementId;
        partial void OnAbonnementIdChanging(global::System.Int32 value);
        partial void OnAbonnementIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateInscription
        {
            get
            {
                return _DateInscription;
            }
            set
            {
                OnDateInscriptionChanging(value);
                ReportPropertyChanging("DateInscription");
                _DateInscription = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateInscription");
                OnDateInscriptionChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateInscription;
        partial void OnDateInscriptionChanging(Nullable<global::System.DateTime> value);
        partial void OnDateInscriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TypeAbonnement
        {
            get
            {
                return _TypeAbonnement;
            }
            set
            {
                OnTypeAbonnementChanging(value);
                ReportPropertyChanging("TypeAbonnement");
                _TypeAbonnement = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TypeAbonnement");
                OnTypeAbonnementChanged();
            }
        }
        private global::System.String _TypeAbonnement;
        partial void OnTypeAbonnementChanging(global::System.String value);
        partial void OnTypeAbonnementChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Photo
        {
            get
            {
                return _Photo;
            }
            set
            {
                OnPhotoChanging(value);
                ReportPropertyChanging("Photo");
                _Photo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Photo");
                OnPhotoChanged();
            }
        }
        private global::System.String _Photo;
        partial void OnPhotoChanging(global::System.String value);
        partial void OnPhotoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Certificat
        {
            get
            {
                return _Certificat;
            }
            set
            {
                OnCertificatChanging(value);
                ReportPropertyChanging("Certificat");
                _Certificat = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Certificat");
                OnCertificatChanged();
            }
        }
        private global::System.String _Certificat;
        partial void OnCertificatChanging(global::System.String value);
        partial void OnCertificatChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> FinAbonnement
        {
            get
            {
                return _FinAbonnement;
            }
            set
            {
                OnFinAbonnementChanging(value);
                ReportPropertyChanging("FinAbonnement");
                _FinAbonnement = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FinAbonnement");
                OnFinAbonnementChanged();
            }
        }
        private Nullable<global::System.DateTime> _FinAbonnement;
        partial void OnFinAbonnementChanging(Nullable<global::System.DateTime> value);
        partial void OnFinAbonnementChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MemberId
        {
            get
            {
                return _MemberId;
            }
            set
            {
                OnMemberIdChanging(value);
                ReportPropertyChanging("MemberId");
                _MemberId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MemberId");
                OnMemberIdChanged();
            }
        }
        private global::System.Int32 _MemberId;
        partial void OnMemberIdChanging(global::System.Int32 value);
        partial void OnMemberIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> modify
        {
            get
            {
                return _modify;
            }
            set
            {
                OnmodifyChanging(value);
                ReportPropertyChanging("modify");
                _modify = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("modify");
                OnmodifyChanged();
            }
        }
        private Nullable<global::System.DateTime> _modify;
        partial void OnmodifyChanging(Nullable<global::System.DateTime> value);
        partial void OnmodifyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TypePaiment
        {
            get
            {
                return _TypePaiment;
            }
            set
            {
                OnTypePaimentChanging(value);
                ReportPropertyChanging("TypePaiment");
                _TypePaiment = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TypePaiment");
                OnTypePaimentChanged();
            }
        }
        private global::System.String _TypePaiment;
        partial void OnTypePaimentChanging(global::System.String value);
        partial void OnTypePaimentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Commentaire
        {
            get
            {
                return _Commentaire;
            }
            set
            {
                OnCommentaireChanging(value);
                ReportPropertyChanging("Commentaire");
                _Commentaire = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Commentaire");
                OnCommentaireChanged();
            }
        }
        private global::System.String _Commentaire;
        partial void OnCommentaireChanging(global::System.String value);
        partial void OnCommentaireChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FitnessClubModel", "Abonnement_MemberId_Member_MemberId", "Member")]
        public Member Member
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("FitnessClubModel.Abonnement_MemberId_Member_MemberId", "Member").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("FitnessClubModel.Abonnement_MemberId_Member_MemberId", "Member").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Member> MemberReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("FitnessClubModel.Abonnement_MemberId_Member_MemberId", "Member");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Member>("FitnessClubModel.Abonnement_MemberId_Member_MemberId", "Member", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FitnessClubModel", Name="Member")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Member : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Member object.
        /// </summary>
        /// <param name="memberId">Initial value of the MemberId property.</param>
        public static Member CreateMember(global::System.Int32 memberId)
        {
            Member member = new Member();
            member.MemberId = memberId;
            return member;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MemberId
        {
            get
            {
                return _MemberId;
            }
            set
            {
                if (_MemberId != value)
                {
                    OnMemberIdChanging(value);
                    ReportPropertyChanging("MemberId");
                    _MemberId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MemberId");
                    OnMemberIdChanged();
                }
            }
        }
        private global::System.Int32 _MemberId;
        partial void OnMemberIdChanging(global::System.Int32 value);
        partial void OnMemberIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Mail
        {
            get
            {
                return _Mail;
            }
            set
            {
                OnMailChanging(value);
                ReportPropertyChanging("Mail");
                _Mail = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Mail");
                OnMailChanged();
            }
        }
        private global::System.String _Mail;
        partial void OnMailChanging(global::System.String value);
        partial void OnMailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Portable
        {
            get
            {
                return _Portable;
            }
            set
            {
                OnPortableChanging(value);
                ReportPropertyChanging("Portable");
                _Portable = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Portable");
                OnPortableChanged();
            }
        }
        private global::System.String _Portable;
        partial void OnPortableChanging(global::System.String value);
        partial void OnPortableChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ZipCode
        {
            get
            {
                return _ZipCode;
            }
            set
            {
                OnZipCodeChanging(value);
                ReportPropertyChanging("ZipCode");
                _ZipCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ZipCode");
                OnZipCodeChanged();
            }
        }
        private global::System.String _ZipCode;
        partial void OnZipCodeChanging(global::System.String value);
        partial void OnZipCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> modify
        {
            get
            {
                return _modify;
            }
            set
            {
                OnmodifyChanging(value);
                ReportPropertyChanging("modify");
                _modify = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("modify");
                OnmodifyChanged();
            }
        }
        private Nullable<global::System.DateTime> _modify;
        partial void OnmodifyChanging(Nullable<global::System.DateTime> value);
        partial void OnmodifyChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FitnessClubModel", "Abonnement_MemberId_Member_MemberId", "Abonnement")]
        public EntityCollection<Abonnement> Abonnement
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Abonnement>("FitnessClubModel.Abonnement_MemberId_Member_MemberId", "Abonnement");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Abonnement>("FitnessClubModel.Abonnement_MemberId_Member_MemberId", "Abonnement", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
