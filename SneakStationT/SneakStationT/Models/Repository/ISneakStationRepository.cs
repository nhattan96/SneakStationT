using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SneakStationT.Models.DAL;

namespace SneakStationT.Models.Repository
{
    public interface ISneakStationRepository : IDisposable
    {
        Product getProductById(int? productId);
    }
}