﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList5.Models
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories { get; }
        Category Save(Category category);
        Category Edit(Category category);
        void Remove(Category category);
    }
}
