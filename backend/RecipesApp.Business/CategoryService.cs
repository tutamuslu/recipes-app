using RecipesApp.Domain;

namespace RecipesApp.Business
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories()
        {
          List<Category> categories = new();

            Category baslangic = new ();
            baslangic.Name = "Başlangıçlar";
            baslangic.Description = "xxx";
            categories.Add(baslangic);

            Category anaYemek = new ();
            anaYemek.Name = "Ana Yemekler";
            anaYemek.Description = "yyy";
            categories.Add(anaYemek);

            Category tatli = new ();
            tatli.Name = "Tatlılar";
            tatli.Description = "zzz";
            categories.Add(tatli);

            return categories;

        }
    }
}
