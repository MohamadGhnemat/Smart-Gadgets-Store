
namespace smartGadgetsStore.Models.Repositorie
{
    public class dbProductReviewRepositorie : IRepositorie<ProductReview>
    {
        public AppDbContext db { get; }
        public dbProductReviewRepositorie(AppDbContext _db)
        {
            db = _db;
        }

        public void Add(ProductReview entity)
        {
            db.ProductReviews.Add(entity);  
            db.SaveChanges();
        }

        public void Delete(int Id, ProductReview entity)
        {
            var data = Find(Id);
            db.ProductReviews.Remove(data);
            db.SaveChanges();
        }

        public ProductReview Find(int Id)
        {
            return db.ProductReviews.SingleOrDefault(x => x.ProductReviewID == Id);
        }

        public void Update(int Id, ProductReview entity)
        {
            db.ProductReviews.Update(entity);
            db.SaveChanges();
        }

        public IList<ProductReview> View()
        {
            return db.ProductReviews.ToList();
        }
    }
}
