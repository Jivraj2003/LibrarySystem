using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibrarySystem.Dtos
{
    public class FormFields
    {
        public List<SelectListItem> BookList { get; set; }
        public string TextValue { get; set; }
        public string BookId { get; set; }
        public string Gender { get; set; }
        public List<Hobbies> Hobbies { get; set; }
    }

    public class Hobbies
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; } = false;
    }
}