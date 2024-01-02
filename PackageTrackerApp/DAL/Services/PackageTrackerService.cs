using PackageTrackerApp.DAL.Interrfaces;
using PackageTrackerApp.DAL.Services.Repository;
using PackageTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PackageTrackerApp.DAL.Services
{
    public class PackageTrackerService : IPackageTrackerService
    {
        private readonly IPackageTrackerRepository _repository;

        public PackageTrackerService(IPackageTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Package> CreatePackage(Package package)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeletePackageById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Package> GetAllPackages()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Package> GetPackageById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Package> UpdatePackage(Package model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}