using DataAccess.Models.DanhMuc;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IChi_nhanh_Service
    {
        List<chi_nhanh> GetAll();
    }
}
