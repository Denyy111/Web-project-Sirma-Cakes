﻿namespace SirmaCakes.Web.ViewModels.ViewModels.Orders
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class CreateOrderInputModel
    {
        [StringLength(255)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [StringLength(255)]
        [Display(Name = "Address Line 1")]
        [Required(ErrorMessage = "Address Line 1 is required")]
        public string AddressLine1 { get; set; }

        [StringLength(255)]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [StringLength(6)]
        [Required(ErrorMessage = "Zipcode is required")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        // Allow for long personal notes 
        [StringLength(500)]
        [Display(Name = "Personal Note")]
        public string Personal_Note { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]

        public decimal OrderTotal { get; set; }

        // time for delivery
        public DateTime OrderPlacedTime { get; set; }

        public IEnumerable<CakeOrderInfo> CakeOrderInfo { get; set; }
    }
}