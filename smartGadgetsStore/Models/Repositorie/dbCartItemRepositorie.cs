
using Microsoft.EntityFrameworkCore;

namespace smartGadgetsStore.Models.Repositorie
{
    public class dbCartItemRepositorie : IRepositorie<CartItem>
    {
        public AppDbContext db { get; }
        public dbCartItemRepositorie(AppDbContext _db)
        {
            db = _db;
        }

        public void Add(CartItem entity)
        {
           db.CartItems.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, CartItem entity)
        {
            var data =Find(Id);
            db.CartItems.Remove(data);
            db.SaveChanges();
        }

        public CartItem Find(int Id)
        {
            return db.CartItems.Include(x => x.User).Include(x => x.Product).SingleOrDefault(x => x.CartItemID == Id);
        }

        public void Update(int Id, CartItem entity)
        {
            db.CartItems.Update(entity);
            db.SaveChanges();
        }

        public IList<CartItem> View()
        {
            return db.CartItems.Include(x=>x.User).Include(x=>x.Product).ToList();
        }
    }
}
