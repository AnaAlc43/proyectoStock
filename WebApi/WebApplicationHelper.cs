using Stock.DependencyInversion;
//using Stock.WebApi.EndPoint.User;

namespace Stock.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
        {
            // Configurar APIExplorer para descubrir y exponer
            // los metadatos de los endpoints de la aplicación.
            builder.Services.AddEndpointsApiExplorer();

            // Agregar el generador que construye los objetos de
            // documentación de Swagger con la funcionalidad del APIExplorer.
            builder.Services.AddSwaggerGen();

            // Registrar los servicios de la aplicación
            builder.Services.AddControlStockServices(
                builder.Configuration, "MySqlControlstock1DB");

            // Agregar el servicio CORS para clientes que se ejecutan
            // en el navegador Web (como Blazor WebAssembly).
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(config =>
                {
                    config.AllowAnyMethod();
                    config.AllowAnyHeader();
                    config.AllowAnyOrigin();
                });
            });
            try
            {
                return builder.Build();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return default;
            }


        }
        public static WebApplication ConfigureWebApplication(
            this WebApplication app)
        {
            // Habilitar el middleware para servir el documento
            // JSON generado y la interfaz UI de Swagger en el
            // ambiente de desarrollo.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Registrar los endpoints de la aplicación
            //app.GetAllActorEndPoint();
            //app.GetActorEndPoint();
            app.CreateUserEndPoint();
            app.DeleteUserEndPoint();

            // Agregar el Middleware CORS
            app.UseCors();

            return app;
        }
    }
}   
