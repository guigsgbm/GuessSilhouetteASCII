# GuessSilhouetteASCII

- Basic app to develop my programming techniques.

- In that case I used some new technologies, like PostgresDB in docker container.

```
su - postgres

createuser gsauser
createdb gsadb

psql

alter user gsauser with encrypted password 'qwerty';
grant all privileges on database gsadb to gsauser;
ALTER DATABASE gsadb OWNER TO gsauser;
```
