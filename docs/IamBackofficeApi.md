# iambackoffice.Api.IamBackofficeApi

All URIs are relative to *https://iambackoffice.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IamBackofficeAssignRoles**](IamBackofficeApi.md#iambackofficeassignroles) | **POST** /iambackoffice.IamBackoffice/AssignRoles | AUTHZ |
| [**IamBackofficeAssignUserToGroup**](IamBackofficeApi.md#iambackofficeassignusertogroup) | **POST** /iambackoffice.IamBackoffice/AssignUserToGroup |  |
| [**IamBackofficeCreateGroup**](IamBackofficeApi.md#iambackofficecreategroup) | **POST** /iambackoffice.IamBackoffice/CreateGroup | GROUPS |
| [**IamBackofficeDisableUserMfa**](IamBackofficeApi.md#iambackofficedisableusermfa) | **POST** /iambackoffice.IamBackoffice/DisableUserMfa |  |
| [**IamBackofficeEnableUserMfa**](IamBackofficeApi.md#iambackofficeenableusermfa) | **POST** /iambackoffice.IamBackoffice/EnableUserMfa |  |
| [**IamBackofficeGenerateSecretForQR**](IamBackofficeApi.md#iambackofficegeneratesecretforqr) | **POST** /iambackoffice.IamBackoffice/GenerateSecretForQR | MFA |
| [**IamBackofficeGetUser**](IamBackofficeApi.md#iambackofficegetuser) | **POST** /iambackoffice.IamBackoffice/GetUser | USER |
| [**IamBackofficeLogin**](IamBackofficeApi.md#iambackofficelogin) | **POST** /iambackoffice.IamBackoffice/Login | LOGIN |
| [**IamBackofficeLoginMfa**](IamBackofficeApi.md#iambackofficeloginmfa) | **POST** /iambackoffice.IamBackoffice/LoginMfa | LOGIN MFA |
| [**IamBackofficeLogout**](IamBackofficeApi.md#iambackofficelogout) | **POST** /iambackoffice.IamBackoffice/Logout |  |
| [**IamBackofficeRegister**](IamBackofficeApi.md#iambackofficeregister) | **POST** /iambackoffice.IamBackoffice/Register | REGISTRATION |
| [**IamBackofficeSearchGroups**](IamBackofficeApi.md#iambackofficesearchgroups) | **POST** /iambackoffice.IamBackoffice/SearchGroups |  |
| [**IamBackofficeUnassignRoles**](IamBackofficeApi.md#iambackofficeunassignroles) | **POST** /iambackoffice.IamBackoffice/UnassignRoles |  |

<a id="iambackofficeassignroles"></a>
# **IamBackofficeAssignRoles**
> IambackofficeAssignRolesResponse IamBackofficeAssignRoles (IambackofficeAssignRolesRequest body)

AUTHZ

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeAssignRolesExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeAssignRoles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeAssignRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // AUTHZ
    ApiResponse<IambackofficeAssignRolesResponse> response = apiInstance.IamBackofficeAssignRolesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeAssignRolesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeAssignRolesRequest**](IambackofficeAssignRolesRequest.md) |  |  |

### Return type

[**IambackofficeAssignRolesResponse**](IambackofficeAssignRolesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficeassignusertogroup"></a>
# **IamBackofficeAssignUserToGroup**
> Object IamBackofficeAssignUserToGroup (IambackofficeAssignUserToGroupRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeAssignUserToGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeAssignUserToGroupRequest(); // IambackofficeAssignUserToGroupRequest | 

            try
            {
                Object result = apiInstance.IamBackofficeAssignUserToGroup(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeAssignUserToGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeAssignUserToGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.IamBackofficeAssignUserToGroupWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeAssignUserToGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeAssignUserToGroupRequest**](IambackofficeAssignUserToGroupRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficecreategroup"></a>
# **IamBackofficeCreateGroup**
> IambackofficeCreateGroupResponse IamBackofficeCreateGroup (IambackofficeCreateGroupRequest body)

GROUPS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeCreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeCreateGroupRequest(); // IambackofficeCreateGroupRequest | 

            try
            {
                // GROUPS
                IambackofficeCreateGroupResponse result = apiInstance.IamBackofficeCreateGroup(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeCreateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeCreateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GROUPS
    ApiResponse<IambackofficeCreateGroupResponse> response = apiInstance.IamBackofficeCreateGroupWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeCreateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeCreateGroupRequest**](IambackofficeCreateGroupRequest.md) |  |  |

### Return type

[**IambackofficeCreateGroupResponse**](IambackofficeCreateGroupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficedisableusermfa"></a>
# **IamBackofficeDisableUserMfa**
> IambackofficeUserMfaResponse IamBackofficeDisableUserMfa (IambackofficeDisableUserMfaRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeDisableUserMfaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeDisableUserMfaRequest(); // IambackofficeDisableUserMfaRequest | 

            try
            {
                IambackofficeUserMfaResponse result = apiInstance.IamBackofficeDisableUserMfa(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeDisableUserMfa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeDisableUserMfaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IambackofficeUserMfaResponse> response = apiInstance.IamBackofficeDisableUserMfaWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeDisableUserMfaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeDisableUserMfaRequest**](IambackofficeDisableUserMfaRequest.md) |  |  |

### Return type

[**IambackofficeUserMfaResponse**](IambackofficeUserMfaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficeenableusermfa"></a>
# **IamBackofficeEnableUserMfa**
> IambackofficeUserMfaResponse IamBackofficeEnableUserMfa (IambackofficeEnableUserMfaRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeEnableUserMfaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeEnableUserMfaRequest(); // IambackofficeEnableUserMfaRequest | 

            try
            {
                IambackofficeUserMfaResponse result = apiInstance.IamBackofficeEnableUserMfa(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeEnableUserMfa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeEnableUserMfaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IambackofficeUserMfaResponse> response = apiInstance.IamBackofficeEnableUserMfaWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeEnableUserMfaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeEnableUserMfaRequest**](IambackofficeEnableUserMfaRequest.md) |  |  |

### Return type

[**IambackofficeUserMfaResponse**](IambackofficeUserMfaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficegeneratesecretforqr"></a>
# **IamBackofficeGenerateSecretForQR**
> IambackofficeGenerateSecretForQRResponse IamBackofficeGenerateSecretForQR (Object body)

MFA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeGenerateSecretForQRExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = null;  // Object | 

            try
            {
                // MFA
                IambackofficeGenerateSecretForQRResponse result = apiInstance.IamBackofficeGenerateSecretForQR(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeGenerateSecretForQR: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeGenerateSecretForQRWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // MFA
    ApiResponse<IambackofficeGenerateSecretForQRResponse> response = apiInstance.IamBackofficeGenerateSecretForQRWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeGenerateSecretForQRWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

[**IambackofficeGenerateSecretForQRResponse**](IambackofficeGenerateSecretForQRResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficegetuser"></a>
# **IamBackofficeGetUser**
> IambackofficeGetUserResponse IamBackofficeGetUser (IambackofficeGetUserRequest body)

USER

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeGetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeGetUserRequest(); // IambackofficeGetUserRequest | 

            try
            {
                // USER
                IambackofficeGetUserResponse result = apiInstance.IamBackofficeGetUser(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeGetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeGetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // USER
    ApiResponse<IambackofficeGetUserResponse> response = apiInstance.IamBackofficeGetUserWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeGetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeGetUserRequest**](IambackofficeGetUserRequest.md) |  |  |

### Return type

[**IambackofficeGetUserResponse**](IambackofficeGetUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficelogin"></a>
# **IamBackofficeLogin**
> IambackofficeLoginResponse IamBackofficeLogin (IambackofficeLoginRequest body)

LOGIN

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeLoginRequest(); // IambackofficeLoginRequest | 

            try
            {
                // LOGIN
                IambackofficeLoginResponse result = apiInstance.IamBackofficeLogin(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // LOGIN
    ApiResponse<IambackofficeLoginResponse> response = apiInstance.IamBackofficeLoginWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeLoginRequest**](IambackofficeLoginRequest.md) |  |  |

### Return type

[**IambackofficeLoginResponse**](IambackofficeLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficeloginmfa"></a>
# **IamBackofficeLoginMfa**
> IambackofficeLoginResponse IamBackofficeLoginMfa (IambackofficeLoginMfaRequest body)

LOGIN MFA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeLoginMfaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeLoginMfaRequest(); // IambackofficeLoginMfaRequest | 

            try
            {
                // LOGIN MFA
                IambackofficeLoginResponse result = apiInstance.IamBackofficeLoginMfa(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeLoginMfa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeLoginMfaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // LOGIN MFA
    ApiResponse<IambackofficeLoginResponse> response = apiInstance.IamBackofficeLoginMfaWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeLoginMfaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeLoginMfaRequest**](IambackofficeLoginMfaRequest.md) |  |  |

### Return type

[**IambackofficeLoginResponse**](IambackofficeLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficelogout"></a>
# **IamBackofficeLogout**
> IambackofficeLogoutResponse IamBackofficeLogout (IambackofficeLogoutRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeLogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeLogoutRequest(); // IambackofficeLogoutRequest | 

            try
            {
                IambackofficeLogoutResponse result = apiInstance.IamBackofficeLogout(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeLogout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeLogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IambackofficeLogoutResponse> response = apiInstance.IamBackofficeLogoutWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeLogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeLogoutRequest**](IambackofficeLogoutRequest.md) |  |  |

### Return type

[**IambackofficeLogoutResponse**](IambackofficeLogoutResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficeregister"></a>
# **IamBackofficeRegister**
> IambackofficeRegistrationResponse IamBackofficeRegister (IambackofficeRegistrationRequest body)

REGISTRATION

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeRegisterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeRegistrationRequest(); // IambackofficeRegistrationRequest | 

            try
            {
                // REGISTRATION
                IambackofficeRegistrationResponse result = apiInstance.IamBackofficeRegister(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeRegister: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeRegisterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // REGISTRATION
    ApiResponse<IambackofficeRegistrationResponse> response = apiInstance.IamBackofficeRegisterWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeRegisterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeRegistrationRequest**](IambackofficeRegistrationRequest.md) |  |  |

### Return type

[**IambackofficeRegistrationResponse**](IambackofficeRegistrationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficesearchgroups"></a>
# **IamBackofficeSearchGroups**
> IambackofficeSearchGroupsResponse IamBackofficeSearchGroups (IambackofficeSearchGroupsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeSearchGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeSearchGroupsRequest(); // IambackofficeSearchGroupsRequest | 

            try
            {
                IambackofficeSearchGroupsResponse result = apiInstance.IamBackofficeSearchGroups(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeSearchGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeSearchGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IambackofficeSearchGroupsResponse> response = apiInstance.IamBackofficeSearchGroupsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeSearchGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeSearchGroupsRequest**](IambackofficeSearchGroupsRequest.md) |  |  |

### Return type

[**IambackofficeSearchGroupsResponse**](IambackofficeSearchGroupsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="iambackofficeunassignroles"></a>
# **IamBackofficeUnassignRoles**
> IambackofficeUnassignRolesResponse IamBackofficeUnassignRoles (IambackofficeUnassignRolesRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using iambackoffice.Api;
using iambackoffice.Client;
using iambackoffice.Model;

namespace Example
{
    public class IamBackofficeUnassignRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://iambackoffice.api.gogemini.io";
            var apiInstance = new IamBackofficeApi(config);
            var body = new IambackofficeUnassignRolesRequest(); // IambackofficeUnassignRolesRequest | 

            try
            {
                IambackofficeUnassignRolesResponse result = apiInstance.IamBackofficeUnassignRoles(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeUnassignRoles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IamBackofficeUnassignRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IambackofficeUnassignRolesResponse> response = apiInstance.IamBackofficeUnassignRolesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IamBackofficeApi.IamBackofficeUnassignRolesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**IambackofficeUnassignRolesRequest**](IambackofficeUnassignRolesRequest.md) |  |  |

### Return type

[**IambackofficeUnassignRolesResponse**](IambackofficeUnassignRolesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

