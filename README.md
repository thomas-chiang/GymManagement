```
dotnet ef database update -p src/GymManagement.Infrastructure/ -s src/GymManagement.Api
```
```
infrastructure - authentication:
services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)

application - authorization:
options.AddOpenBehavior(typeof(AuthorizationBehavior<,>));

presentation - authorization:
services.AddScoped<ICurrentUserProvider, CurrentUserProvider>();

```