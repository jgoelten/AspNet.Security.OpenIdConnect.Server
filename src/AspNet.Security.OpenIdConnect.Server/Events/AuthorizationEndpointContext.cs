/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenIdConnect.Server
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace AspNet.Security.OpenIdConnect.Server {
    /// <summary>
    /// An event raised after the Authorization Server has processed the request, but before it is passed on to the web application.
    /// Calling RequestCompleted will prevent the request from passing on to the web application.
    /// </summary>
    public class AuthorizationEndpointContext : BaseControlContext {
        /// <summary>
        /// Creates an instance of this context
        /// </summary>
        public AuthorizationEndpointContext(
            HttpContext context,
            OpenIdConnectServerOptions options,
            OpenIdConnectMessage request)
            : base(context) {
            Options = options;
            Request = request;
        }

        /// <summary>
        /// Gets the options used by the OpenID Connect server.
        /// </summary>
        public OpenIdConnectServerOptions Options { get; }

        /// <summary>
        /// Gets the authorization request.
        /// </summary>
        public new OpenIdConnectMessage Request { get; }
    }
}
