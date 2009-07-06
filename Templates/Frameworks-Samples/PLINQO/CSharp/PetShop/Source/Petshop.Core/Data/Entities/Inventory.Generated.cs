﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace PetShop.Core.Data
{
    /// <summary>
    /// The class representing the dbo.Inventory table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Inventory")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    [System.Data.Services.Common.DataServiceKey("ItemId")]
    [System.Diagnostics.DebuggerDisplay("ItemId: {ItemId}")]
    public partial class Inventory
        : LinqEntityBase, ICloneable
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Inventory"/> class.
        /// </summary>
        static Inventory()
        {
            CodeSmith.Data.Rules.RuleManager.AddShared<Inventory>();
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public Inventory()
        {
            OnCreated();
            Initialize();
        }

        private void Initialize()
        {
        }
        #endregion

        #region Column Mapped Properties

        private string _itemId;

        /// <summary>
        /// Gets or sets the ItemId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ItemId", Storage = "_itemId", DbType = "varchar(10) NOT NULL", IsPrimaryKey = true, CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    OnItemIdChanging(value);
                    SendPropertyChanging("ItemId");
                    _itemId = value;
                    SendPropertyChanged("ItemId");
                    OnItemIdChanged();
                }
            }
        }

        private int _qty;

        /// <summary>
        /// Gets or sets the Qty column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Qty", Storage = "_qty", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public int Qty
        {
            get { return _qty; }
            set
            {
                if (_qty != value)
                {
                    OnQtyChanging(value);
                    SendPropertyChanging("Qty");
                    _qty = value;
                    SendPropertyChanged("Qty");
                    OnQtyChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties
        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        partial void OnCreated();
        /// <summary>Called when <see cref="ItemId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnItemIdChanging(string value);
        /// <summary>Called after <see cref="ItemId"/> has Changed.</summary>
        partial void OnItemIdChanged();
        /// <summary>Called when <see cref="Qty"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnQtyChanging(int value);
        /// <summary>Called after <see cref="Qty"/> has Changed.</summary>
        partial void OnQtyChanged();

        #endregion

        #region Serialization
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        public Inventory Clone()
        {
            return (Inventory)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
        }
        #endregion
    }
}

