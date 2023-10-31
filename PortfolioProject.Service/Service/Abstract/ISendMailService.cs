using PortfolioProject.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Abstract
{
	public interface ISendMailService
	{
		Task<bool> SendMail(MailRequest mailRequest);
	}
}
