# iambackoffice - the C# library for the IamBackoffice Service

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out iambackoffice.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeAssignRolesRequest(); // IambackofficeAssignRolesRequest | 

            try
            {
                // AUTHZ
                IambackofficeAssignRolesResponse result = apiInstance.IamBackofficeAssignRoles(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeAssignRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://iambackoffice.api.gogemini.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*IamBackofficeApi* | [**IamBackofficeAssignRoles**](docs/IamBackofficeApi.md#iambackofficeassignroles) | **POST** /iambackoffice.IamBackoffice/AssignRoles | AUTHZ
*IamBackofficeApi* | [**IamBackofficeAssignUserToGroup**](docs/IamBackofficeApi.md#iambackofficeassignusertogroup) | **POST** /iambackoffice.IamBackoffice/AssignUserToGroup | 
*IamBackofficeApi* | [**IamBackofficeCreateGroup**](docs/IamBackofficeApi.md#iambackofficecreategroup) | **POST** /iambackoffice.IamBackoffice/CreateGroup | GROUPS
*IamBackofficeApi* | [**IamBackofficeDisableUserMfa**](docs/IamBackofficeApi.md#iambackofficedisableusermfa) | **POST** /iambackoffice.IamBackoffice/DisableUserMfa | 
*IamBackofficeApi* | [**IamBackofficeEnableUserMfa**](docs/IamBackofficeApi.md#iambackofficeenableusermfa) | **POST** /iambackoffice.IamBackoffice/EnableUserMfa | 
*IamBackofficeApi* | [**IamBackofficeGenerateSecretForQR**](docs/IamBackofficeApi.md#iambackofficegeneratesecretforqr) | **POST** /iambackoffice.IamBackoffice/GenerateSecretForQR | MFA
*IamBackofficeApi* | [**IamBackofficeGetUser**](docs/IamBackofficeApi.md#iambackofficegetuser) | **POST** /iambackoffice.IamBackoffice/GetUser | USER
*IamBackofficeApi* | [**IamBackofficeLogin**](docs/IamBackofficeApi.md#iambackofficelogin) | **POST** /iambackoffice.IamBackoffice/Login | LOGIN
*IamBackofficeApi* | [**IamBackofficeLoginMfa**](docs/IamBackofficeApi.md#iambackofficeloginmfa) | **POST** /iambackoffice.IamBackoffice/LoginMfa | LOGIN MFA
*IamBackofficeApi* | [**IamBackofficeLogout**](docs/IamBackofficeApi.md#iambackofficelogout) | **POST** /iambackoffice.IamBackoffice/Logout | 
*IamBackofficeApi* | [**IamBackofficeRegister**](docs/IamBackofficeApi.md#iambackofficeregister) | **POST** /iambackoffice.IamBackoffice/Register | REGISTRATION
*IamBackofficeApi* | [**IamBackofficeSearchGroups**](docs/IamBackofficeApi.md#iambackofficesearchgroups) | **POST** /iambackoffice.IamBackoffice/SearchGroups | 
*IamBackofficeApi* | [**IamBackofficeUnassignRoles**](docs/IamBackofficeApi.md#iambackofficeunassignroles) | **POST** /iambackoffice.IamBackoffice/UnassignRoles | 


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.IambackofficeAssignRolesRequest](docs/IambackofficeAssignRolesRequest.md)
 - [Model.IambackofficeAssignRolesResponse](docs/IambackofficeAssignRolesResponse.md)
 - [Model.IambackofficeAssignUserToGroupRequest](docs/IambackofficeAssignUserToGroupRequest.md)
 - [Model.IambackofficeAuthenticatorConfiguration](docs/IambackofficeAuthenticatorConfiguration.md)
 - [Model.IambackofficeCreateGroupRequest](docs/IambackofficeCreateGroupRequest.md)
 - [Model.IambackofficeCreateGroupResponse](docs/IambackofficeCreateGroupResponse.md)
 - [Model.IambackofficeDevice](docs/IambackofficeDevice.md)
 - [Model.IambackofficeDisableUserMfaRequest](docs/IambackofficeDisableUserMfaRequest.md)
 - [Model.IambackofficeEnableUserMfaRequest](docs/IambackofficeEnableUserMfaRequest.md)
 - [Model.IambackofficeGenerateSecretForQRResponse](docs/IambackofficeGenerateSecretForQRResponse.md)
 - [Model.IambackofficeGetUserRequest](docs/IambackofficeGetUserRequest.md)
 - [Model.IambackofficeGetUserResponse](docs/IambackofficeGetUserResponse.md)
 - [Model.IambackofficeGroup](docs/IambackofficeGroup.md)
 - [Model.IambackofficeLoginMfaRequest](docs/IambackofficeLoginMfaRequest.md)
 - [Model.IambackofficeLoginRequest](docs/IambackofficeLoginRequest.md)
 - [Model.IambackofficeLoginResponse](docs/IambackofficeLoginResponse.md)
 - [Model.IambackofficeLogoutRequest](docs/IambackofficeLogoutRequest.md)
 - [Model.IambackofficeLogoutResponse](docs/IambackofficeLogoutResponse.md)
 - [Model.IambackofficeMetaData](docs/IambackofficeMetaData.md)
 - [Model.IambackofficeRegistrationRequest](docs/IambackofficeRegistrationRequest.md)
 - [Model.IambackofficeRegistrationResponse](docs/IambackofficeRegistrationResponse.md)
 - [Model.IambackofficeSearchGroupsRequest](docs/IambackofficeSearchGroupsRequest.md)
 - [Model.IambackofficeSearchGroupsResponse](docs/IambackofficeSearchGroupsResponse.md)
 - [Model.IambackofficeTwoFactorMethod](docs/IambackofficeTwoFactorMethod.md)
 - [Model.IambackofficeUnassignRolesRequest](docs/IambackofficeUnassignRolesRequest.md)
 - [Model.IambackofficeUnassignRolesResponse](docs/IambackofficeUnassignRolesResponse.md)
 - [Model.IambackofficeUser](docs/IambackofficeUser.md)
 - [Model.IambackofficeUserMfaResponse](docs/IambackofficeUserMfaResponse.md)
 - [Model.IambackofficeUserRegistration](docs/IambackofficeUserRegistration.md)
 - [Model.IambackofficeUserTwoFactorConfiguration](docs/IambackofficeUserTwoFactorConfiguration.md)
 - [Model.ProtobufAny](docs/ProtobufAny.md)
 - [Model.RpcStatus](docs/RpcStatus.md)
 - [Model.SearchGroupsRequestFilters](docs/SearchGroupsRequestFilters.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="standardAuthorization"></a>
### standardAuthorization

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: 
- **Scopes**: N/A

