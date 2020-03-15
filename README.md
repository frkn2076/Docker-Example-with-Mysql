# Docker-Example-with-Mysql
Docker Example with Mysql

1) Install docker
2) Follow the instrucitons to load mysql container here *https://hub.docker.com/_/mysql*
3) docker ps => To see if Mysql container is okay as

   I have just matched the 3306 port of my docker with my local 3306 port as **0.0.0.0:3306->3306/tcp, 33060/tcp**
   
   Then go in mysql container with **docker exec -it {ContainerID} bash**
   
        Some sql commands to:
        - Create db
        - Create table
        - Insert data
        
4) Check whether it works fine by the simple project.
