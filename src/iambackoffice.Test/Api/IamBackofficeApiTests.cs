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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using iambackoffice.Client;
using iambackoffice.Api;
// uncomment below to import models
//using iambackoffice.Model;

namespace iambackoffice.Test.Api
{
    /// <summary>
    ///  Class for testing IamBackofficeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IamBackofficeApiTests : IDisposable
    {
        private IamBackofficeApi instance;

        public IamBackofficeApiTests()
        {
            instance = new IamBackofficeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IamBackofficeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IamBackofficeApi
            //Assert.IsType<IamBackofficeApi>(instance);
        }

        /// <summary>
        /// Test IamBackofficeAssignRoles
        /// </summary>
        [Fact]
        public void IamBackofficeAssignRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeAssignRolesRequest body = null;
            //var response = instance.IamBackofficeAssignRoles(body);
            //Assert.IsType<IambackofficeAssignRolesResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeAssignUserToGroup
        /// </summary>
        [Fact]
        public void IamBackofficeAssignUserToGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeAssignUserToGroupRequest body = null;
            //var response = instance.IamBackofficeAssignUserToGroup(body);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test IamBackofficeCreateGroup
        /// </summary>
        [Fact]
        public void IamBackofficeCreateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeCreateGroupRequest body = null;
            //var response = instance.IamBackofficeCreateGroup(body);
            //Assert.IsType<IambackofficeCreateGroupResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeDisableUserMfa
        /// </summary>
        [Fact]
        public void IamBackofficeDisableUserMfaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeDisableUserMfaRequest body = null;
            //var response = instance.IamBackofficeDisableUserMfa(body);
            //Assert.IsType<IambackofficeUserMfaResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeEnableUserMfa
        /// </summary>
        [Fact]
        public void IamBackofficeEnableUserMfaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeEnableUserMfaRequest body = null;
            //var response = instance.IamBackofficeEnableUserMfa(body);
            //Assert.IsType<IambackofficeUserMfaResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeGenerateSecretForQR
        /// </summary>
        [Fact]
        public void IamBackofficeGenerateSecretForQRTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object body = null;
            //var response = instance.IamBackofficeGenerateSecretForQR(body);
            //Assert.IsType<IambackofficeGenerateSecretForQRResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeGetUser
        /// </summary>
        [Fact]
        public void IamBackofficeGetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeGetUserRequest body = null;
            //var response = instance.IamBackofficeGetUser(body);
            //Assert.IsType<IambackofficeGetUserResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeLogin
        /// </summary>
        [Fact]
        public void IamBackofficeLoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeLoginRequest body = null;
            //var response = instance.IamBackofficeLogin(body);
            //Assert.IsType<IambackofficeLoginResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeLoginMfa
        /// </summary>
        [Fact]
        public void IamBackofficeLoginMfaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeLoginMfaRequest body = null;
            //var response = instance.IamBackofficeLoginMfa(body);
            //Assert.IsType<IambackofficeLoginResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeLogout
        /// </summary>
        [Fact]
        public void IamBackofficeLogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeLogoutRequest body = null;
            //var response = instance.IamBackofficeLogout(body);
            //Assert.IsType<IambackofficeLogoutResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeRegister
        /// </summary>
        [Fact]
        public void IamBackofficeRegisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeRegistrationRequest body = null;
            //var response = instance.IamBackofficeRegister(body);
            //Assert.IsType<IambackofficeRegistrationResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeSearchGroups
        /// </summary>
        [Fact]
        public void IamBackofficeSearchGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeSearchGroupsRequest body = null;
            //var response = instance.IamBackofficeSearchGroups(body);
            //Assert.IsType<IambackofficeSearchGroupsResponse>(response);
        }

        /// <summary>
        /// Test IamBackofficeUnassignRoles
        /// </summary>
        [Fact]
        public void IamBackofficeUnassignRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IambackofficeUnassignRolesRequest body = null;
            //var response = instance.IamBackofficeUnassignRoles(body);
            //Assert.IsType<IambackofficeUnassignRolesResponse>(response);
        }
    }
}
