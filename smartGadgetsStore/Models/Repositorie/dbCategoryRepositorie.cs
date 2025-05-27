
namespace smartGadgetsStore.Models.Repositorie
{
    public class dbCategoryRepositorie : IRepositorie<Category>
    {
        public AppDbContext db {  get;  }
        public dbCategoryRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, Category entity)
        {
            var data = Find(Id);
            db.Categories.Remove(data);
            db.SaveChanges();
        }

        public Category Find(int Id)
        {
            return db.Categories.SingleOrDefault(x => x.CategoryID == Id);
        }

        public void Update(int Id, Category entity)
        {
            db.Categories.Update(entity);
            db.SaveChanges();
        }

        public IList<Category> View()
        {
           return db.Categories.ToList();
        }
    }
}
