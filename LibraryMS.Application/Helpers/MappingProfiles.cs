using AutoMapper;
using LibraryMS.Application.ViewModels;
using LibraryMS.Core.Entities;

namespace LibraryMS.Application.Helpers
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			#region Authorization ViewModel
			CreateMap<AuthViewModel, ApplicationUser>().ReverseMap()
		.ForMember(vm => vm.Username, o => o.MapFrom(usr => usr.UserName))
		.ForMember(vm => vm.Name, o => o.MapFrom(usr => usr.Name));
			#endregion

			#region BookCategory ViewModel
			CreateMap<BookCategoryViewModel, BookCategory>().ReverseMap();
			#endregion

			#region Book ViewModel
			CreateMap<BookViewModel, Book>().ReverseMap()
				.ForMember(b => b.Category, o => o.MapFrom(b => b.Category.Name));
			#endregion
		}
	}
}
