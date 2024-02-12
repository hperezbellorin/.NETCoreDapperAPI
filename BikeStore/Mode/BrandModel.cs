using System.ComponentModel.DataAnnotations;

namespace BikeStore.Mode
{
    public class CategoriesModel : BaseModel
    {
        [Display(Name = "Category Name")]
        public string f_category_name { get; set; }
    }
}
