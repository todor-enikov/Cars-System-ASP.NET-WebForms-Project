﻿using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsSystem.WebForms.Client.Filters
{
    public partial class FilterByVignette : System.Web.UI.Page
    {
        [Inject]
        public IMailService MailService { get; set; }

        [Inject]
        public IFilterService FilterService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            var filteredCars = FilterService.FilterExpiringVignetteCars().ToList();
            this.FilterGridView.DataSource = filteredCars;
            this.FilterGridView.DataBind();
        }

        protected void SendMailButton_Click(object sender, EventArgs e)
        {
            var subject = this.EmailSubjectTextBox.Text;
            var content = this.EmailContentBox.Text;

            var emails = FilterService.GetMailsForCarsVignetteExpiration().ToList();
            MailService.SendEmail(subject, content, emails);
        }
    }
}