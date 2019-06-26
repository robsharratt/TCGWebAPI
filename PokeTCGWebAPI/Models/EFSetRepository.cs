﻿using System.Collections.Generic;
using System.Linq;

namespace PokeTCGWebAPI.Models
{
    public class EFSetRepository :ISetRepository
    {
        private ApplicationDbContext context;

        public EFSetRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Set> Sets => context.Sets;
    }
}
