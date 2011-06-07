﻿using System.Linq;

namespace CodeSmith.Data.NHibernate
{
    public interface IView<T> : IQueryable<T>
        where T : class
    {
        DataContext DataContext { get; }
    }
}