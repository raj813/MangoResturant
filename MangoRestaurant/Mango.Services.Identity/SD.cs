using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace Mango.Services.Identity
{
    public static class SD
    {
        public const String Admin = "Admin";
        public const String Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("mango","Mango server"),
                new ApiScope(name:"read",displayName:"Read your Data."),
                new ApiScope(name:"write",displayName:"Write your Data."),
                new ApiScope(name:"delete",displayName:"Delete your Data.")
            };
        public static IEnumerable<Client> Clients =>
             new List<Client>
             {
                new Client  // Not using this client in this context just for learing . 

                {
                    ClientId ="client",
                    ClientSecrets = { new Secret("secret".Sha256())},
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    AllowedScopes = {"read","write","profile" }  // Profile is build in scope
                },
                 new Client
                {
                    ClientId ="mango",
                    ClientSecrets = { new Secret("secret".Sha256())},
                    AllowedGrantTypes= GrantTypes.Code,
                    RedirectUris={ "http://localhost:44386/signin-oidc" },
                    PostLogoutRedirectUris={ "http://localhost:44386/signout-callback-oidc" },
                    AllowedScopes =new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "mango"

                    }

                },
             };


    }
}
