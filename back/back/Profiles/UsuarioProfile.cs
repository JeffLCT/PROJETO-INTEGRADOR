using AutoMapper;
using back.Data.DTOs.Endereço;
using back.Models;

namespace back.Profiles
{
{
    public class UsuarioProfile:Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateusuarioDTO, Usuario>();
            CreateMap<ReadusuarioDTO, Usuario>();
            CreateMap<UpdateusuarioDTO, Usuario>();

        }
    }
}
