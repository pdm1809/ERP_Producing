using AutoMapper;
using SampleProject.Data.Models;
using SampleProject.Shared.Requests.AAColumnAliases;
using SampleProject.Shared.Responses.AAColumnAliases;

namespace SampleProject.Data.Profiles
{
    public class AAColumnAliasProfile : Profile
    {
        public AAColumnAliasProfile()
        {
            CreateMap<AacolumnAlias, AAColumnAliasResponse>();
            CreateMap<AAColumnAliasRequest, AacolumnAlias>();
            CreateMap<UpdateAAColumnAliasRequest, AacolumnAlias>();
        }
    }
}
