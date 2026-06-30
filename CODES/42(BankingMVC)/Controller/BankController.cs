using Microsoft.AspNetCore.Mvc;
using BankingMVC.Models;

namespace BankingMVC.Controllers
{
    public class BankController : Controller
    {
        static Account account = new Account();

        public IActionResult Index()
        {
            return View();
        }

        // Create Account

        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(Account acc)
        {
            account.AccountNumber = acc.AccountNumber;
            account.CustomerName = acc.CustomerName;
            account.Balance = acc.Balance;

            ViewBag.Message = "Account Created Successfully";

            return View();
        }

        // Deposit

        public IActionResult Deposit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Deposit(double amount)
        {
            account.Balance += amount;

            ViewBag.Message = "Amount Deposited Successfully";

            return View();
        }

        // Withdraw

        public IActionResult Withdraw()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Withdraw(double amount)
        {
            if (amount <= account.Balance)
            {
                account.Balance -= amount;
                ViewBag.Message = "Withdrawal Successful";
            }
            else
            {
                ViewBag.Message = "Insufficient Balance";
            }

            return View();
        }

        // Balance

        public IActionResult Balance()
        {
            return View(account);
        }
    }
}
