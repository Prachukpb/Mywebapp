using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using mywebapp.Data;
using mywebapp.Model;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace mywebapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyContext _context;

        public IndexModel(MyContext context)
        { _context = context; }

        [BindProperty]
        public Emails Contact { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contact.messagedOn = DateTime.Now;
                    _context.Add(Contact);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException /* ex */)
            {
                ////Log the error (uncomment ex variable name and write a log.
                //ModelState.AddModelError("", "Unable to save changes. " +
                //    "Try again, and if the problem persists " +
                //    "see your system administrator.");
            }

            MailMessage message = new MailMessage();
            message.From = new MailAddress("postmaster@webpbk.tech");
            message.To.Add("prachukpb@gmail.com");
            message.Subject = Contact.Name + " - " + Contact.Phone + " - " + Contact.Emailaddr;
            message.Body = Contact.Message;
            SmtpClient client = new SmtpClient("mail.webpbk.tech");
            client.Port = 8889;
            client.UseDefaultCredentials = false;
            client.EnableSsl = false;
            client.Credentials = new System.Net.NetworkCredential("postmaster@webpbk.tech", "Scorpten@1191");
            client.Send(message);
            client.Dispose();
            //return Redirect("http://webpbk.tech/");
            return Page();
        }
    }
}