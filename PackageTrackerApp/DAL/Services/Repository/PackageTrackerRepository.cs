using PackageTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PackageTrackerApp.DAL.Services.Repository
{
    public class PackageTrackerRepository : IPackageTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public PackageTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Package> CreatePackage(Package package)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePackageById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Package> GetAllPackages()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Package> GetPackageById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }       

        public async Task<Package> UpdatePackage(Package model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}