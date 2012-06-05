﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CartList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using Csla;
using Csla.Data;

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.CartListFactoryName)]
    public partial class CartList : BusinessListBase<CartList, Cart>
    {
        #region Constructor(s)

        public CartList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="CartList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="CartList"/>.</returns>
        internal static CartList NewList()
        {
            return DataPortal.CreateChild<CartList>();
        }     

        /// <summary>
        /// Returns a <see cref="CartList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="cartId">No additional detail available.</param>
        /// <returns>A <see cref="CartList"/> object of the specified criteria.</returns>
        internal static CartList GetByCartId(System.Int32 cartId)
        {
            var criteria = new CartCriteria{CartId = cartId};
            
            
            return DataPortal.Fetch<CartList>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="CartList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="uniqueID">No additional detail available.</param>
        /// <returns>A <see cref="CartList"/> object of the specified criteria.</returns>
        internal static CartList GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new CartCriteria{UniqueID = uniqueID};
            
            
            return DataPortal.Fetch<CartList>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="CartList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="isShoppingCart">No additional detail available.</param>
        /// <returns>A <see cref="CartList"/> object of the specified criteria.</returns>
        internal static CartList GetByIsShoppingCart(System.Boolean isShoppingCart)
        {
            var criteria = new CartCriteria{IsShoppingCart = isShoppingCart};
            
            
            return DataPortal.Fetch<CartList>(criteria);
        }

        internal static CartList GetByCriteria(CartCriteria criteria)
        {
            return DataPortal.Fetch<CartList>(criteria);
        }

        internal static CartList GetAll()
        {
            return DataPortal.Fetch<CartList>(new CartCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods

        internal static void NewListAsync(EventHandler<DataPortalResult<CartList>> handler)
        {
            var dp = new DataPortal<CartList>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        internal static void GetByCartIdAsync(System.Int32 cartId, EventHandler<DataPortalResult<AsyncChildLoader<CartList>>> handler)
        {
            var criteria = new CartCriteria{CartId = cartId};
            
            DataPortal.BeginFetch<AsyncChildLoader<CartList>>(criteria,handler);
        }

        internal static void GetByUniqueIDAsync(System.Int32 uniqueID, EventHandler<DataPortalResult<AsyncChildLoader<CartList>>> handler)
        {
            var criteria = new CartCriteria{UniqueID = uniqueID};
            
            DataPortal.BeginFetch<AsyncChildLoader<CartList>>(criteria,handler);
        }

        internal static void GetByIsShoppingCartAsync(System.Boolean isShoppingCart, EventHandler<DataPortalResult<AsyncChildLoader<CartList>>> handler)
        {
            var criteria = new CartCriteria{IsShoppingCart = isShoppingCart};
            
            DataPortal.BeginFetch<AsyncChildLoader<CartList>>(criteria,handler);
        }

        internal static void GetByCriteriaAsync(CartCriteria criteria, EventHandler<DataPortalResult<CartList>> handler)
        {  
            var dp = new DataPortal<CartList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        internal static void GetAllAsync(EventHandler<DataPortalResult<AsyncChildLoader<CartList>>> handler)
        {
            DataPortal.BeginFetch<AsyncChildLoader<CartList>>(new CartCriteria(),handler);
        }

        #endregion

        #region Method Overrides
        
        protected override Cart AddNewCore()
        {
            Cart item = PetShop.Tests.ObjF.StoredProcedures.Cart.NewCart();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Tests.ObjF.StoredProcedures.Cart.NewCart();

                // Pass the parent value down to the child.
                //Profile profile = this.Parent as Profile;
                //if(profile != null)
                //    item.UniqueID = profile.UniqueID;


                Add(item);
            }

            return item;
        }

        protected void AddNewCoreAsync(EventHandler<DataPortalResult<Cart>> handler)
        {
            PetShop.Tests.ObjF.StoredProcedures.Cart.NewCartAsync((o, e) =>
            {
                if(e.Error == null)
                {
                    Add(e.Object);
                    handler.Invoke(this, new DataPortalResult<Cart>(e.Object, null, null));
                }
            });
        }
        
        #endregion

        #region Property overrides

        /// <summary>
        /// Returns true if any children are dirty
        /// </summary>
        public new bool IsDirty
        {
            get
            {
                foreach(Cart item in this.Items)
                {
                    if(item.IsDirty) return true;
                }
                
                return false;
            }
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="CartCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(CartCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Cart"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Cart"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
        partial void OnAddNewCore(ref Cart item, ref bool cancel);

        #endregion
        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the Cart in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="CartList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(CartCriteria criteria)
        {
            return PetShop.Tests.ObjF.StoredProcedures.Cart.Exists(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the Cart in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(CartCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            PetShop.Tests.ObjF.StoredProcedures.Cart.ExistsAsync(criteria,handler);
        }

        #endregion
 
        #region Enhancements

        public Cart GetCart(System.Int32 cartId)
        {
            return this.FirstOrDefault(i => i.CartId == cartId);
        }

        public bool Contains(System.Int32 cartId)
        {
            return this.Count(i => i.CartId == cartId) > 0;
        }
 
        public bool ContainsDeleted(System.Int32 cartId)
        {
            return DeletedList.Count(i => i.CartId == cartId) > 0;
        }
        
        public void Remove(System.Int32 cartId)
        {
            var item = this.FirstOrDefault(i => i.CartId == cartId);
            if (item != null)
                Remove(item);
        }

        #endregion
    }
}