var builder = WebApplication.CreateBuilder(args);

// Добавляем Razor Pages
builder.Services.AddRazorPages();

// Добавляем авторизацию (даже если не используем политики — требуется для middleware)
builder.Services.AddAuthorization();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization(); // <-- Middleware авторизации

app.MapRazorPages();

app.Run();