README:
Format for the dataFile.txt is:
Flight 1099 org.postgresql.Driver jdbc:postgresql://localhost:5432/zair postgres 1998
where Flight is the RMI registry, 1099 - the port, org.postgresql.Driver jdbc:postgresql://localhost:5432/zair - URL for the database, postgres - user for database and 1998 - the password.

When launching the Client from the command line, please type in the IP and port in this format:
localhost 1099
where localhost is the IP and 1099 is the port