using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Extensions
{
    public static class LoggedInUserExtensions
    {
        public static Guid GetLoggedInUserId(this ClaimsPrincipal principal)
        {
			//return Guid.Parse(principal.FindFirstValue(ClaimTypes.NameIdentifier));
			var userIdClaim = principal.FindFirst(ClaimTypes.NameIdentifier);
			if (userIdClaim != null && !string.IsNullOrEmpty(userIdClaim.Value))
			{
				return Guid.Parse(userIdClaim.Value);
			}

			// Eğer id değeri bulunamazsa veya geçersizse burada bir hata yönetimi yapabilirsiniz.
			throw new InvalidOperationException("User ID not found or is invalid.");

		}
        public static string GetLoggedInEmail(this ClaimsPrincipal principal)
        {
            return principal.FindFirstValue(ClaimTypes.Email);
        }
    }
}
