namespace API.Infrastructure.IoC;

public static class Bootstrapper
{
    public static IServiceCollection Inject(this IServiceCollection services, IConfiguration configuration)
    {
        InjectMediator(services);
        InjectRepositories(services);

        return services;
    }

    public static void InjectMediator(IServiceCollection services)
    {
        var assemblies = new Assembly[]
        {
            typeof(CreateEntityCommandHandler).Assembly,
            typeof(UpdateEntityCommandHandler).Assembly,
            typeof(DeleteEntityCommandHandler).Assembly,

            typeof(GetAllEntityQueryHandler).Assembly
        };

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(
                assemblies
            );
        });
    }

    public static void InjectRepositories(IServiceCollection services)
    {
        services.AddSingleton<IEntityRepository>(sp =>
        {
            return new EntityRepository("entity");
        });
    }
}