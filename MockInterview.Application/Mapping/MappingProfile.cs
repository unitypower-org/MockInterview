using AutoMapper;
using MockInterview.Domain.Entities.Client;
using MockInterview.Domain.Entities.Interlocutor;
using MockInterview.Domain.Entities.Interviewer;
using MockInterview.Domain.Models.Client;
using MockInterview.Domain.Models.Interlocutor;
using MockInterview.Domain.Models.Interviewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Typelarni bir biriga convert qilishda qiynalmaslik uchun
            CreateMap<string, int>().ConvertUsing<IntTypeConverter>();
            CreateMap<string, int?>().ConvertUsing<NullIntTypeConverter>();

            // buyerda DTO dan kelgan malumotlarni asosiy modelga qo'shib beradi
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Interviewer, InterviewerDTO>().ReverseMap();
            CreateMap<Interlocutor, InterlocutorDTO>().ReverseMap();
            CreateMap<Booked, BookedDTO>().ReverseMap();
            CreateMap<SelectedInterlocutorInterviewCategories, SelectedInterlocutorInterviewCategoriesDTO>().ReverseMap();
            CreateMap<InterviewerProjects, InterviewerProjectsDTO>().ReverseMap();
            
        }
        /// <summary>
        /// Type Convertor zo'r narsa
        /// </summary>
        #region AutoMapTypeConverters
        private class NullIntTypeConverter : ITypeConverter<string, int?>
        {
            public int? Convert(string source, int? destination, ResolutionContext context)
            {
                if (source == null)
                    return null;
                else
                {
                    int result;
                    return Int32.TryParse(source, out result) ? (int?)result : null;
                }
            }
        }
        // Automapper string to int
        private class IntTypeConverter : ITypeConverter<string, int>
        {
            public int Convert(string source, int destination, ResolutionContext context)
            {
                if (string.IsNullOrEmpty(source))
                    return 0;
                else
                    return Int32.Parse(source);
            }
        }
        #endregion
    }
}
