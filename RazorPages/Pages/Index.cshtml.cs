using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages;

public record Category(int Id, string Title, decimal Price);

public class Index : PageModel
{
    public List<Category> Categories { get; set; } = [];

    public async Task OnGet()
    {
        await Task.Delay(3000);
        for (var i = 0; i <= 100; i++)
        {
            Categories.Add(new Category(i, $"Categoria {i}", i * 18.95M));
        }
    }
    
    public void OnPost()
    {
        
    }
}
