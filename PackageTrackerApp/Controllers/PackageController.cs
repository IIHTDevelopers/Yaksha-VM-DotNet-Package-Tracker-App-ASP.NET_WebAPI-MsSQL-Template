using PackageTrackerApp.DAL.Interrfaces;
using PackageTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PackageTrackerApp.Controllers
{
    public class PackageController : ApiController
    {
        private readonly IPackageTrackerService _service;
        public PackageController(IPackageTrackerService service)
        {
            _service = service;
        }
        public PackageController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Package/CreatePackage")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreatePackage([FromBody] Package model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Package/UpdatePackage")]
        public async Task<IHttpActionResult> UpdatePackage([FromBody] Package model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Package/DeletePackage")]
        public async Task<IHttpActionResult> DeletePackage(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Package/GetPackageById")]
        public async Task<IHttpActionResult> GetPackageById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Package/GetAllPackages")]
        public async Task<IEnumerable<Package>> GetAllPackages()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
