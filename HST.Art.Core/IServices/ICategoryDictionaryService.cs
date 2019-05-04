﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HST.Art.Core
{
    public interface ICategoryDictionaryService : IBaseService
    {
        List<CategoryDictionary> GetAll(CategoryType categoryType);
        CategoryDictionary Get(int id);
        bool Update(CategoryDictionary categoryInfo);
        bool Add(CategoryDictionary categoryInfo);
    }
}