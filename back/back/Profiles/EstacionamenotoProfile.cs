using AutoMapper;
using back.Data.DTOs.Endereço;
using back.Models;

namespace back.Profiles
{
    public class EstacionamentoProfile: Profile
    {
        public EstacionamentoProfile()
        {
            CreateMap<CreateEstacionamentoDTO, Estacionamento>();
            CreateMap<ReadEstacionamentoDTO, Estacionamento>();
            CreateMap<UpdateEstacionamentoDTO, Estacionamento>();
        }
    }
}
