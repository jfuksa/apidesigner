using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Packeta API", Version = "v1" });   
    
    // add documentation to swagger output
    var xmlCommentFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.xml", SearchOption.TopDirectoryOnly).ToList();
    xmlCommentFiles.ForEach(file => options.IncludeXmlComments(file, true));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.yaml", "Packeta API");
        //options.RoutePrefix = string.Empty;
    });   
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();