﻿using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdSvrHost
{
    public class Config
    {
        public static IEnumerable<Client> GetClients()
        {
            return new Client[] {
                new Client
                {
                    ClientId = "mvc",
                    ClientName="MVC Demo",
                    AllowedGrantTypes= GrantTypes.Implicit,
                    RedirectUris = { "http://localhost:56139/signin-oidc" },
                    AllowedScopes = { "openid","email", "profile", "office" }
                }
            };
        }
        public static IEnumerable<IdentityResource> GetIdentityResource()
        {
            return new IdentityResource[] {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
                new IdentityResource
                {
                    Name="office",
                    DisplayName="Your Office Info",
                    UserClaims = {"office_number"}
                }
            };
        }
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new ApiResource[] {

            };
        }
    }
}
