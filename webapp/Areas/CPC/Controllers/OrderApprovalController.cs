using BaseApp.Entity;
using BaseApp.System;
using CPC;
using CPC.Model;
using ImageResizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Areas.CPC.Controllers
{
    [AppAuthorize(AppPermission.All, AppPermission.CPC)]

    public class OrderApprovalController : AppController
    {
        private OrderbookingEntity orderbookingRepo;
        private BranchEntity branchRepo;
        private Common commonRepo;
        private CPHEntity cashpPocessinHousegRepo;

        public OrderApprovalController()
        {
            orderbookingRepo = new OrderbookingEntity();
            branchRepo = new BranchEntity();
            commonRepo = new Common();
            cashpPocessinHousegRepo = new CPHEntity();
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _AllOrders()
        {
            var model = orderbookingRepo.GetAll();
            ViewBag.DetailsList = orderbookingRepo.GetAllDetails();
            return PartialView(model);
        }
        #region Details
        public ActionResult Details(Guid Id)
        {
            var model = orderbookingRepo.GetById(Id);
            ViewBag.Details = orderbookingRepo.GetAllDetailsById(Id);
            return View(model);
        }
        #endregion

        #region Delete
        [HttpPost]
        public JsonResult Approve(Guid Id)
        {
            try
            {
                #region Activity Log
                //appLog.Create(CurrentUser.OfficeId, Id, CurrentUser.Id, AppLogType.Activity, "CRM", "Contact Deleted", "~/CRM/Contact/Delete > HttpPost", "<table class='table table-hover table-striped table-condensed' style='margin-bottom:15px;'><tr><th class='text-center'>Description</th></tr><tr><td>Contact deleted by <strong>" + CurrentUser.FullName + "</strong>.</td></tr></table>");
                #endregion
                var res = orderbookingRepo.ApproveRequest(Id, CurrentUser.Id);
                if (res) {
                    TempData["SuccessMsg"] = "Order has been Approved successfully.";
                }
                TempData["ErrorMsg"] = "We have encountered an error while processing your request, Please see log for details.";
            }
            catch (Exception ex)
            {
                #region Error Log
                //appLog.Create(CurrentUser.OfficeId, null, CurrentUser.Id, AppLogType.Error, "CRM", ex.GetType().Name.ToSpacedTitleCase(), "~/CRM/Contact/Delete > HttpPost", "<table class='table table-hover table-striped'><tr><th class='text-right'>Source</th><td>" + ex.Source + "</td></tr><tr><th class='text-right'>URL</th><td>" + Request.Url.ToString() + "</td></tr><tr><th class='text-right'>Message</th><td>" + ex.Message + "</td></tr></table><table class='table table-hover table-striped table-condensed'><tr><th class='text-center'>Inner Exception</th></tr><tr><td>" + ex.InnerException + "</td></tr><tr><th class='text-center'>Stack Trace</th></tr><tr><td>" + ex.StackTrace.ToString() + "</td></tr></table>");
                #endregion

                TempData["ErrorMsg"] = "We have encountered an error while processing your request, Please see log for details.";
            }
            return Json(true);
        }
        #endregion
    }
}