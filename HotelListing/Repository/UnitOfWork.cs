using HotelListing.Data;
using HotelListing.IRepository;
using System;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Private Fields
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotel> _hotels; 
        #endregion

        #region Ctor
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        } 
        #endregion

        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public async Task Save() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(true);
        }
    }
}
