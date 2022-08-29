﻿using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Domain.Entitites;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ColorRepository : EfRepositoryBase<Color, BaseDbContext>, IColorRepository
    {
        public ColorRepository(BaseDbContext context) : base(context)
        {
        }
    }
}