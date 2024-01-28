﻿using RecipesApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Business
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
