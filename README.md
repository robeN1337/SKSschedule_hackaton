## hackaton huinit

### MySQL Server
Нужно создать пользователя `root_user` с root правами:

```sql
CREATE USER 'root_user' IDENTIFIED BY 'ip214';
GRANT ALL PRIVILEGES ON * . * TO 'root_user';
```

MySQL код базы данных находится в "API/db.sql"

Подключаем MySQL в `Program.cs`:

```csharp
var connection = builder.Configuration.GetConnectionString("SksDbContext");
```

```csharp
builder.Services.AddDbContext<SksDbContext>(
    options =>
    {
        options.UseMySql(connection, new MySqlServerVersion(new Version(9, 1, 0)));
    });
```

Соединение находится в `appsettings.Development.json`:

```json
"ConnectionStrings": {
    "SksDbContext": "User ID=root_user;Password=ip214;Host=localhost;Port=3306;Database=db_sks"
  }
```


