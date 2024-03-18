using AutoMapper;
using back.Data.DTOs.Endereco;
using back.Models;

namespace back.Profiles
{
    public class EnderecoProfile:Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDTO, Endereco>();
            CreateMap<ReadEnderecoDTO, Endereco>();
            CreateMap<UpdateEnderecoDTO, Endereco>();
        }

    }
}
