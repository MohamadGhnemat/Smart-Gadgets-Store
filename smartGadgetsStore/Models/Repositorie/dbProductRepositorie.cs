﻿
namespace smartGadgetsStore.Models.Repositorie
{
    public class dbProductRepositorie : IRepositorie<Product>
    {
        public AppDbContext db { get; }
        public dbProductRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, Product entity)
        {
           var data = Find(Id);
            db.Products.Remove(data);
            db.SaveChanges();
        }

        public Product Find(int Id)
        {
            return db.Products.SingleOrDefault(x => x.ProductID == Id);
        }

        public void Update(int Id, Product entity)
        {
           db.Products.Update(entity);
            db.SaveChanges();
        }

        public IList<Product> View()
        {
            return db.Products.ToList();
        }
    }
}
