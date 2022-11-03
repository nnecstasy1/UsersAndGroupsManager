namespace API
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<ClientGroupUserFB, ClientGroupUserEntity>()
                .ForMember(dest => dest.Id, from => from.MapFrom(source => source.Id))
                .ForMember(dest => dest.UserId, from => from.MapFrom(source => source.UserId))
                .ForMember(dest => dest.ClientGroupId, from => from.MapFrom(source => source.ClientGroupId));

        }
    }
}
