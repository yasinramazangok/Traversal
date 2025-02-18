using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Traversal.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<TraversalUser> _traversalUserManager;
        public PasswordChangeController(UserManager<TraversalUser> traversalUserManager)
        {
            _traversalUserManager = traversalUserManager;
        }

        [HttpGet]
        public IActionResult ChangeForgottenPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangeForgottenPassword(ForgotPasswordViewModel forgotPasswordViewModel)
        {
            var user = await _traversalUserManager.FindByEmailAsync(forgotPasswordViewModel.Email);
            string passwordResetToken = await _traversalUserManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetTokenLink = Url.Action("ResetPassword", "PasswordChange", new
            {
                userId = user.Id,
                token = passwordResetToken
            }, HttpContext.Request.Scheme);

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "yasinramazanprojegonderici@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", forgotPasswordViewModel.Email);

            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = passwordResetTokenLink;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre Değişiklik Talebi";

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("yasinramazanprojegonderici@gmail.com", "akoxjiqdwesnqlfn");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string userid, string token)
        {
            TempData["userid"] = userid;
            TempData["token"] = token;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            var userId = TempData["userid"];
            var token = TempData["token"];

            if (userId == null || token == null)
            {
                ModelState.AddModelError("", "Şifre sıfırlama bağlantınız geçersiz veya süresi dolmuş.");
                return View();
            }

            var user = await _traversalUserManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı.");
                return View();
            }

            var result = await _traversalUserManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View();
        }
    }
}
