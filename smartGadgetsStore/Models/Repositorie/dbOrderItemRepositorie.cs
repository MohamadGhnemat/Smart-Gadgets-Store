
using Microsoft.EntityFrameworkCore;

namespace smartGadgetsStore.Models.Repositorie
{
    public class dbOrderItemRepositorie : IRepositorie<OrderItem>
    {
        public AppDbContext db { get; }

        public dbOrderItemRepositorie(AppDbContext _db)
        {
            db = _db;
        }
        public void Add(OrderItem entity)
        {
            db.OrderItems.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, OrderItem entity)
        {
            var data = Find(Id);
            db.OrderItems.Remove(data);
            db.SaveChanges();   
        }

        public OrderItem Find(int Id)
        {
            return db.OrderItems.Include(x => x.Product).Include(x => x.Order).ThenInclude(O => O.User).SingleOrDefault(x => x.OrderItemID == Id);
        }

        public void Update(int Id, OrderItem entity)
        {
            db.OrderItems.Update(entity);
            db.SaveChanges();
        }

        public IList<OrderItem> View()
        {
            return db.OrderItems.Include(x=>x.Product).Include(x=>x.Order).ThenInclude(O=>O.User).ToList();
        }
    }
}
