using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.ViewModel;

namespace WebApplication3.Pages.Components
{
    [ViewComponent(Name = "PriorityList")]
    public class DefaultModel : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(
            string maxPriority, string isDone)
        {
            string MyView = "Default";
            var items = new List<TodoItem>()
            {
                new TodoItem{Name = maxPriority, Message= "wwwwwwww"},
                new TodoItem{Name = isDone, Message = "aaaaaaa" }
            };
            
            return View(MyView, items);
        }       
    }
}