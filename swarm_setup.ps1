#Initializing swarn on external network virtual switch
docker swarm init --advertise-addr 10.10.103.33
#Initializing swarn on docker nat
#docker swarm init --advertise-addr 10.0.75.1
#docker swarm leave --force