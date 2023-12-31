using AutoMapper;
using LibraryMS.Application.ViewModels;
using LibraryMS.Core.Entities;

namespace LibraryMS.Application.Helpers
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<AuthViewModel, ApplicationUser>().ReverseMap()
				.ForMember(vm => vm.Username, o => o.MapFrom(usr => usr.UserName))
				.ForMember(vm => vm.Name, o => o.MapFrom(usr => usr.Name));

			CreateMap<BookCategoryViewModel, BookCategory>().ReverseMap();
		}
	}
}
