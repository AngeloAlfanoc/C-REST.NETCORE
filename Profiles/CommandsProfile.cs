using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles {
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Sourcce -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
        }

    }
}