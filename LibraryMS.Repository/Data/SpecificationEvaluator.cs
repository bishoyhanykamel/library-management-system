using LibraryMS.Core.Entities;
using LibraryMS.Core.Interfaces.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Repository.Data
{
	public class SpecificationEvaluator<T> where T : BaseEntity
	{
		public static IQueryable<T> BuildQuery(IQueryable<T> mainQuery, IBaseSpecification<T> specs)
		{
			var modifiedQuery = mainQuery;

			if (specs.Criteria != null)
				modifiedQuery = mainQuery.Where(specs.Criteria);

			modifiedQuery = specs.Includes.Aggregate(modifiedQuery, (tempQuery, include) => tempQuery.Include(include));

			return modifiedQuery;
		}
    }
}
