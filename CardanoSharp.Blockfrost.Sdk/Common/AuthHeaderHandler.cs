using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CardanoSharp.Blockfrost.Sdk.Common;

public record AuthHeaderConfiguration(string ApiKey, string BaseUrl);

public class AuthHeaderHandler: DelegatingHandler
{
    private readonly AuthHeaderConfiguration _authHeaderConfiguration;

    public AuthHeaderHandler(AuthHeaderConfiguration authHeaderConfiguration)
    {
        _authHeaderConfiguration = authHeaderConfiguration;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("project_id", _authHeaderConfiguration.ApiKey);

        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }
}
