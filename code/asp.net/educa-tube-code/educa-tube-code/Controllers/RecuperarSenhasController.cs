using educa_tube_code.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
namespace educa_tube_code.Controllers
{
    public class RecuperarSenhasController : Controller
    {
        private readonly AppDbContext _context;
        public RecuperarSenhasController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Usuario modelLogin)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(o => o.Email == modelLogin.Email);

            if (user != null)
            {

                SendMail(user.Email, user.Nome, "Aqui está a senha solicitada:" + user.Senha);
                return RedirectToAction("Login", "Login");
            }

            ViewData["ValidateMessage"] = "Usuario não encontrado";
            return View();
        }

        public bool SendMail(string email, string name, string message)
        {

            MailMessage mailMessage = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            mailMessage.From = new MailAddress(email);
            mailMessage.To.Add(email);
            mailMessage.Subject = "";
            mailMessage.IsBodyHtml = true;
            string initialBody = @"<!DOCTYPE html>
							<html lang='en' xmlns='http://www.w3.org/1999/xhtml' xmlns:o='urn:schemas-microsoft-com:office:office'>
							<head>
								<meta charset='UTF-8'>
								<meta name='viewport' content='width=device-width,initial-scale=1'>
								<meta name='x-apple-disable-message-reformatting'>
								<title></title>
								<!--[if mso]>
								<noscript>
									<xml>
										<o:OfficeDocumentSettings>
											<o:PixelsPerInch>96</o:PixelsPerInch>
										</o:OfficeDocumentSettings>
									</xml>
								</noscript>
								<![endif]-->
								<style>
									table, td, div, h1, p {font-family: Arial, sans-serif;}
								</style>
							</head>
							<body style='margin:0;padding:0;'>
								<table role='presentation' style='width:100%;border-collapse:collapse;border:0;border-spacing:0;background:#ffffff;'>
									<tr>
										<td align='center' style='padding:0;'>
											<table role='presentation' style='width:602px;border-collapse:collapse;border:1px solid #cccccc;border-spacing:0;text-align:left;'>
												<tr>
													<td align='center' style='padding:40px 0 30px 0;background:#70bbd9;'>
														<img src='https://assets.codepen.io/210284/h1.png' alt='' width='300' style='height:auto;display:block;' />
													</td>
												</tr>
												<tr>
													<td style='padding:36px 30px 42px 30px;'>
														<table role='presentation' style='width:100%;border-collapse:collapse;border:0;border-spacing:0;'>
															<tr>
																<td style='padding:0 0 36px 0;color:#153643;'>
																	<h1 style='font-size:24px;margin:0 0 20px 0;font-family:Arial,sans-serif;'>Recuperação de Senha</h1>";
            mailMessage.Body = String.Concat(initialBody,@"<p style='margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;'>"+message+@"</p></td></tr></table></body></html>");

            
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("recuperarsenhaeducatube@gmail.com", "ntef onme arcd vpwg");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(mailMessage);
            return true;

        }



    }
}
