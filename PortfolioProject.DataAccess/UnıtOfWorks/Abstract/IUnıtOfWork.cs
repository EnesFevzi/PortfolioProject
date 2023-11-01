using PortfolioProject.Core.Entities.Abstract;
using PortfolioProject.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccess.UnıtOfWorks.Abstract
{
	public interface IUnıtOfWork : IAsyncDisposable
	{
		IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
      
        Task<int> SaveAsync();
		int Save();
	}
}
