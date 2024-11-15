/*
 * IamBackoffice Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = iambackoffice.Client.OpenAPIDateConverter;

namespace iambackoffice.Model
{
    /// <summary>
    /// IambackofficeUser
    /// </summary>
    [DataContract(Name = "iambackofficeUser")]
    public partial class IambackofficeUser : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IambackofficeUser" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="data">data.</param>
        /// <param name="email">email.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="id">id.</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="insertInstant">insertInstant.</param>
        /// <param name="lastLoginInstant">lastLoginInstant.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="lastUpdateInstant">lastUpdateInstant.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="mobilePhone">mobilePhone.</param>
        /// <param name="password">password.</param>
        /// <param name="passwordChangeRequired">passwordChangeRequired.</param>
        /// <param name="passwordLastUpdateInstant">passwordLastUpdateInstant.</param>
        /// <param name="preferredLanguages">preferredLanguages.</param>
        /// <param name="registrations">registrations.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="twoFactor">twoFactor.</param>
        /// <param name="username">username.</param>
        /// <param name="verified">verified.</param>
        public IambackofficeUser(bool active = default(bool), string birthDate = default(string), Dictionary<string, string> data = default(Dictionary<string, string>), string email = default(string), string firstName = default(string), string fullName = default(string), string id = default(string), string imageUrl = default(string), string insertInstant = default(string), string lastLoginInstant = default(string), string lastName = default(string), string lastUpdateInstant = default(string), string middleName = default(string), string mobilePhone = default(string), string password = default(string), bool passwordChangeRequired = default(bool), string passwordLastUpdateInstant = default(string), List<string> preferredLanguages = default(List<string>), List<IambackofficeUserRegistration> registrations = default(List<IambackofficeUserRegistration>), string timezone = default(string), IambackofficeUserTwoFactorConfiguration twoFactor = default(IambackofficeUserTwoFactorConfiguration), string username = default(string), bool verified = default(bool))
        {
            this.Active = active;
            this.BirthDate = birthDate;
            this.Data = data;
            this.Email = email;
            this.FirstName = firstName;
            this.FullName = fullName;
            this.Id = id;
            this.ImageUrl = imageUrl;
            this.InsertInstant = insertInstant;
            this.LastLoginInstant = lastLoginInstant;
            this.LastName = lastName;
            this.LastUpdateInstant = lastUpdateInstant;
            this.MiddleName = middleName;
            this.MobilePhone = mobilePhone;
            this.Password = password;
            this.PasswordChangeRequired = passwordChangeRequired;
            this.PasswordLastUpdateInstant = passwordLastUpdateInstant;
            this.PreferredLanguages = preferredLanguages;
            this.Registrations = registrations;
            this.Timezone = timezone;
            this.TwoFactor = twoFactor;
            this.Username = username;
            this.Verified = verified;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        public string BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets InsertInstant
        /// </summary>
        [DataMember(Name = "insertInstant", EmitDefaultValue = false)]
        public string InsertInstant { get; set; }

        /// <summary>
        /// Gets or Sets LastLoginInstant
        /// </summary>
        [DataMember(Name = "lastLoginInstant", EmitDefaultValue = false)]
        public string LastLoginInstant { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdateInstant
        /// </summary>
        [DataMember(Name = "lastUpdateInstant", EmitDefaultValue = false)]
        public string LastUpdateInstant { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middleName", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhone
        /// </summary>
        [DataMember(Name = "mobilePhone", EmitDefaultValue = false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets PasswordChangeRequired
        /// </summary>
        [DataMember(Name = "passwordChangeRequired", EmitDefaultValue = true)]
        public bool PasswordChangeRequired { get; set; }

        /// <summary>
        /// Gets or Sets PasswordLastUpdateInstant
        /// </summary>
        [DataMember(Name = "passwordLastUpdateInstant", EmitDefaultValue = false)]
        public string PasswordLastUpdateInstant { get; set; }

        /// <summary>
        /// Gets or Sets PreferredLanguages
        /// </summary>
        [DataMember(Name = "preferredLanguages", EmitDefaultValue = false)]
        public List<string> PreferredLanguages { get; set; }

        /// <summary>
        /// Gets or Sets Registrations
        /// </summary>
        [DataMember(Name = "registrations", EmitDefaultValue = false)]
        public List<IambackofficeUserRegistration> Registrations { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets TwoFactor
        /// </summary>
        [DataMember(Name = "twoFactor", EmitDefaultValue = false)]
        public IambackofficeUserTwoFactorConfiguration TwoFactor { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IambackofficeUser {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  InsertInstant: ").Append(InsertInstant).Append("\n");
            sb.Append("  LastLoginInstant: ").Append(LastLoginInstant).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LastUpdateInstant: ").Append(LastUpdateInstant).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordChangeRequired: ").Append(PasswordChangeRequired).Append("\n");
            sb.Append("  PasswordLastUpdateInstant: ").Append(PasswordLastUpdateInstant).Append("\n");
            sb.Append("  PreferredLanguages: ").Append(PreferredLanguages).Append("\n");
            sb.Append("  Registrations: ").Append(Registrations).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  TwoFactor: ").Append(TwoFactor).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
