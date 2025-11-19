// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

global using System.Security.Claims;
global using AutoMapper;
global using AutoMapper.QueryableExtensions;
global using Arohan.TollSphere.Application.Common.Interfaces;
global using Arohan.TollSphere.Application.Common.Interfaces.Identity;
global using Arohan.TollSphere.Application.Common.Models;
global using Arohan.TollSphere.Infrastructure.Persistence;
global using Arohan.TollSphere.Infrastructure.Persistence.Extensions;
global using Arohan.TollSphere.Infrastructure.Services;
global using Arohan.TollSphere.Infrastructure.Services.Identity;
global using Arohan.TollSphere.Domain.Entities;
global using Microsoft.AspNetCore.Components.Authorization;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
