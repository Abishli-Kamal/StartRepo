using Microsoft.EntityFrameworkCore;
using StarTapBootstarp.DAL;
using StarTapBootstarp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarTapBootstarp.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;

        public LayoutServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Setting>> GetDatas()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return settings;
        }

    }
}
