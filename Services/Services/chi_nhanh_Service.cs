using DataAccess;
using DataAccess.Models.DanhMuc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Services.IServices;
//using Services.IServices;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Services
{
    public class chi_nhanh_Service : IChi_nhanh_Service
    {


        private DatabaseContext _dbContext;
        public chi_nhanh_Service(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<chi_nhanh> GetAll()
        {
            try
            {
                return _dbContext.chi_nhanhs.ToList();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
