using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;

namespace FitnessClub.Tools
{
    public static class ObjetContextExtention
    {
        public static IQueryable<TEntity> LoadAndInclude<TEntity>(this ObjectContext context, IQueryable<TEntity> elements, string includePath) where TEntity : class, System.Data.Objects.DataClasses.IEntityWithRelationships
        {
            var query = elements as ObjectQuery<TEntity>;

            if (query == null)
            {
                query = AsEntityCollection<TEntity>(elements).CreateSourceQuery();
            }

            return query.Include(includePath);

        }
        private static EntityCollection<TEntity> AsEntityCollection<TEntity>(IEnumerable<TEntity> elements) where TEntity : class, System.Data.Objects.DataClasses.IEntityWithRelationships
        {
            var entityCollection = elements as EntityCollection<TEntity>;
            if (entityCollection == null)
                throw new ApplicationException("Object is not an EntityCollection<TEntity>");

            return entityCollection;
        }

        public static void SetAllModified<T>(this T entity, ObjectContext context) where T : IEntityWithKey
        {
            var stateEntry = context.ObjectStateManager.GetObjectStateEntry(entity.EntityKey);

            var propertyNameList = stateEntry.CurrentValues.DataRecordInfo.FieldMetadata.Select(pn => pn.FieldType.Name);

            foreach (var propName in propertyNameList)
            {
                stateEntry.SetModifiedProperty(propName);
            }
        }

        public static TResult NextId<TSource, TResult>(this ObjectQuery<TSource> table, Expression<Func<TSource, TResult>> selector)
        where TSource : class
        {
            TResult lastId = table.Any() ? table.Max(selector) : default(TResult);

            if (lastId is int)
            {
                lastId = (TResult)(object)(((int)(object)lastId) + 1);
            }

            return lastId;
        }

    }
}
