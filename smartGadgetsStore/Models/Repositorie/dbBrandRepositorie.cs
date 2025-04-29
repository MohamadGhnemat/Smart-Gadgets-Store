using System.Diagnostics.Metrics;
using System;

namespace smartGadgetsStore.Models.Repositorie
{
    public class dbBrandRepositorie :IRepositorie<Brand>
    {
        public AppDbContext db { get; }

        public dbBrandRepositorie(AppDbContext _db)
        {
            db = _db;
        }


        public void Add(Brand entity)
        {
            db.Brand.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, Brand entity)
        {
            var data = Find(Id);
            db.Brand.Remove(data);
            db.SaveChanges();
        }

        public Brand Find(int Id)
        {
            return db.Brand.SingleOrDefault(x => x.BrandId == Id);
        }

        public void Update(int Id, Brand entity)
        {
            db.Brand.Update(entity);
            db.SaveChanges();
        }

        public IList<Brand> View()
        {
            return db.Brand.ToList();
        }
    }
}
