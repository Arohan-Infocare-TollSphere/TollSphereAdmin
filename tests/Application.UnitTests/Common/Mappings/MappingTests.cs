using System;
using System.Reflection;
using System.Runtime.Serialization;
using AutoMapper;
using Arohan.TollSphere.Application.Common.Interfaces;
using Arohan.TollSphere.Application.Features.AuditTrails.DTOs;
using Arohan.TollSphere.Application.Features.Contacts.DTOs;
using Arohan.TollSphere.Application.Features.Documents.DTOs;
using Arohan.TollSphere.Application.Features.Identity.DTOs;
using Arohan.TollSphere.Application.Features.PicklistSets.DTOs;
using Arohan.TollSphere.Application.Features.Products.DTOs;
using Arohan.TollSphere.Application.Features.SystemLogs.DTOs;
using Arohan.TollSphere.Application.Features.Tenants.DTOs;
using Arohan.TollSphere.Domain.Entities;
using Arohan.TollSphere.Domain.Identity;
using NUnit.Framework;

namespace Arohan.TollSphere.Application.UnitTests.Common.Mappings;
public class MappingTests
{
    private readonly IConfigurationProvider _configuration;
    private readonly IMapper _mapper;

    public MappingTests()
    {
        _configuration = new MapperConfiguration(cfg => cfg.AddMaps(Assembly.GetAssembly(typeof(IApplicationDbContext))));
        _mapper = _configuration.CreateMapper();
    }

    [Test]
    public void ShouldHaveValidConfiguration()
    {
        _configuration.AssertConfigurationIsValid();
    }

    [Test]
    [TestCase(typeof(Document), typeof(DocumentDto), true)]
    [TestCase(typeof(Tenant), typeof(TenantDto), true)]
    [TestCase(typeof(Product), typeof(ProductDto), true)]
    [TestCase(typeof(Contact), typeof(ContactDto), true)]
    [TestCase(typeof(PicklistSet), typeof(PicklistSetDto), true)]
    [TestCase(typeof(ApplicationUser), typeof(ApplicationUserDto), false)]
    [TestCase(typeof(ApplicationRole), typeof(ApplicationRoleDto), false)]
    [TestCase(typeof(SystemLog), typeof(SystemLogDto), false)]
    [TestCase(typeof(AuditTrail), typeof(AuditTrailDto), false)]
    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination, bool inverseMap = false)
    {
        var instance = GetInstanceOf(source);

        _mapper.Map(instance, source, destination);

        if (inverseMap)
        {
            ShouldSupportMappingFromSourceToDestination(destination, source, false);
        }
    }

    private object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
            return Activator.CreateInstance(type);

        throw new InvalidOperationException($"Type {type.FullName} does not have a parameterless constructor.");
    }
}
