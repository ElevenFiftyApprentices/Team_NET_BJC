using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.DAL
{
    public class ListInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ListContext>
    {
        protected override void Seed(ListContext context)
        {
            var ListItems = new List<ShoppingListItem>
            {
                new ShoppingListItem{shoppingItemId = 1, shoppingListId = 1, ListContent = "Eggs", Priority = 0},
                new ShoppingListItem{shoppingItemId = 2, shoppingListId = 1, ListContent = "bacon", Priority = 2},
                new ShoppingListItem{shoppingItemId = 3, shoppingListId = 1, ListContent = "grits", Priority = 1},
                new ShoppingListItem{shoppingItemId = 4, shoppingListId = 1, ListContent = "sausage", Priority = 0}

            };
            ListItems.ForEach(s => context.ShoppingListItems.Add(s));
            context.SaveChanges();



            var ListsShopping = new List<ListShopping>
            {
                new ListShopping{shoppingListId = 1, ListName = "Grocery", Color = "#FFFFFF"}
            };
            ListItems.ForEach(s => context.ShoppingLists.Add(s));
            context.SaveChanges();
            
        
        }

    }
}