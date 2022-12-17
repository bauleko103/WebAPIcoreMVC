using AutoMapper;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Helpers
{
    public class ApplicationMapper: Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Book, BookModel>().ReverseMap();

        }
    }
}
