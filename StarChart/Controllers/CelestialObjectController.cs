﻿using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        CelestialObjectController(ApplicationDbContext _context)
        {
            this._context = _context;
        }
    }
}
