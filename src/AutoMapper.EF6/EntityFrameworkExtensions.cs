﻿namespace AutoMapper
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using QueryableExtensions;
    using DelegateDecompiler;
    using DelegateDecompiler.EntityFramework;

    public static class EntityFrameworkExtensions
    {
        public static async Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().ToListAsync();
        }

        public static async Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().ToArrayAsync();
        }

        public static async Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().SingleOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().SingleAsync();
        }

        public static async Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().FirstOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().FirstAsync();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().ToList();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().ToArray();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().SingleOrDefault();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().Single();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().FirstOrDefault();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().First();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile();
        }
    }
}