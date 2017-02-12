﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Data.Models
{
    public class User : IdentityUser
    {
        private ICollection<Car> cars;

        public User()
        {
            this.cars = new HashSet<Car>();
        }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string SecondName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public long EGN { get; set; }

        [Required]
        public int NumberOfIdCard { get; set; }

        [Required]
        public DateTime DateOfIssue { get; set; }

        [Required]
        [MinLength(0)]
        [MaxLength(20)]
        public string City { get; set; }

        [Required]
        public override string PhoneNumber { get; set; }

        public virtual ICollection<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }

        public ClaimsIdentity GenerateUserIdentity(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }
    }
}