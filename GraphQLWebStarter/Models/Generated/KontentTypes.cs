using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GraphQLWebStarter.Models.Generated {
  public class KontentTypes {
    
    #region Action
    public class Action : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("navigationItem")]
      public Action_NavigationItem navigationItem { get; set; }
    
      [JsonProperty("icon")]
      public Icon icon { get; set; }
    
      [JsonProperty("role")]
      public _MultipleChoiceOptionCollection role { get; set; }
    
      [JsonProperty("options")]
      public _MultipleChoiceOptionCollection options { get; set; }
      #endregion
    }
    #endregion
    
    #region Action_All
    public class Action_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Action> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Action_Where
    public class Action_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter label { get; set; }
    
      public _ArrayFilter navigationItem { get; set; }
    
      public _ArrayFilter icon { get; set; }
    
      public _ArrayFilter role { get; set; }
    
      public _ArrayFilter options { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Author
    public class Author : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("firstName")]
      public string firstName { get; set; }
    
      [JsonProperty("lastName")]
      public string lastName { get; set; }
    
      [JsonProperty("bio")]
      public string bio { get; set; }
    
      [JsonProperty("photo")]
      public _AssetCollection photo { get; set; }
      #endregion
    }
    #endregion
    
    #region Author_All
    public class Author_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Author> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Author_Where
    public class Author_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter firstName { get; set; }
    
      public _TextFilter lastName { get; set; }
    
      public _TextFilter bio { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region BaseFormField
    public class BaseFormField : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("type")]
      public _MultipleChoiceOptionCollection type { get; set; }
    
      [JsonProperty("defaultValue")]
      public string defaultValue { get; set; }
    
      [JsonProperty("configuration")]
      public _MultipleChoiceOptionCollection configuration { get; set; }
      #endregion
    }
    #endregion
    
    #region BaseFormField_All
    public class BaseFormField_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<BaseFormField> items { get; set; }
      #endregion
    }
    #endregion
    
    #region BaseFormField_Where
    public class BaseFormField_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter label { get; set; }
    
      public _TextFilter name { get; set; }
    
      public _ArrayFilter type { get; set; }
    
      public _TextFilter defaultValue { get; set; }
    
      public _ArrayFilter configuration { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region CodeBlock
    public class CodeBlock : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("code")]
      public _RichText code { get; set; }
      #endregion
    }
    #endregion
    
    #region CodeBlock_All
    public class CodeBlock_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<CodeBlock> items { get; set; }
      #endregion
    }
    #endregion
    
    #region CodeBlock_Where
    public class CodeBlock_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region ContactSection
    public class ContactSection : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public _RichText subtitle { get; set; }
    
      [JsonProperty("content")]
      public _RichText content { get; set; }
    
      [JsonProperty("form")]
      public Form form { get; set; }
      #endregion
    }
    #endregion
    
    #region ContactSection_All
    public class ContactSection_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ContactSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ContactSection_Where
    public class ContactSection_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _ArrayFilter form { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region ContentSection
    public class ContentSection : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("image")]
      public _Asset image { get; set; }
    
      [JsonProperty("content")]
      public _RichText content { get; set; }
    
      [JsonProperty("actions")]
      public ContentSection_Actions_Collection actions { get; set; }
      #endregion
    }
    #endregion
    
    #region ContentSection_Actions_Collection
    public class ContentSection_Actions_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Action> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ContentSection_All
    public class ContentSection_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ContentSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ContentSection_Where
    public class ContentSection_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _ArrayFilter actions { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region CtaSection
    public class CtaSection : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public _RichText subtitle { get; set; }
    
      [JsonProperty("action")]
      public Action action { get; set; }
      #endregion
    }
    #endregion
    
    #region CtaSection_All
    public class CtaSection_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<CtaSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region CtaSection_Where
    public class CtaSection_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _ArrayFilter action { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region ExternalUrl
    public class ExternalUrl : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("url")]
      public string url { get; set; }
      #endregion
    }
    #endregion
    
    #region ExternalUrl_All
    public class ExternalUrl_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ExternalUrl> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ExternalUrl_Where
    public class ExternalUrl_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter url { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Feature
    public class Feature : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("image")]
      public _Asset image { get; set; }
    
      [JsonProperty("content")]
      public _RichText content { get; set; }
    
      [JsonProperty("actions")]
      public Feature_Actions_Collection actions { get; set; }
      #endregion
    }
    #endregion
    
    #region Feature_Actions_Collection
    public class Feature_Actions_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Action> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Feature_All
    public class Feature_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Feature> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Feature_Where
    public class Feature_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _ArrayFilter actions { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region FeaturesSection
    public class FeaturesSection : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public _RichText subtitle { get; set; }
    
      [JsonProperty("features")]
      public FeaturesSection_Features_Collection features { get; set; }
      #endregion
    }
    #endregion
    
    #region FeaturesSection_All
    public class FeaturesSection_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<FeaturesSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region FeaturesSection_Features_Collection
    public class FeaturesSection_Features_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Feature> items { get; set; }
      #endregion
    }
    #endregion
    
    #region FeaturesSection_Where
    public class FeaturesSection_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _ArrayFilter features { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Form
    public class Form : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("content")]
      public string content { get; set; }
    
      [JsonProperty("fields")]
      public Form_Fields_Collection fields { get; set; }
    
      [JsonProperty("submitLabel")]
      public string submitLabel { get; set; }
    
      [JsonProperty("formId")]
      public string formId { get; set; }
    
      [JsonProperty("formAction")]
      public string formAction { get; set; }
      #endregion
    }
    #endregion
    
    #region Form_All
    public class Form_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Form> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Form_Fields_Collection
    public class Form_Fields_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Form_Fields> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Form_Where
    public class Form_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _TextFilter content { get; set; }
    
      public _ArrayFilter fields { get; set; }
    
      public _TextFilter submitLabel { get; set; }
    
      public _TextFilter formId { get; set; }
    
      public _TextFilter formAction { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region HeroSection
    public class HeroSection : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("image")]
      public _Asset image { get; set; }
    
      [JsonProperty("content")]
      public _RichText content { get; set; }
    
      [JsonProperty("actions")]
      public HeroSection_Actions_Collection actions { get; set; }
      #endregion
    }
    #endregion
    
    #region HeroSection_Actions_Collection
    public class HeroSection_Actions_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Action> items { get; set; }
      #endregion
    }
    #endregion
    
    #region HeroSection_All
    public class HeroSection_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<HeroSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region HeroSection_Where
    public class HeroSection_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _ArrayFilter actions { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Homepage
    public class Homepage : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("subpages")]
      public Homepage_Subpages_Collection subpages { get; set; }
    
      [JsonProperty("content")]
      public Homepage_Content content { get; set; }
    
      [JsonProperty("slug")]
      public string slug { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("headerLogo")]
      public _Asset headerLogo { get; set; }
    
      [JsonProperty("mainMenu")]
      public Menu mainMenu { get; set; }
    
      [JsonProperty("copyright")]
      public _RichText copyright { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("font")]
      public _MultipleChoiceOptionCollection font { get; set; }
    
      [JsonProperty("favicon")]
      public _Asset favicon { get; set; }
    
      [JsonProperty("palette")]
      public _MultipleChoiceOptionCollection palette { get; set; }
    
      [JsonProperty("_seo")]
      public Seo _seo { get; set; }
      #endregion
    }
    #endregion
    
    #region Homepage_All
    public class Homepage_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Homepage> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Homepage_Subpages_Collection
    public class Homepage_Subpages_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<NavigationItem> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Homepage_Where
    public class Homepage_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _ArrayFilter subpages { get; set; }
    
      public _ArrayFilter content { get; set; }
    
      public _TextFilter slug { get; set; }
    
      public _TextFilter label { get; set; }
    
      public _ArrayFilter mainMenu { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _ArrayFilter font { get; set; }
    
      public _ArrayFilter palette { get; set; }
    
      public Seo_SnippetFilter _seo { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Icon
    public class Icon : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("icon")]
      public _MultipleChoiceOptionCollection icon { get; set; }
    
      [JsonProperty("iconPosition")]
      public _MultipleChoiceOptionCollection iconPosition { get; set; }
      #endregion
    }
    #endregion
    
    #region Icon_All
    public class Icon_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Icon> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Icon_Where
    public class Icon_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _ArrayFilter icon { get; set; }
    
      public _ArrayFilter iconPosition { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region LandingPage
    public class LandingPage : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("sections")]
      public LandingPage_Sections_Collection sections { get; set; }
      #endregion
    }
    #endregion
    
    #region LandingPage_All
    public class LandingPage_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<LandingPage> items { get; set; }
      #endregion
    }
    #endregion
    
    #region LandingPage_Sections_Collection
    public class LandingPage_Sections_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<LandingPage_Sections> items { get; set; }
      #endregion
    }
    #endregion
    
    #region LandingPage_Where
    public class LandingPage_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _ArrayFilter sections { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region ListingPage
    public class ListingPage : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("contentType")]
      public string contentType { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingPage_All
    public class ListingPage_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ListingPage> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingPage_Where
    public class ListingPage_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _TextFilter contentType { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region ListingSection
    public class ListingSection : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public _RichText subtitle { get; set; }
    
      [JsonProperty("contentType")]
      public string contentType { get; set; }
    
      [JsonProperty("orderBy")]
      public string orderBy { get; set; }
    
      [JsonProperty("numberOfItems")]
      public double? numberOfItems { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingSection_All
    public class ListingSection_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ListingSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingSection_Where
    public class ListingSection_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _TextFilter contentType { get; set; }
    
      public _TextFilter orderBy { get; set; }
    
      public _NumberFilter numberOfItems { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Menu
    public class Menu : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("actions")]
      public Menu_Actions_Collection actions { get; set; }
      #endregion
    }
    #endregion
    
    #region Menu_Actions_Collection
    public class Menu_Actions_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Action> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Menu_All
    public class Menu_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Menu> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Menu_Where
    public class Menu_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter label { get; set; }
    
      public _ArrayFilter actions { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region NavigationItem
    public class NavigationItem : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("slug")]
      public string slug { get; set; }
    
      [JsonProperty("subpages")]
      public NavigationItem_Subpages_Collection subpages { get; set; }
    
      [JsonProperty("content")]
      public NavigationItem_Content content { get; set; }
    
      [JsonProperty("_seo")]
      public Seo _seo { get; set; }
      #endregion
    }
    #endregion
    
    #region NavigationItem_All
    public class NavigationItem_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<NavigationItem> items { get; set; }
      #endregion
    }
    #endregion
    
    #region NavigationItem_Subpages_Collection
    public class NavigationItem_Subpages_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<NavigationItem> items { get; set; }
      #endregion
    }
    #endregion
    
    #region NavigationItem_Where
    public class NavigationItem_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter label { get; set; }
    
      public _TextFilter slug { get; set; }
    
      public _ArrayFilter subpages { get; set; }
    
      public _ArrayFilter content { get; set; }
    
      public Seo_SnippetFilter _seo { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Post
    public class Post : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("persona")]
      public _TaxonomyTermCollection persona { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("slug")]
      public string slug { get; set; }
    
      [JsonProperty("subtitle")]
      public string subtitle { get; set; }
    
      [JsonProperty("excerpt")]
      public string excerpt { get; set; }
    
      [JsonProperty("image")]
      public _Asset image { get; set; }
    
      [JsonProperty("content")]
      public _RichText content { get; set; }
    
      [JsonProperty("publishingDate")]
      public DateTime? publishingDate { get; set; }
    
      [JsonProperty("author")]
      public Author author { get; set; }
    
      [JsonProperty("_seo")]
      public Seo _seo { get; set; }
      #endregion
    }
    #endregion
    
    #region Post_All
    public class Post_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Post> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Post_Where
    public class Post_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _ArrayFilter persona { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _TextFilter slug { get; set; }
    
      public _TextFilter subtitle { get; set; }
    
      public _TextFilter excerpt { get; set; }
    
      public _DateTimeFilter publishingDate { get; set; }
    
      public _ArrayFilter author { get; set; }
    
      public Seo_SnippetFilter _seo { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Quote
    public class Quote : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("quoteText")]
      public string quoteText { get; set; }
      #endregion
    }
    #endregion
    
    #region Quote_All
    public class Quote_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Quote> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Quote_Where
    public class Quote_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter quoteText { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region SelectFormField
    public class SelectFormField : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("options")]
      public SelectFormField_Options_Collection options { get; set; }
    
      [JsonProperty("defaultValue")]
      public string defaultValue { get; set; }
    
      [JsonProperty("configuration")]
      public _MultipleChoiceOptionCollection configuration { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormFieldOption
    public class SelectFormFieldOption : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("value")]
      public string value { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormFieldOption_All
    public class SelectFormFieldOption_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<SelectFormFieldOption> items { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormFieldOption_Where
    public class SelectFormFieldOption_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter label { get; set; }
    
      public _TextFilter value { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region SelectFormField_All
    public class SelectFormField_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<SelectFormField> items { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormField_Options_Collection
    public class SelectFormField_Options_Collection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<SelectFormFieldOption> items { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormField_Where
    public class SelectFormField_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter label { get; set; }
    
      public _TextFilter name { get; set; }
    
      public _ArrayFilter options { get; set; }
    
      public _TextFilter defaultValue { get; set; }
    
      public _ArrayFilter configuration { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Seo
    public class Seo {
      #region members
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("description")]
      public string description { get; set; }
    
      [JsonProperty("keywords")]
      public string keywords { get; set; }
    
      [JsonProperty("canonicalUrl")]
      public string canonicalUrl { get; set; }
    
      [JsonProperty("options")]
      public _MultipleChoiceOptionCollection options { get; set; }
      #endregion
    }
    #endregion
    
    #region Seo_SnippetFilter
    public class Seo_SnippetFilter {
      #region members
      public _TextFilter title { get; set; }
    
      public _TextFilter description { get; set; }
    
      public _TextFilter keywords { get; set; }
    
      public _TextFilter canonicalUrl { get; set; }
    
      public _ArrayFilter options { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region SimplePage
    public class SimplePage : _Item {
      #region members
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _Sys _system_ { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public string subtitle { get; set; }
    
      [JsonProperty("image")]
      public _Asset image { get; set; }
    
      [JsonProperty("content")]
      public _RichText content { get; set; }
      #endregion
    }
    #endregion
    
    #region SimplePage_All
    public class SimplePage_All {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<SimplePage> items { get; set; }
      #endregion
    }
    #endregion
    
    #region SimplePage_Where
    public class SimplePage_Where {
      #region members
      public _SystemFilter _system_ { get; set; }
    
      public _TextFilter title { get; set; }
    
      public _TextFilter subtitle { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region _ArrayFilter
    public class _ArrayFilter {
      #region members
      /// <summary>
      /// Checks if the field value is an empty array.
      /// </summary>
      public bool? isEmpty { get; set; }
    
      /// <summary>
      /// Checks if the field's array values match at least one of the values in the specified array.
      /// </summary>
      public List<string> containsAny { get; set; }
    
      /// <summary>
      /// Checks if the field's array values match all values in the specified array.
      /// </summary>
      public List<string> containsAll { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region _Asset
    public class _Asset : _AssetInterface {
      #region members
      /// <summary>
      /// The asset's absolute URL.
      /// </summary>
      [JsonProperty("url")]
      public string url { get; set; }
    
      /// <summary>
      /// The asset's display name.
      /// </summary>
      [JsonProperty("name")]
      public string name { get; set; }
    
      /// <summary>
      /// The asset's alt text description for a specific language.
      /// </summary>
      [JsonProperty("description")]
      public string description { get; set; }
    
      /// <summary>
      /// The file's MIME type.
      /// </summary>
      [JsonProperty("type")]
      public string type { get; set; }
    
      /// <summary>
      /// The file's size in bytes.
      /// </summary>
      [JsonProperty("size")]
      public int? size { get; set; }
    
      /// <summary>
      /// The image's width in pixels.
      /// </summary>
      [JsonProperty("width")]
      public int? width { get; set; }
    
      /// <summary>
      /// The image's height in pixels.
      /// </summary>
      [JsonProperty("height")]
      public int? height { get; set; }
      #endregion
    }
    #endregion
    
    #region _AssetCollection
    public class _AssetCollection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      /// <summary>
      /// Individual asset objects.
      /// </summary>
      [JsonProperty("items")]
      public List<_Asset> items { get; set; }
      #endregion
    }
    #endregion
    
    public interface _AssetInterface {
      /// <summary>
      /// The asset's absolute URL.
      /// </summary>
      [JsonProperty("url")]
      string url { get; set; }
    
      /// <summary>
      /// The asset's display name.
      /// </summary>
      [JsonProperty("name")]
      string name { get; set; }
    
      /// <summary>
      /// The asset's alt text description for a specific language.
      /// </summary>
      [JsonProperty("description")]
      string description { get; set; }
    
      /// <summary>
      /// The file's MIME type.
      /// </summary>
      [JsonProperty("type")]
      string type { get; set; }
    
      /// <summary>
      /// The file's size in bytes.
      /// </summary>
      [JsonProperty("size")]
      int? size { get; set; }
    
      /// <summary>
      /// The image's width in pixels.
      /// </summary>
      [JsonProperty("width")]
      int? width { get; set; }
    
      /// <summary>
      /// The image's height in pixels.
      /// </summary>
      [JsonProperty("height")]
      int? height { get; set; }
    }
    
    #region _CodenameFilter
    public class _CodenameFilter {
      #region members
      /// <summary>
      /// Checks if the codename matches exactly to the specified filter value.
      /// </summary>
      public string eq { get; set; }
    
      /// <summary>
      /// Checks if the codename is different than the specified value.
      /// </summary>
      public string notEq { get; set; }
    
      /// <summary>
      /// Checks if the codename matches at least one of the specified array values.
      /// </summary>
      public List<string> @in { get; set; }
    
      /// <summary>
      /// Checks if the codename is different than the specified array values.
      /// </summary>
      public List<string> notIn { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region _Collection
    public class _Collection {
      #region members
      /// <summary>
      /// The collection's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _CollectionSys _system_ { get; set; }
      #endregion
    }
    #endregion
    
    #region _CollectionSys
    public class _CollectionSys {
      #region members
      /// <summary>
      /// The collection's codename.
      /// </summary>
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region _ContentType
    public class _ContentType {
      #region members
      /// <summary>
      /// The content type's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _ContentTypeSys _system_ { get; set; }
      #endregion
    }
    #endregion
    
    #region _ContentTypeSys
    public class _ContentTypeSys {
      #region members
      /// <summary>
      /// The content type's display name.
      /// </summary>
      [JsonProperty("name")]
      public string name { get; set; }
    
      /// <summary>
      /// The content type's codename.
      /// </summary>
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region _DateTimeFilter
    public class _DateTimeFilter {
      #region members
      /// <summary>
      /// Checks if the field's DateTime value matches exactly to the specified ISO-8610 formatted value.
      /// </summary>
      public DateTime? eq { get; set; }
    
      /// <summary>
      /// Checks if the field's DateTime value is different than the specified ISO-8610 formatted value.
      /// </summary>
      public DateTime? notEq { get; set; }
    
      /// <summary>
      /// Checks if the field's DateTime value is less than the specified ISO-8610 formatted value.
      /// </summary>
      public DateTime? lt { get; set; }
    
      /// <summary>
      /// Checks if the field's DateTime value is less than or equal to the specified ISO-8610 formatted value.
      /// </summary>
      public DateTime? lte { get; set; }
    
      /// <summary>
      /// Checks if the field's DateTime value is greater than the specified ISO-8610 formatted value.
      /// </summary>
      public DateTime? gt { get; set; }
    
      /// <summary>
      /// Checks if the field's DateTime value is greater than or equal to the specified ISO-8610 formatted value.
      /// </summary>
      public DateTime? gte { get; set; }
    
      /// <summary>
      /// Checks if the field's DateTime value matches at least one of the specified array values.
      /// </summary>
      public List<DateTime> @in { get; set; }
    
      /// <summary>
      /// Checks if the field's DateTime value is different than the specified array values.
      /// </summary>
      public List<DateTime> notIn { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    public interface _Item {
      /// <summary>
      /// The content item's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      _Sys _system_ { get; set; }
    }
    
    #region _ItemCollection
    public class _ItemCollection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      /// <summary>
      /// Individual item or component objects.
      /// </summary>
      [JsonProperty("items")]
      public List<_Item> items { get; set; }
      #endregion
    }
    #endregion
    
    #region _Language
    public class _Language {
      #region members
      /// <summary>
      /// The language's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _LanguageSys _system_ { get; set; }
      #endregion
    }
    #endregion
    
    #region _LanguageFilter
    public class _LanguageFilter {
      #region members
      /// <summary>
      /// Specifies the language's codename.
      /// </summary>
      [Required]
      [JsonRequired]
      public string languageCodename { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region _LanguageSys
    public class _LanguageSys {
      #region members
      /// <summary>
      /// The language's display name.
      /// </summary>
      [JsonProperty("name")]
      public string name { get; set; }
    
      /// <summary>
      /// The language's codename.
      /// </summary>
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region _MultipleChoiceOption
    public class _MultipleChoiceOption {
      #region members
      /// <summary>
      /// The multiple choice option's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _MultipleChoiceOptionSys _system_ { get; set; }
      #endregion
    }
    #endregion
    
    #region _MultipleChoiceOptionCollection
    public class _MultipleChoiceOptionCollection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      /// <summary>
      /// Individual multiple choice option objects.
      /// </summary>
      [JsonProperty("items")]
      public List<_MultipleChoiceOption> items { get; set; }
      #endregion
    }
    #endregion
    
    #region _MultipleChoiceOptionSys
    public class _MultipleChoiceOptionSys {
      #region members
      /// <summary>
      /// The multiple choice option's display name.
      /// </summary>
      [JsonProperty("name")]
      public string name { get; set; }
    
      /// <summary>
      /// The multiple choice option's codename.
      /// </summary>
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region _NumberFilter
    public class _NumberFilter {
      #region members
      /// <summary>
      /// Checks if the field value matches exactly to the specified float value.
      /// </summary>
      public double? eq { get; set; }
    
      /// <summary>
      /// Checks if the field value is different than the specified float value.
      /// </summary>
      public double? notEq { get; set; }
    
      /// <summary>
      /// Checks if the field value is less than the specified float value.
      /// </summary>
      public double? lt { get; set; }
    
      /// <summary>
      /// Checks if the field value is less than or equal to the specified float value.
      /// </summary>
      public double? lte { get; set; }
    
      /// <summary>
      /// Checks if the field value is greater than the specified float value.
      /// </summary>
      public double? gt { get; set; }
    
      /// <summary>
      /// Checks if the field value is greater than or equal to the specified float value.
      /// </summary>
      public double? gte { get; set; }
    
      /// <summary>
      /// Checks if the field value matches at least one of the specified array values.
      /// </summary>
      public List<double> @in { get; set; }
    
      /// <summary>
      /// Checks if the field value is different than the specified array values.
      /// </summary>
      public List<double> notIn { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region _RichText
    public class _RichText {
      #region members
      /// <summary>
      /// The rich text's HTML output. Contains references to assets, links to content items, linked content, and components.
      /// </summary>
      [JsonProperty("html")]
      public string html { get; set; }
    
      /// <summary>
      /// Contains metadata of the content items referenced in hyperlinks.
      /// </summary>
      [JsonProperty("itemHyperlinks")]
      public _ItemCollection itemHyperlinks { get; set; }
    
      /// <summary>
      /// Contains metadata of the assets inserted into the rich text.
      /// </summary>
      [JsonProperty("assets")]
      public _RichTextAssetCollection assets { get; set; }
    
      /// <summary>
      /// Contains metadata of the content items inserted into the rich text.
      /// </summary>
      [JsonProperty("linkedItems")]
      public _ItemCollection linkedItems { get; set; }
    
      /// <summary>
      /// Contains metadata of the components inserted into the rich text.
      /// </summary>
      [JsonProperty("components")]
      public _ItemCollection components { get; set; }
      #endregion
    }
    #endregion
    
    #region _RichTextAsset
    public class _RichTextAsset : _AssetInterface {
      #region members
      /// <summary>
      /// Identifier of the asset as used in the rich text element.
      /// </summary>
      [JsonProperty("imageId")]
      public string imageId { get; set; }
    
      /// <summary>
      /// The asset's absolute URL.
      /// </summary>
      [JsonProperty("url")]
      public string url { get; set; }
    
      /// <summary>
      /// The asset's display name.
      /// </summary>
      [JsonProperty("name")]
      public string name { get; set; }
    
      /// <summary>
      /// The asset's alt text description for a specific language.
      /// </summary>
      [JsonProperty("description")]
      public string description { get; set; }
    
      /// <summary>
      /// The file's MIME type.
      /// </summary>
      [JsonProperty("type")]
      public string type { get; set; }
    
      /// <summary>
      /// The file's size in bytes.
      /// </summary>
      [JsonProperty("size")]
      public int? size { get; set; }
    
      /// <summary>
      /// The image's width in pixels.
      /// </summary>
      [JsonProperty("width")]
      public int? width { get; set; }
    
      /// <summary>
      /// The image's height in pixels.
      /// </summary>
      [JsonProperty("height")]
      public int? height { get; set; }
      #endregion
    }
    #endregion
    
    #region _RichTextAssetCollection
    public class _RichTextAssetCollection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      /// <summary>
      /// Individual asset objects.
      /// </summary>
      [JsonProperty("items")]
      public List<_RichTextAsset> items { get; set; }
      #endregion
    }
    #endregion
    
    #region _RootQuery
    public class _RootQuery {
      #region members
      [JsonProperty("featuresSection")]
      public FeaturesSection featuresSection { get; set; }
    
      [JsonProperty("featuresSection_All")]
      public FeaturesSection_All featuresSection_All { get; set; }
    
      [JsonProperty("menu")]
      public Menu menu { get; set; }
    
      [JsonProperty("menu_All")]
      public Menu_All menu_All { get; set; }
    
      [JsonProperty("navigationItem")]
      public NavigationItem navigationItem { get; set; }
    
      [JsonProperty("navigationItem_All")]
      public NavigationItem_All navigationItem_All { get; set; }
    
      [JsonProperty("contentSection")]
      public ContentSection contentSection { get; set; }
    
      [JsonProperty("contentSection_All")]
      public ContentSection_All contentSection_All { get; set; }
    
      [JsonProperty("icon")]
      public Icon icon { get; set; }
    
      [JsonProperty("icon_All")]
      public Icon_All icon_All { get; set; }
    
      [JsonProperty("codeBlock")]
      public CodeBlock codeBlock { get; set; }
    
      [JsonProperty("codeBlock_All")]
      public CodeBlock_All codeBlock_All { get; set; }
    
      [JsonProperty("selectFormFieldOption")]
      public SelectFormFieldOption selectFormFieldOption { get; set; }
    
      [JsonProperty("selectFormFieldOption_All")]
      public SelectFormFieldOption_All selectFormFieldOption_All { get; set; }
    
      [JsonProperty("action")]
      public Action action { get; set; }
    
      [JsonProperty("action_All")]
      public Action_All action_All { get; set; }
    
      [JsonProperty("quote")]
      public Quote quote { get; set; }
    
      [JsonProperty("quote_All")]
      public Quote_All quote_All { get; set; }
    
      [JsonProperty("listingSection")]
      public ListingSection listingSection { get; set; }
    
      [JsonProperty("listingSection_All")]
      public ListingSection_All listingSection_All { get; set; }
    
      [JsonProperty("heroSection")]
      public HeroSection heroSection { get; set; }
    
      [JsonProperty("heroSection_All")]
      public HeroSection_All heroSection_All { get; set; }
    
      [JsonProperty("homepage")]
      public Homepage homepage { get; set; }
    
      [JsonProperty("homepage_All")]
      public Homepage_All homepage_All { get; set; }
    
      [JsonProperty("feature")]
      public Feature feature { get; set; }
    
      [JsonProperty("feature_All")]
      public Feature_All feature_All { get; set; }
    
      [JsonProperty("simplePage")]
      public SimplePage simplePage { get; set; }
    
      [JsonProperty("simplePage_All")]
      public SimplePage_All simplePage_All { get; set; }
    
      [JsonProperty("post")]
      public Post post { get; set; }
    
      [JsonProperty("post_All")]
      public Post_All post_All { get; set; }
    
      [JsonProperty("author")]
      public Author author { get; set; }
    
      [JsonProperty("author_All")]
      public Author_All author_All { get; set; }
    
      [JsonProperty("baseFormField")]
      public BaseFormField baseFormField { get; set; }
    
      [JsonProperty("baseFormField_All")]
      public BaseFormField_All baseFormField_All { get; set; }
    
      [JsonProperty("form")]
      public Form form { get; set; }
    
      [JsonProperty("form_All")]
      public Form_All form_All { get; set; }
    
      [JsonProperty("contactSection")]
      public ContactSection contactSection { get; set; }
    
      [JsonProperty("contactSection_All")]
      public ContactSection_All contactSection_All { get; set; }
    
      [JsonProperty("selectFormField")]
      public SelectFormField selectFormField { get; set; }
    
      [JsonProperty("selectFormField_All")]
      public SelectFormField_All selectFormField_All { get; set; }
    
      [JsonProperty("externalUrl")]
      public ExternalUrl externalUrl { get; set; }
    
      [JsonProperty("externalUrl_All")]
      public ExternalUrl_All externalUrl_All { get; set; }
    
      [JsonProperty("landingPage")]
      public LandingPage landingPage { get; set; }
    
      [JsonProperty("landingPage_All")]
      public LandingPage_All landingPage_All { get; set; }
    
      [JsonProperty("listingPage")]
      public ListingPage listingPage { get; set; }
    
      [JsonProperty("listingPage_All")]
      public ListingPage_All listingPage_All { get; set; }
    
      [JsonProperty("ctaSection")]
      public CtaSection ctaSection { get; set; }
    
      [JsonProperty("ctaSection_All")]
      public CtaSection_All ctaSection_All { get; set; }
      #endregion
    }
    #endregion
    
    #region _Sys
    public class _Sys {
      #region members
      /// <summary>
      /// The content item's display name.
      /// </summary>
      [JsonProperty("name")]
      public string name { get; set; }
    
      /// <summary>
      /// The content item's codename.
      /// </summary>
      [JsonProperty("codename")]
      public string codename { get; set; }
    
      /// <summary>
      /// The language that the item's content is in.
      /// </summary>
      [JsonProperty("language")]
      public _Language language { get; set; }
    
      /// <summary>
      /// The content item's type.
      /// </summary>
      [JsonProperty("type")]
      public _ContentType type { get; set; }
    
      /// <summary>
      /// [ISO-8601](https://en.wikipedia.org/wiki/ISO_8601) formatted date and time (e.g. 2021-11-02T13:27:31Z) of the last change to user-content of the item. The value is not affected when changing workflow steps.
      /// </summary>
      [JsonProperty("lastModified")]
      public DateTime lastModified { get; set; }
    
      /// <summary>
      /// The content item's collection. For projects without collection enabled, the value is `default`.
      /// </summary>
      [JsonProperty("collection")]
      public _Collection collection { get; set; }
    
      /// <summary>
      /// The content item's current workflow step.
      /// </summary>
      [JsonProperty("workflowStep")]
      public _WorkflowStep workflowStep { get; set; }
    
      /// <summary>
      /// The content item's internal ID.
      /// </summary>
      [JsonProperty("id")]
      public Guid id { get; set; }
      #endregion
    }
    #endregion
    
    #region _SystemFilter
    /// <summary>
    /// Allows filtering based on system properties.
    /// </summary>
    public class _SystemFilter {
      #region members
      /// <summary>
      /// The content item's display name.
      /// </summary>
      public _TextFilter name { get; set; }
    
      /// <summary>
      /// The date and time of the last change to user-content of the item. The value is not affected when changing workflow steps.
      /// </summary>
      public _DateTimeFilter lastModified { get; set; }
    
      /// <summary>
      /// The content item's collection.
      /// </summary>
      public _CodenameFilter collection { get; set; }
    
      /// <summary>
      /// The content item's current workflow step.
      /// </summary>
      public _CodenameFilter workflowStep { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region _TaxonomyTerm
    public class _TaxonomyTerm {
      #region members
      /// <summary>
      /// The taxonomy term's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _TaxonomyTermSys _system_ { get; set; }
      #endregion
    }
    #endregion
    
    #region _TaxonomyTermCollection
    public class _TaxonomyTermCollection {
      #region members
      /// <summary>
      /// Specifies the number of objects to skip. If not specified, the API returns the first page of results.
      /// </summary>
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      /// <summary>
      /// Specifies the number of items to retrieve. If not specified, the API returns a maximum of 10 objects.
      /// </summary>
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      /// <summary>
      /// Individual taxonomy term objects.
      /// </summary>
      [JsonProperty("items")]
      public List<_TaxonomyTerm> items { get; set; }
      #endregion
    }
    #endregion
    
    #region _TaxonomyTermSys
    public class _TaxonomyTermSys {
      #region members
      /// <summary>
      /// The taxonomy term's display name.
      /// </summary>
      [JsonProperty("name")]
      public string name { get; set; }
    
      /// <summary>
      /// The taxonomy term's codename.
      /// </summary>
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region _TextFilter
    public class _TextFilter {
      #region members
      /// <summary>
      /// Checks if the field value matches exactly to the specified filter value.
      /// </summary>
      public string eq { get; set; }
    
      /// <summary>
      /// Checks if the field value is different than the specified value.
      /// </summary>
      public string notEq { get; set; }
    
      /// <summary>
      /// Checks if the field value is an empty string.
      /// </summary>
      public bool? isEmpty { get; set; }
    
      /// <summary>
      /// Checks if the field value matches at least one of the specified array values.
      /// </summary>
      public List<string> @in { get; set; }
    
      /// <summary>
      /// Checks if the field value is different than the specified array values.
      /// </summary>
      public List<string> notIn { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
    
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region _WorkflowStep
    public class _WorkflowStep {
      #region members
      /// <summary>
      /// The workflow step's predefined system fields.
      /// </summary>
      [JsonProperty("_system_")]
      public _WorkflowStepSys _system_ { get; set; }
      #endregion
    }
    #endregion
    
    #region _WorkflowStepSys
    public class _WorkflowStepSys {
      #region members
      /// <summary>
      /// The workflow step's codename.
      /// </summary>
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
  }
  
}
