using AutoMapper;
using back.Data.DTOs.Endereço;
using back.Models;

namespace back.Profiles
{
    public class VeiculoProfile:Profile
    {
        public VeiculoProfile()
        {
            CreateMap<CreateVeiculoDTO,Veiculo>();
            CreateMap<ReadVeiculoDTO,Veiculo>();
            CreateMap<UpdateVeiculoDTO,Veiculo>();
        }

    }
}
