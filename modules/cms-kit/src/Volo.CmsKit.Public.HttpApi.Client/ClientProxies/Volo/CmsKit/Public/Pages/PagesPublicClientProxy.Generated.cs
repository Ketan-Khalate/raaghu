// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.CmsKit.Contents;
using Volo.CmsKit.Public.Pages;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Public.Pages;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IPagePublicAppService), typeof(PagesPublicClientProxy))]
public partial class PagesPublicClientProxy : ClientProxyBase<IPagePublicAppService>, IPagePublicAppService
{
    public virtual async Task<PageDto> FindBySlugAsync(string slug)
    {
        return await RequestAsync<PageDto>(nameof(FindBySlugAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), slug }
        });
    }

    public virtual async Task<PageDto> FindDefaultHomePageAsync()
    {
        return await RequestAsync<PageDto>(nameof(FindDefaultHomePageAsync));
    }
}
