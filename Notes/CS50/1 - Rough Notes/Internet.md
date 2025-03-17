# What's actually happening under the hood?

- We have routers/computers/servers from all around the globe connected with each other making a wide network (wired or wireless) which allows the data to flow for example from point A to point B to point C.

- Routing or this travelling of data from point X to point Y is handled by big companies/orgs.

- The routing data will use any free nodes/routers to get the data from point A to B. Incase any node/router in the network is congested or unable to traverse the data, the data is routed through a different node. This system makes sure that the data sent and received properly.

# TCP/IP (Routing protocols)

These are just protocols/rules that the computers/routers/servers follow when sending, traversing or receiving data. 

## IP (Internet Protocol)

- This decides/dictates that every computer on the internet will have a unique IP address. This address will look like: '#.#.#.#' where # can be an integer, for example: 1.2.3.4. These IP addresses uniquely identify computers on our big network aka internet.

- This #.#.#.# is a total of 32 bits which means we can have roughly 4 billion uniquely identified computers. This is aka IPv4 (Older Version)

- The newer version of IP introduced aka IPv6, gives us 128 bits which allows us to have a lot more than 4 billion computers.

## TCP (Transmission Control Protocol)

- Now the IP address alone is not sufficient enough to transmit various kinds of data efficiently (How does the receiver computer know that the message sent is a chat message or a email or a video). So to distinguish one type of internet service from another, we have __TCP (Transmission Control Protocol)__. 

- Different services are now identified by different numbers and the two of the most common are:
	- 80 - HTTP
		Vulnerable to interception, or un-encrypted.
	- 443 - HTTPS
		Secured or encrypted.

# DNS (Domain Name System)
Now every server/router/computer will have a unique IP address, and now each computer can use these IP addresses to request and send data. But for us humans its hard to remember all the addresses and to solve this problem **DNS (Domain Name System)** comes in which links all these IP addresses to a name, for example: 1.2.3.4:443 is can be linked to google.com. So we can say that:

DNS is a collection of servers on the internet whose purpose in life is to convert domain names to IP addre