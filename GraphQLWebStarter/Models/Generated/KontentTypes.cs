using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GraphQLWebStarter.Models.Generated {
  public class KontentTypes {
    
    #region Action
    public class Action : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("navigationItem")]
      public ItemsCollection navigationItem { get; set; }
    
      [JsonProperty("icon")]
      public ItemsCollection icon { get; set; }
    
      [JsonProperty("role")]
      public List<MultipleChoiceOption> role { get; set; }
    
      [JsonProperty("options")]
      public List<MultipleChoiceOption> options { get; set; }
      #endregion
    }
    #endregion
    
    #region ActionCollection
    public class ActionCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Action> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ActionWhere
    public class ActionWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string labelEq { get; set; }
    
      public string navigationItemLinksCodename { get; set; }
    
      public string iconLinksCodename { get; set; }
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
    
    #region Asset
    public class Asset {
      #region members
      [JsonProperty("url")]
      public string url { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("description")]
      public string description { get; set; }
    
      [JsonProperty("type")]
      public string type { get; set; }
    
      [JsonProperty("size")]
      public int? size { get; set; }
    
      [JsonProperty("imageId")]
      public string imageId { get; set; }
      #endregion
    }
    #endregion
    
    #region AssetCollection
    public class AssetCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Asset> items { get; set; }
      #endregion
    }
    #endregion
    
    #region Author
    public class Author : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("firstName")]
      public string firstName { get; set; }
    
      [JsonProperty("lastName")]
      public string lastName { get; set; }
    
      [JsonProperty("bio")]
      public string bio { get; set; }
    
      [JsonProperty("photo")]
      public List<Asset> photo { get; set; }
      #endregion
    }
    #endregion
    
    #region AuthorCollection
    public class AuthorCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Author> items { get; set; }
      #endregion
    }
    #endregion
    
    #region AuthorWhere
    public class AuthorWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string firstNameEq { get; set; }
    
      public string lastNameEq { get; set; }
    
      public string bioEq { get; set; }
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
    public class BaseFormField : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("type")]
      public List<MultipleChoiceOption> type { get; set; }
    
      [JsonProperty("defaultValue")]
      public string defaultValue { get; set; }
    
      [JsonProperty("configuration")]
      public List<MultipleChoiceOption> configuration { get; set; }
      #endregion
    }
    #endregion
    
    #region BaseFormFieldCollection
    public class BaseFormFieldCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<BaseFormField> items { get; set; }
      #endregion
    }
    #endregion
    
    #region BaseFormFieldWhere
    public class BaseFormFieldWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string labelEq { get; set; }
    
      public string nameEq { get; set; }
    
      public string defaultValueEq { get; set; }
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
    public class CodeBlock : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("code")]
      public RichText code { get; set; }
      #endregion
    }
    #endregion
    
    #region CodeBlockCollection
    public class CodeBlockCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<CodeBlock> items { get; set; }
      #endregion
    }
    #endregion
    
    #region CodeBlockWhere
    public class CodeBlockWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
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
    
    #region Collection
    public class Collection {
      #region members
      [JsonProperty("system")]
      public CollectionSys system { get; set; }
      #endregion
    }
    #endregion
    
    #region CollectionSys
    public class CollectionSys {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region ContactSection
    public class ContactSection : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public RichText subtitle { get; set; }
    
      [JsonProperty("content")]
      public RichText content { get; set; }
    
      [JsonProperty("form")]
      public ItemsCollection form { get; set; }
      #endregion
    }
    #endregion
    
    #region ContactSectionCollection
    public class ContactSectionCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ContactSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ContactSectionWhere
    public class ContactSectionWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string formLinksCodename { get; set; }
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
    public class ContentSection : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("image")]
      public List<Asset> image { get; set; }
    
      [JsonProperty("content")]
      public RichText content { get; set; }
    
      [JsonProperty("actions")]
      public ItemsCollection actions { get; set; }
      #endregion
    }
    #endregion
    
    #region ContentSectionCollection
    public class ContentSectionCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ContentSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ContentSectionWhere
    public class ContentSectionWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string actionsLinksCodename { get; set; }
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
    
    #region ContentType
    public class ContentType {
      #region members
      [JsonProperty("system")]
      public ContentTypeSys system { get; set; }
      #endregion
    }
    #endregion
    
    #region ContentTypeSys
    public class ContentTypeSys {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region CtaSection
    public class CtaSection : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public RichText subtitle { get; set; }
    
      [JsonProperty("action")]
      public ItemsCollection action { get; set; }
      #endregion
    }
    #endregion
    
    #region CtaSectionCollection
    public class CtaSectionCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<CtaSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region CtaSectionWhere
    public class CtaSectionWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string actionLinksCodename { get; set; }
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
    
    #region CustomElement
    public class CustomElement {
      #region members
      [JsonProperty("value")]
      public string value { get; set; }
      #endregion
    }
    #endregion
    
    #region ExternalUrl
    public class ExternalUrl : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("url")]
      public string url { get; set; }
      #endregion
    }
    #endregion
    
    #region ExternalUrlCollection
    public class ExternalUrlCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ExternalUrl> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ExternalUrlWhere
    public class ExternalUrlWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string urlEq { get; set; }
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
    public class Feature : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("image")]
      public List<Asset> image { get; set; }
    
      [JsonProperty("content")]
      public RichText content { get; set; }
    
      [JsonProperty("actions")]
      public ItemsCollection actions { get; set; }
      #endregion
    }
    #endregion
    
    #region FeatureCollection
    public class FeatureCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Feature> items { get; set; }
      #endregion
    }
    #endregion
    
    #region FeatureWhere
    public class FeatureWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string actionsLinksCodename { get; set; }
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
    public class FeaturesSection : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public RichText subtitle { get; set; }
    
      [JsonProperty("features")]
      public ItemsCollection features { get; set; }
      #endregion
    }
    #endregion
    
    #region FeaturesSectionCollection
    public class FeaturesSectionCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<FeaturesSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region FeaturesSectionWhere
    public class FeaturesSectionWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string featuresLinksCodename { get; set; }
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
    public class Form : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("content")]
      public string content { get; set; }
    
      [JsonProperty("fields")]
      public ItemsCollection fields { get; set; }
    
      [JsonProperty("submitLabel")]
      public string submitLabel { get; set; }
    
      [JsonProperty("formId")]
      public string formId { get; set; }
    
      [JsonProperty("formAction")]
      public string formAction { get; set; }
      #endregion
    }
    #endregion
    
    #region FormCollection
    public class FormCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Form> items { get; set; }
      #endregion
    }
    #endregion
    
    #region FormWhere
    public class FormWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string contentEq { get; set; }
    
      public string fieldsLinksCodename { get; set; }
    
      public string submitLabelEq { get; set; }
    
      public string formIdEq { get; set; }
    
      public string formActionEq { get; set; }
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
    public class HeroSection : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("image")]
      public List<Asset> image { get; set; }
    
      [JsonProperty("content")]
      public RichText content { get; set; }
    
      [JsonProperty("actions")]
      public ItemsCollection actions { get; set; }
      #endregion
    }
    #endregion
    
    #region HeroSectionCollection
    public class HeroSectionCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<HeroSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region HeroSectionWhere
    public class HeroSectionWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string actionsLinksCodename { get; set; }
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
    public class Homepage : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("subpages")]
      public ItemsCollection subpages { get; set; }
    
      [JsonProperty("content")]
      public ItemsCollection content { get; set; }
    
      [JsonProperty("slug")]
      public string slug { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("headerLogo")]
      public List<Asset> headerLogo { get; set; }
    
      [JsonProperty("mainMenu")]
      public ItemsCollection mainMenu { get; set; }
    
      [JsonProperty("copyright")]
      public RichText copyright { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("font")]
      public List<MultipleChoiceOption> font { get; set; }
    
      [JsonProperty("favicon")]
      public List<Asset> favicon { get; set; }
    
      [JsonProperty("palette")]
      public List<MultipleChoiceOption> palette { get; set; }
    
      [JsonProperty("seoTitle")]
      public string seoTitle { get; set; }
    
      [JsonProperty("seoDescription")]
      public string seoDescription { get; set; }
    
      [JsonProperty("seoKeywords")]
      public string seoKeywords { get; set; }
    
      [JsonProperty("seoCanonicalUrl")]
      public string seoCanonicalUrl { get; set; }
    
      [JsonProperty("seoOptions")]
      public List<MultipleChoiceOption> seoOptions { get; set; }
    
      [JsonProperty("seo")]
      public Seo seo { get; set; }
      #endregion
    }
    #endregion
    
    #region HomepageCollection
    public class HomepageCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Homepage> items { get; set; }
      #endregion
    }
    #endregion
    
    #region HomepageWhere
    public class HomepageWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string subpagesLinksCodename { get; set; }
    
      public string contentLinksCodename { get; set; }
    
      public string slugEq { get; set; }
    
      public string labelEq { get; set; }
    
      public string mainMenuLinksCodename { get; set; }
    
      public string titleEq { get; set; }
    
      public string seoTitleEq { get; set; }
    
      public string seoDescriptionEq { get; set; }
    
      public string seoKeywordsEq { get; set; }
    
      public string seoCanonicalUrlEq { get; set; }
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
    public class Icon : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("icon")]
      public List<MultipleChoiceOption> icon { get; set; }
    
      [JsonProperty("iconPosition")]
      public List<MultipleChoiceOption> iconPosition { get; set; }
      #endregion
    }
    #endregion
    
    #region IconCollection
    public class IconCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Icon> items { get; set; }
      #endregion
    }
    #endregion
    
    #region IconWhere
    public class IconWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
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
    
    public interface Item {
      [JsonProperty("system")]
      Sys system { get; set; }
    }
    
    #region ItemsCollection
    public class ItemsCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Item> items { get; set; }
      #endregion
    }
    #endregion
    
    #region LandingPage
    public class LandingPage : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("sections")]
      public ItemsCollection sections { get; set; }
      #endregion
    }
    #endregion
    
    #region LandingPageCollection
    public class LandingPageCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<LandingPage> items { get; set; }
      #endregion
    }
    #endregion
    
    #region LandingPageWhere
    public class LandingPageWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string sectionsLinksCodename { get; set; }
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
    
    #region Language
    public class Language {
      #region members
      [JsonProperty("system")]
      public LanguageSys system { get; set; }
      #endregion
    }
    #endregion
    
    #region LanguageFilter
    public class LanguageFilter {
      #region members
      [Required]
      [JsonRequired]
      public string language { get; set; }
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
    
    #region LanguageSys
    public class LanguageSys {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingPage
    public class ListingPage : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("contentType")]
      public string contentType { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingPageCollection
    public class ListingPageCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ListingPage> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingPageWhere
    public class ListingPageWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string contentTypeEq { get; set; }
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
    public class ListingSection : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public RichText subtitle { get; set; }
    
      [JsonProperty("contentType")]
      public string contentType { get; set; }
    
      [JsonProperty("orderBy")]
      public string orderBy { get; set; }
    
      [JsonProperty("numberOfItems")]
      public double numberOfItems { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingSectionCollection
    public class ListingSectionCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<ListingSection> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ListingSectionWhere
    public class ListingSectionWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string contentTypeEq { get; set; }
    
      public string orderByEq { get; set; }
    
      public int? numberOfItemsEq { get; set; }
    
      public int? numberOfItemsGt { get; set; }
    
      public int? numberOfItemsLt { get; set; }
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
    public class Menu : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("actions")]
      public ItemsCollection actions { get; set; }
      #endregion
    }
    #endregion
    
    #region MenuCollection
    public class MenuCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Menu> items { get; set; }
      #endregion
    }
    #endregion
    
    #region MenuWhere
    public class MenuWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string labelEq { get; set; }
    
      public string actionsLinksCodename { get; set; }
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
    
    #region MultipleChoiceOption
    public class MultipleChoiceOption {
      #region members
      [JsonProperty("system")]
      public MultipleChoiceOptionSys system { get; set; }
      #endregion
    }
    #endregion
    
    #region MultipleChoiceOptionSys
    public class MultipleChoiceOptionSys {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region NavigationItem
    public class NavigationItem : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("slug")]
      public string slug { get; set; }
    
      [JsonProperty("subpages")]
      public ItemsCollection subpages { get; set; }
    
      [JsonProperty("content")]
      public ItemsCollection content { get; set; }
    
      [JsonProperty("seoTitle")]
      public string seoTitle { get; set; }
    
      [JsonProperty("seoDescription")]
      public string seoDescription { get; set; }
    
      [JsonProperty("seoKeywords")]
      public string seoKeywords { get; set; }
    
      [JsonProperty("seoCanonicalUrl")]
      public string seoCanonicalUrl { get; set; }
    
      [JsonProperty("seoOptions")]
      public List<MultipleChoiceOption> seoOptions { get; set; }
    
      [JsonProperty("seo")]
      public Seo seo { get; set; }
      #endregion
    }
    #endregion
    
    #region NavigationItemCollection
    public class NavigationItemCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<NavigationItem> items { get; set; }
      #endregion
    }
    #endregion
    
    #region NavigationItemWhere
    public class NavigationItemWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string labelEq { get; set; }
    
      public string slugEq { get; set; }
    
      public string subpagesLinksCodename { get; set; }
    
      public string contentLinksCodename { get; set; }
    
      public string seoTitleEq { get; set; }
    
      public string seoDescriptionEq { get; set; }
    
      public string seoKeywordsEq { get; set; }
    
      public string seoCanonicalUrlEq { get; set; }
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
    public class Post : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("persona")]
      public List<TaxonomyTerm> persona { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("slug")]
      public string slug { get; set; }
    
      [JsonProperty("subtitle")]
      public string subtitle { get; set; }
    
      [JsonProperty("excerpt")]
      public string excerpt { get; set; }
    
      [JsonProperty("image")]
      public List<Asset> image { get; set; }
    
      [JsonProperty("content")]
      public RichText content { get; set; }
    
      [JsonProperty("publishingDate")]
      public DateTime publishingDate { get; set; }
    
      [JsonProperty("author")]
      public ItemsCollection author { get; set; }
    
      [JsonProperty("seoTitle")]
      public string seoTitle { get; set; }
    
      [JsonProperty("seoDescription")]
      public string seoDescription { get; set; }
    
      [JsonProperty("seoKeywords")]
      public string seoKeywords { get; set; }
    
      [JsonProperty("seoCanonicalUrl")]
      public string seoCanonicalUrl { get; set; }
    
      [JsonProperty("seoOptions")]
      public List<MultipleChoiceOption> seoOptions { get; set; }
    
      [JsonProperty("seo")]
      public Seo seo { get; set; }
      #endregion
    }
    #endregion
    
    #region PostCollection
    public class PostCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Post> items { get; set; }
      #endregion
    }
    #endregion
    
    #region PostWhere
    public class PostWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string personaLinksTerm { get; set; }
    
      public string titleEq { get; set; }
    
      public string slugEq { get; set; }
    
      public string subtitleEq { get; set; }
    
      public string excerptEq { get; set; }
    
      public DateTime? publishingDateEq { get; set; }
    
      public DateTime? publishingDateGt { get; set; }
    
      public DateTime? publishingDateLt { get; set; }
    
      public string authorLinksCodename { get; set; }
    
      public string seoTitleEq { get; set; }
    
      public string seoDescriptionEq { get; set; }
    
      public string seoKeywordsEq { get; set; }
    
      public string seoCanonicalUrlEq { get; set; }
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
    public class Quote : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("quoteText")]
      public string quoteText { get; set; }
      #endregion
    }
    #endregion
    
    #region QuoteCollection
    public class QuoteCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Quote> items { get; set; }
      #endregion
    }
    #endregion
    
    #region QuoteWhere
    public class QuoteWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string quoteTextEq { get; set; }
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
    
    #region RichText
    public class RichText {
      #region members
      [JsonProperty("html")]
      public string html { get; set; }
    
      [JsonProperty("links")]
      public ItemsCollection links { get; set; }
    
      [JsonProperty("modularContent")]
      public ItemsCollection modularContent { get; set; }
    
      [JsonProperty("components")]
      public ItemsCollection components { get; set; }
    
      [JsonProperty("assets")]
      public AssetCollection assets { get; set; }
    
      [JsonProperty("allComponents")]
      public ItemsCollection allComponents { get; set; }
      #endregion
    }
    #endregion
    
    #region RootQuery
    public class RootQuery {
      #region members
      [JsonProperty("ctaSection")]
      public CtaSection ctaSection { get; set; }
    
      [JsonProperty("ctaSectionCollection")]
      public CtaSectionCollection ctaSectionCollection { get; set; }
    
      [JsonProperty("listingPage")]
      public ListingPage listingPage { get; set; }
    
      [JsonProperty("listingPageCollection")]
      public ListingPageCollection listingPageCollection { get; set; }
    
      [JsonProperty("action")]
      public Action action { get; set; }
    
      [JsonProperty("actionCollection")]
      public ActionCollection actionCollection { get; set; }
    
      [JsonProperty("contactSection")]
      public ContactSection contactSection { get; set; }
    
      [JsonProperty("contactSectionCollection")]
      public ContactSectionCollection contactSectionCollection { get; set; }
    
      [JsonProperty("listingSection")]
      public ListingSection listingSection { get; set; }
    
      [JsonProperty("listingSectionCollection")]
      public ListingSectionCollection listingSectionCollection { get; set; }
    
      [JsonProperty("menu")]
      public Menu menu { get; set; }
    
      [JsonProperty("menuCollection")]
      public MenuCollection menuCollection { get; set; }
    
      [JsonProperty("feature")]
      public Feature feature { get; set; }
    
      [JsonProperty("featureCollection")]
      public FeatureCollection featureCollection { get; set; }
    
      [JsonProperty("quote")]
      public Quote quote { get; set; }
    
      [JsonProperty("quoteCollection")]
      public QuoteCollection quoteCollection { get; set; }
    
      [JsonProperty("selectFormFieldOption")]
      public SelectFormFieldOption selectFormFieldOption { get; set; }
    
      [JsonProperty("selectFormFieldOptionCollection")]
      public SelectFormFieldOptionCollection selectFormFieldOptionCollection { get; set; }
    
      [JsonProperty("selectFormField")]
      public SelectFormField selectFormField { get; set; }
    
      [JsonProperty("selectFormFieldCollection")]
      public SelectFormFieldCollection selectFormFieldCollection { get; set; }
    
      [JsonProperty("landingPage")]
      public LandingPage landingPage { get; set; }
    
      [JsonProperty("landingPageCollection")]
      public LandingPageCollection landingPageCollection { get; set; }
    
      [JsonProperty("featuresSection")]
      public FeaturesSection featuresSection { get; set; }
    
      [JsonProperty("featuresSectionCollection")]
      public FeaturesSectionCollection featuresSectionCollection { get; set; }
    
      [JsonProperty("homepage")]
      public Homepage homepage { get; set; }
    
      [JsonProperty("homepageCollection")]
      public HomepageCollection homepageCollection { get; set; }
    
      [JsonProperty("codeBlock")]
      public CodeBlock codeBlock { get; set; }
    
      [JsonProperty("codeBlockCollection")]
      public CodeBlockCollection codeBlockCollection { get; set; }
    
      [JsonProperty("navigationItem")]
      public NavigationItem navigationItem { get; set; }
    
      [JsonProperty("navigationItemCollection")]
      public NavigationItemCollection navigationItemCollection { get; set; }
    
      [JsonProperty("author")]
      public Author author { get; set; }
    
      [JsonProperty("authorCollection")]
      public AuthorCollection authorCollection { get; set; }
    
      [JsonProperty("form")]
      public Form form { get; set; }
    
      [JsonProperty("formCollection")]
      public FormCollection formCollection { get; set; }
    
      [JsonProperty("heroSection")]
      public HeroSection heroSection { get; set; }
    
      [JsonProperty("heroSectionCollection")]
      public HeroSectionCollection heroSectionCollection { get; set; }
    
      [JsonProperty("simplePage")]
      public SimplePage simplePage { get; set; }
    
      [JsonProperty("simplePageCollection")]
      public SimplePageCollection simplePageCollection { get; set; }
    
      [JsonProperty("post")]
      public Post post { get; set; }
    
      [JsonProperty("postCollection")]
      public PostCollection postCollection { get; set; }
    
      [JsonProperty("externalUrl")]
      public ExternalUrl externalUrl { get; set; }
    
      [JsonProperty("externalUrlCollection")]
      public ExternalUrlCollection externalUrlCollection { get; set; }
    
      [JsonProperty("icon")]
      public Icon icon { get; set; }
    
      [JsonProperty("iconCollection")]
      public IconCollection iconCollection { get; set; }
    
      [JsonProperty("contentSection")]
      public ContentSection contentSection { get; set; }
    
      [JsonProperty("contentSectionCollection")]
      public ContentSectionCollection contentSectionCollection { get; set; }
    
      [JsonProperty("baseFormField")]
      public BaseFormField baseFormField { get; set; }
    
      [JsonProperty("baseFormFieldCollection")]
      public BaseFormFieldCollection baseFormFieldCollection { get; set; }
    
      [JsonProperty("showcase")]
      public Showcase showcase { get; set; }
    
      [JsonProperty("showcaseCollection")]
      public ShowcaseCollection showcaseCollection { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormField
    public class SelectFormField : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("options")]
      public ItemsCollection options { get; set; }
    
      [JsonProperty("defaultValue")]
      public string defaultValue { get; set; }
    
      [JsonProperty("configuration")]
      public List<MultipleChoiceOption> configuration { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormFieldCollection
    public class SelectFormFieldCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<SelectFormField> items { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormFieldOption
    public class SelectFormFieldOption : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("label")]
      public string label { get; set; }
    
      [JsonProperty("value")]
      public string value { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormFieldOptionCollection
    public class SelectFormFieldOptionCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<SelectFormFieldOption> items { get; set; }
      #endregion
    }
    #endregion
    
    #region SelectFormFieldOptionWhere
    public class SelectFormFieldOptionWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string labelEq { get; set; }
    
      public string valueEq { get; set; }
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
    
    #region SelectFormFieldWhere
    public class SelectFormFieldWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string labelEq { get; set; }
    
      public string nameEq { get; set; }
    
      public string optionsLinksCodename { get; set; }
    
      public string defaultValueEq { get; set; }
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
      public List<MultipleChoiceOption> options { get; set; }
      #endregion
    }
    #endregion
    
    #region Showcase
    public class Showcase : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("textElement")]
      public string textElement { get; set; }
    
      [JsonProperty("numberElement")]
      public double numberElement { get; set; }
    
      [JsonProperty("dateTimeElement")]
      public DateTime dateTimeElement { get; set; }
    
      [JsonProperty("customElement")]
      public CustomElement customElement { get; set; }
    
      [JsonProperty("assetsElement")]
      public List<Asset> assetsElement { get; set; }
    
      [JsonProperty("multipleChoiceElement")]
      public List<MultipleChoiceOption> multipleChoiceElement { get; set; }
    
      [JsonProperty("persona")]
      public List<TaxonomyTerm> persona { get; set; }
    
      [JsonProperty("linkedItemsElement")]
      public ItemsCollection linkedItemsElement { get; set; }
    
      [JsonProperty("richTextElement")]
      public RichText richTextElement { get; set; }
      #endregion
    }
    #endregion
    
    #region ShowcaseCollection
    public class ShowcaseCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<Showcase> items { get; set; }
      #endregion
    }
    #endregion
    
    #region ShowcaseWhere
    public class ShowcaseWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string textElementEq { get; set; }
    
      public int? numberElementEq { get; set; }
    
      public int? numberElementGt { get; set; }
    
      public int? numberElementLt { get; set; }
    
      public DateTime? dateTimeElementEq { get; set; }
    
      public DateTime? dateTimeElementGt { get; set; }
    
      public DateTime? dateTimeElementLt { get; set; }
    
      public string personaLinksTerm { get; set; }
    
      public string linkedItemsElementLinksCodename { get; set; }
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
    public class SimplePage : Item {
      #region members
      [JsonProperty("system")]
      public Sys system { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("subtitle")]
      public string subtitle { get; set; }
    
      [JsonProperty("image")]
      public List<Asset> image { get; set; }
    
      [JsonProperty("content")]
      public RichText content { get; set; }
      #endregion
    }
    #endregion
    
    #region SimplePageCollection
    public class SimplePageCollection {
      #region members
      [JsonProperty("offset")]
      public int offset { get; set; }
    
      [JsonProperty("limit")]
      public int limit { get; set; }
    
      [JsonProperty("items")]
      public List<SimplePage> items { get; set; }
      #endregion
    }
    #endregion
    
    #region SimplePageWhere
    public class SimplePageWhere {
      #region members
      public string ensureAtLEastOneField { get; set; }
    
      public string titleEq { get; set; }
    
      public string subtitleEq { get; set; }
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
    
    #region Sys
    public class Sys {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("codename")]
      public string codename { get; set; }
    
      [JsonProperty("language")]
      public Language language { get; set; }
    
      [JsonProperty("type")]
      public ContentType type { get; set; }
    
      [JsonProperty("lastModified")]
      public DateTime lastModified { get; set; }
    
      [JsonProperty("collection")]
      public Collection collection { get; set; }
    
      [JsonProperty("workflowStep")]
      public WorkflowStep workflowStep { get; set; }
    
      [JsonProperty("id")]
      public Guid id { get; set; }
      #endregion
    }
    #endregion
    
    #region TaxonomyTerm
    public class TaxonomyTerm {
      #region members
      [JsonProperty("system")]
      public TaxonomyTermSys system { get; set; }
      #endregion
    }
    #endregion
    
    #region TaxonomyTermSys
    public class TaxonomyTermSys {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
    
    #region WorkflowStep
    public class WorkflowStep {
      #region members
      [JsonProperty("system")]
      public WorkflowStepSys system { get; set; }
      #endregion
    }
    #endregion
    
    #region WorkflowStepSys
    public class WorkflowStepSys {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("codename")]
      public string codename { get; set; }
      #endregion
    }
    #endregion
  }
  
}
