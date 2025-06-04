
using Microsoft.EntityFrameworkCore;

namespace smartGadgetsStore.Models.Repositorie
{
    public class dbUserRepositorie : IRepositorie<User>
    {
        public AppDbContext db { get; }
        public dbUserRepositorie(AppDbContext _db)
        {
               db = _db;
        }
        public void Add(User entity)
        {
           db.Users.Add(entity);
           db.SaveChanges();
        }

        public void Delete(int Id, User entity)
        {
            var data = Find(Id);
            db.Users.Remove(data);
            db.SaveChanges();
        }

        public User Find(int Id)
        {
            return db.Users.Include(x => x.UserType).SingleOrDefault(x => x.UserID == Id);
        }

        public void Update(int Id, User entity)
        {
            db.Users.Update(entity);
            db.SaveChanges();
        }

        public IList<User> View()
        {
           return db.Users.Include(x=>x.UserType).ToList();
        }
    }
}
