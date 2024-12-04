## hackaton huinit

### MySQL Server
Работает на порте 3306

Нужно создать пользователя root_user с root правами:

'''sql
CREATE USER 'root_user' IDENTIFIED BY 'ip214';
GRANT ALL PRIVILEGES ON * . * TO 'root_user';
'''