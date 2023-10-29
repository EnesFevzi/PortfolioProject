using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.WebUI.Models
{
	public class CaptchaViewModel
	{
		[Required]
        public string Captcha { get; set; }
    }
}
