## Расписание занятий

## Руководство по установке:

1. Установить Node.js
   
```https://nodejs.org/en/download/package-manager```

2. Клонировать репозиторий

```git clone https://github.com/robeN1337/SKSschedule_hackaton.git```

3. Создать БД. Скрипт создания находится по пути "API/db.sql"
   
4. Нужно создать пользователя `root_user` с root правами:

```sql
CREATE USER 'root_user' IDENTIFIED BY 'ip214';
GRANT ALL PRIVILEGES ON * . * TO 'root_user';
```

5. Подключаем MySQL в `Program.cs`:

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

6. Заходим в директорию со склонированным репозиторием через Powershell или терминал VS Code (powershell):

```cd путь_до_папки_с_репозиторием/SKSschedule_hackaton/sksschedule.react```

7. Устанавливаем необходимые пакеты для работы:

```npm install```

8. После установки прописываем команду для запуска:
   
```npm start```

9. После старта сервер запускается по адресу http://localhost:3000
