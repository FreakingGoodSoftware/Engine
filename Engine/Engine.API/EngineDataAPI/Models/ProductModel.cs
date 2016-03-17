﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Engine.API.Models;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;

namespace Engine.API.Models
{
    public partial class ProductModel
    {
        private string _catalogDescription;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string CatalogDescription
        {
            get { return this._catalogDescription; }
            set { this._catalogDescription = value; }
        }
        
        private DateTimeOffset? _modifiedDate;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? ModifiedDate
        {
            get { return this._modifiedDate; }
            set { this._modifiedDate = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private int? _productModelID;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? ProductModelID
        {
            get { return this._productModelID; }
            set { this._productModelID = value; }
        }
        
        private IList<ProductModelProductDescription> _productModelProductDescriptions;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<ProductModelProductDescription> ProductModelProductDescriptions
        {
            get { return this._productModelProductDescriptions; }
            set { this._productModelProductDescriptions = value; }
        }
        
        private IList<Product> _products;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<Product> Products
        {
            get { return this._products; }
            set { this._products = value; }
        }
        
        private string _rowguid;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Rowguid
        {
            get { return this._rowguid; }
            set { this._rowguid = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProductModel class.
        /// </summary>
        public ProductModel()
        {
            this.ProductModelProductDescriptions = new LazyList<ProductModelProductDescription>();
            this.Products = new LazyList<Product>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ProductModel class with required
        /// arguments.
        /// </summary>
        public ProductModel(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken catalogDescriptionValue = inputObject["CatalogDescription"];
                if (catalogDescriptionValue != null && catalogDescriptionValue.Type != JTokenType.Null)
                {
                    this.CatalogDescription = ((string)catalogDescriptionValue);
                }
                JToken modifiedDateValue = inputObject["ModifiedDate"];
                if (modifiedDateValue != null && modifiedDateValue.Type != JTokenType.Null)
                {
                    this.ModifiedDate = ((DateTimeOffset)modifiedDateValue);
                }
                JToken nameValue = inputObject["Name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
                JToken productModelIDValue = inputObject["ProductModelID"];
                if (productModelIDValue != null && productModelIDValue.Type != JTokenType.Null)
                {
                    this.ProductModelID = ((int)productModelIDValue);
                }
                JToken productModelProductDescriptionsSequence = ((JToken)inputObject["ProductModelProductDescriptions"]);
                if (productModelProductDescriptionsSequence != null && productModelProductDescriptionsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken productModelProductDescriptionsValue in ((JArray)productModelProductDescriptionsSequence))
                    {
                        ProductModelProductDescription productModelProductDescription = new ProductModelProductDescription();
                        productModelProductDescription.DeserializeJson(productModelProductDescriptionsValue);
                        this.ProductModelProductDescriptions.Add(productModelProductDescription);
                    }
                }
                JToken productsSequence = ((JToken)inputObject["Products"]);
                if (productsSequence != null && productsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken productsValue in ((JArray)productsSequence))
                    {
                        Product product = new Product();
                        product.DeserializeJson(productsValue);
                        this.Products.Add(product);
                    }
                }
                JToken rowguidValue = inputObject["rowguid"];
                if (rowguidValue != null && rowguidValue.Type != JTokenType.Null)
                {
                    this.Rowguid = ((string)rowguidValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type ProductModel
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Name == null)
            {
                throw new ArgumentNullException("Name");
            }
            if (this.CatalogDescription != null)
            {
                outputObject["CatalogDescription"] = this.CatalogDescription;
            }
            if (this.ModifiedDate != null)
            {
                outputObject["ModifiedDate"] = this.ModifiedDate.Value;
            }
            if (this.Name != null)
            {
                outputObject["Name"] = this.Name;
            }
            if (this.ProductModelID != null)
            {
                outputObject["ProductModelID"] = this.ProductModelID.Value;
            }
            JArray productModelProductDescriptionsSequence = null;
            if (this.ProductModelProductDescriptions != null)
            {
                if (this.ProductModelProductDescriptions is ILazyCollection<ProductModelProductDescription> == false || ((ILazyCollection<ProductModelProductDescription>)this.ProductModelProductDescriptions).IsInitialized)
                {
                    productModelProductDescriptionsSequence = new JArray();
                    outputObject["ProductModelProductDescriptions"] = productModelProductDescriptionsSequence;
                    foreach (ProductModelProductDescription productModelProductDescriptionsItem in this.ProductModelProductDescriptions)
                    {
                        if (productModelProductDescriptionsItem != null)
                        {
                            productModelProductDescriptionsSequence.Add(productModelProductDescriptionsItem.SerializeJson(null));
                        }
                    }
                }
            }
            JArray productsSequence = null;
            if (this.Products != null)
            {
                if (this.Products is ILazyCollection<Product> == false || ((ILazyCollection<Product>)this.Products).IsInitialized)
                {
                    productsSequence = new JArray();
                    outputObject["Products"] = productsSequence;
                    foreach (Product productsItem in this.Products)
                    {
                        if (productsItem != null)
                        {
                            productsSequence.Add(productsItem.SerializeJson(null));
                        }
                    }
                }
            }
            if (this.Rowguid != null)
            {
                outputObject["rowguid"] = this.Rowguid;
            }
            return outputObject;
        }
    }
}