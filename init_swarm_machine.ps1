docker-machine create -d hyperv --hyperv-virtual-switch "Primary Virtual Switch" manager1
docker-machine ip manager1
#10.10.103.100
#Run on ssh:
#docker swarm join --token SWMTKN-1-42hbcsaw36mnoxnw8cmhz0kjtby9cxgj3pksycg8ml4d44untg-bx57h0iy6voq8a1nwco8cm2nd 10.10.103.100:2377