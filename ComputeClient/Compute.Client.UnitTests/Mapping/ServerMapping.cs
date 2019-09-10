using AutoMapper;
using DD.CBU.Compute.Api.Contracts.Network20;
using System;
using System.Collections.Generic;
using Compute.Client.UnitTests.Models;
using System.Linq;

namespace Compute.Client.UnitTests.Mapping
{
    public class ServerMapping : Profile
    {
        public ServerMapping()
        {
            CreateMap<ServerBaseType, Models.Server>()
                .ForMember(dest => dest.Network, opt => opt.MapFrom(src => src.networkInfo))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.Parse(src.id)));
            //CreateMap<ServerSummaryType, Server>()
            //    .ForMember(dest => dest.SnapshotServiceSummary, opt => opt.MapFrom(src => src.snapshotService));

            //CreateMap<ServerDetailType, Server>()
            //    .ForMember(dest => dest.SnapshotServiceDetail, opt => opt.MapFrom(src => src.snapshotService));

            CreateMap<NicType, Models.Nic>();
            CreateMap<ServerTypeNetworkInfo, Models.ServerNetwork>()
                .ForMember(
                    dest => dest.AdditionalNics,
                    opt =>
                        opt.MapFrom(
                            src => src.additionalNic == null ? new List<Nic>() : src.additionalNic.Select(nic => Mapper.Map<Nic>(nic))));

            CreateMap<ServerBaseTypeNetworkInfo, ServerNetwork>()
                .ForMember(
                    dest => dest.AdditionalNics,
                    opt =>
                        opt.MapFrom(
                            src => src.additionalNic == null ? new List<Nic>() : src.additionalNic.Select(nic => Mapper.Map<Nic>(nic))));

            CreateMap<ServerTypeNic, ServerNic>()
                .ForMember(dest => dest.NetworkId, opt => opt.MapFrom(src => Guid.Parse(src.networkId)));
            CreateMap<ServerBaseTypeNic, ServerNic>()
                .ForMember(dest => dest.NetworkId, opt => opt.MapFrom(src => Guid.Parse(src.networkId)));
        }
    }
}