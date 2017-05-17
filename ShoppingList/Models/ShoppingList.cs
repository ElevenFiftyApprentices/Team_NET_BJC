using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ShoppingList
    {
        [Key]
        public int shoppingListId { get; set; }
        public int UserId { get; set; }
        [Required]
        [Display(Name = "Shopping List")]
        public string ListName { get; set; }
        public string Color { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd)", ApplyFormatInEditMode = true)]
        [Display(Name = "Creation Date")]
        public DateTimeOffset CreatedUtc { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd)", ApplyFormatInEditMode = true)]
        [Display(Name = "Edited Date")]
        public DateTimeOffset ModifiedUtc { get; set; }


    }
}